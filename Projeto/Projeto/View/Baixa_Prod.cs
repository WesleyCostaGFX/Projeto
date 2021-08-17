using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.View
{
    public partial class Saida_Prod : Form
    {
        public int id_estoque = -1;
        public int quantidade = 0;
        public int id_produto = -1;
        public Saida_Prod()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (id_estoque > -1)
            {
                quantidade = int.Parse(lv_estoque.SelectedItems[0].SubItems[7].Text) - int.Parse(tb_qtde.Text);
                if (quantidade < 0 || quantidade> int.Parse(lv_estoque.SelectedItems[0].SubItems[7].Text))
                {
                    MessageBox.Show("Favor inserir um valor válido");
                }
                else
                {
                    Cadastro_estoque baixa = new Cadastro_estoque();
                    baixa.dar_baixa(id_estoque, quantidade);
                    MessageBox.Show(baixa.mensagem);
                }
            }
            else
            {
                MessageBox.Show("Favor selecionar um item na tabela ao lado!");
            }
            limpar();
        }

        private void Saida_Prod_Load(object sender, EventArgs e)
        {
            carregarlvcomp();
        }
        public void carregarlv()
        {
            lv_estoque.LabelEdit = false;
            lv_estoque.AllowColumnReorder = true;
            lv_estoque.FullRowSelect = true;
            try
            {
                Conexao conexao = new Conexao();
                //Comando SQL --SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from estoque where id_produto = @id_produto";
                cmd.Parameters.AddWithValue("@id_produto", id_produto);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.conectar();
                SqlDataReader estoque = cmd.ExecuteReader();
                lv_estoque.Items.Clear();
                while (estoque.Read())
                {
                    var lista = new ListViewItem(estoque.GetInt32(0).ToString());
                    lista.SubItems.Add(estoque.GetInt32(1).ToString());
                    lista.SubItems.Add(estoque.GetString(2));
                    lista.SubItems.Add(estoque.GetInt32(3).ToString());
                    lista.SubItems.Add(estoque.GetString(4));
                    lista.SubItems.Add(estoque.GetString(5));
                    lista.SubItems.Add(estoque.GetDateTime(6).ToString("dd/MM/yyyy"));
                    lista.SubItems.Add(estoque.GetInt32(7).ToString());
                    lv_estoque.Items.Add(lista);
                }
                conexao.desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }

        private void lv_estoque_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void carregarlvcomp()
        {
            lv_estoque.LabelEdit = false;
            lv_estoque.AllowColumnReorder = true;
            lv_estoque.FullRowSelect = true;
            try
            {
                Conexao conexao = new Conexao();
                //Comando SQL --SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from estoque";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.conectar();
                SqlDataReader estoque = cmd.ExecuteReader();
                lv_estoque.Items.Clear();
                while (estoque.Read())
                {
                    var lista = new ListViewItem(estoque.GetInt32(0).ToString());
                    lista.SubItems.Add(estoque.GetInt32(1).ToString());
                    lista.SubItems.Add(estoque.GetString(2));
                    lista.SubItems.Add(estoque.GetInt32(3).ToString());
                    lista.SubItems.Add(estoque.GetString(4));
                    lista.SubItems.Add(estoque.GetString(5));
                    lista.SubItems.Add(estoque.GetDateTime(6).ToString("dd/MM/yyyy"));
                    lista.SubItems.Add(estoque.GetInt32(7).ToString());
                    lv_estoque.Items.Add(lista);
                }
                conexao.desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void lv_estoque_MouseClick(object sender, MouseEventArgs e)
        {
            id_estoque = int.Parse(lv_estoque.SelectedItems[0].SubItems[0].Text);
            tb_qtde.Text = "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        public void limpar()
        {
            id_estoque = -1;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Text = string.Empty;
                if (c is CheckBox)
                    ((CheckBox)c).Checked = false;
                if (c is MaskedTextBox)
                    ((MaskedTextBox)c).Text = string.Empty;
                if (c is MonthCalendar)
                    ((MonthCalendar)c).SetDate(DateTime.Today);
            }
            carregarlvcomp();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_qtde_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_codigo_TextChanged(object sender, EventArgs e)
        {
            if (tb_codigo.Text != string.Empty)
            {
                id_produto = int.Parse(tb_codigo.Text);
                carregarlv();
            }
            else
            {
                carregarlvcomp();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
