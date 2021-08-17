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
    public partial class Entrada_Prod : Form
    {
        public int id_produto = -1;
        public int id_estoque = -1;
        public string nome_prod = "-";
        public int qtd_atual = 0;
        public double valor_prod = 0;
        public Entrada_Prod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_cod.Text != string.Empty && lbl_nomeprod.Text != string.Empty && tb_lote.Text != string.Empty && aaa.Text != string.Empty && cb_forn.Text != string.Empty && int.Parse(aaa.Text) >= 0) {
                if (id_estoque == -1) {
                    if (int.Parse(aaa.Text) > 0)
                    {
                        string[] inforn = cb_forn.Text.Split('-');
                        Cadastro_estoque cad = new Cadastro_estoque();
                        cad.cadastro_estoque(id_produto, buscarnomeprod(), int.Parse(inforn[0]), inforn[1], tb_lote.Text, cal_fab.SelectionEnd, int.Parse(aaa.Text), buscarprecoprod());
                        MessageBox.Show(cad.mensagem);
                    }
                    else
                    {
                        MessageBox.Show("Quantidade deve ser maior que 0!");
                    }
                }
                else
                {
                    nome_prod = buscarnomeprod();
                    id_produto = int.Parse(tb_cod.Text);
                    string[] inforn = cb_forn.Text.Split('-');
                    Cadastro_estoque editar = new Cadastro_estoque();
                    editar.editar_estoque(id_estoque, id_produto, nome_prod, int.Parse(inforn[0]), inforn[1], tb_lote.Text, cal_fab.SelectionEnd, int.Parse(aaa.Text)+qtd_atual, buscarprecoprod());
                    MessageBox.Show(editar.mensagem);
                }
                limpar();
            }
            else
            {
                MessageBox.Show("Favor preencher todos os campos para adicionar um novo lote ou selecionar um dado na tabela para editar o seu valor! \nOBS: OS VALORES PARA ADIÇÃO DE ITENS DEVEM SER POSITIVOS!");
            }
            carregarlv();
        }
        public string buscarnomeprod()
        {
            try
            {
                id_produto = int.Parse(tb_cod.Text);
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select nome_produto from produto where id_produto = @id_produto";
                cmd.Parameters.AddWithValue("@id_produto", id_produto);
                cmd.Connection = conexao.conectar();
                SqlDataReader nome_produto = cmd.ExecuteReader();
                while (nome_produto.Read())
                {
                    nome_prod = nome_produto.GetString(0);
                }
                //desconectar
                conexao.desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o banco!");
            }
            return nome_prod;
        }
        public double buscarprecoprod()
        {
            try
            {
                id_produto = int.Parse(tb_cod.Text);
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select preco_produto from produto where id_produto = @id_produto";
                cmd.Parameters.AddWithValue("@id_produto", id_produto);
                cmd.Connection = conexao.conectar();
                SqlDataReader produto = cmd.ExecuteReader();
                while (produto.Read())
                {
                    valor_prod = produto.GetDouble(0);
                }
                //desconectar
                conexao.desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o banco!");
            }
            return valor_prod;
        }
        public void carregarcombobox()
        {
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select id_fornecedor, nome_fornecedor from fornecedor";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.conectar();
                SqlDataReader fornecedor = cmd.ExecuteReader();
                cb_forn.Items.Clear();
                while (fornecedor.Read())
                {
                    cb_forn.Items.Add(fornecedor.GetInt32(0) + "-" + fornecedor.GetString(1));
                }
                conexao.desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }

        private void Entrada_Prod_Load(object sender, EventArgs e)
        {
            carregarcombobox();
            carregarlv();
            cal_fab.MaxDate = DateTime.Today;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nome_prod = "-";
            lbl_nomeprod.Text = nome_prod;
            if (tb_cod.Text == string.Empty)
            {
                nome_prod = "-";
                lbl_nomeprod.Text = nome_prod;
            }
            else {
                nome_prod = buscarnomeprod();
                lbl_nomeprod.Text = nome_prod;
            }
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
            if (id_estoque == -1)
            {
                button1.Text = "Cadastrar";
                lbl_qtd.Text = "Quantidade";
            }
            else
            {
                button1.Text = "Adicionar/Editar";
                lbl_qtd.Text = "Add Quantidade";
            }
        }
        public void limpar()
        {
            id_produto = -1;
            id_estoque = -1;
            qtd_atual = 0;
            nome_prod = "-";
            lbl_nomeprod.Text = nome_prod;
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
            carregarlv();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lv_estoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_qtde_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_cod_KeyPress(object sender, KeyPressEventArgs e)
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
            id_produto = int.Parse(lv_estoque.SelectedItems[0].SubItems[1].Text);
            qtd_atual = int.Parse(lv_estoque.SelectedItems[0].SubItems[7].Text);
            tb_cod.Text = lv_estoque.SelectedItems[0].SubItems[1].Text;
            lbl_nomeprod.Text = lv_estoque.SelectedItems[0].SubItems[2].Text;
            cb_forn.Text = lv_estoque.SelectedItems[0].SubItems[3].Text + "-" + lv_estoque.SelectedItems[0].SubItems[4].Text;
            tb_lote.Text = lv_estoque.SelectedItems[0].SubItems[5].Text;
            aaa.Text = "0";
            cal_fab.SetDate(DateTime.Parse(lv_estoque.SelectedItems[0].SubItems[6].Text));
            if (id_estoque == -1)
            {
                button1.Text = "Cadastrar";
                lbl_qtd.Text = "Quantidade";
            }
            else
            {
                button1.Text = "Adicionar/Editar";
                lbl_qtd.Text = "Add Quantidade";
            }
        }

        private void tb_cod_TextChanged(object sender, EventArgs e)
        {
            nome_prod = "-";
            lbl_nomeprod.Text = nome_prod;
            if (tb_cod.Text == string.Empty)
            {
                nome_prod = "-";
                lbl_nomeprod.Text = nome_prod;
            }
            else
            {
                nome_prod = buscarnomeprod();
                lbl_nomeprod.Text = nome_prod;
            }
        }

        private void aaa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
