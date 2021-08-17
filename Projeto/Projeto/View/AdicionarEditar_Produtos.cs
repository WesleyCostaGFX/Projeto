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
    public partial class AdicionarEditar_Produtos : Form
    {
        public int codigo = -1;
        public AdicionarEditar_Produtos()
        {
            InitializeComponent();
        }
        private void AdicionarEditar_Produtos_Load(object sender, EventArgs e)
        {
            add_combobox();
            carregar_lv();
        }
        public void limpar()
        {
            foreach (Control c in this.Controls)
            {

                if (c is TextBox)

                    ((TextBox)c).Text = string.Empty;
                if (c is CheckBox)
                    ((CheckBox)c).Checked = false;
                if (c is MaskedTextBox)
                    ((MaskedTextBox)c).Text = string.Empty;
                cb_categoria.Text = "";
                cb_marca.Text = "";
                codigo = -1;
            }
        }
        
        public void add_combobox()
        {
            // combo box - marca
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from marca";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.conectar();
                SqlDataReader marca = cmd.ExecuteReader();
                cb_marca.Items.Clear();
                while (marca.Read())
                {
                    cb_marca.Items.Add(marca.GetInt32(0) + "-" + marca.GetString(1));
                }
                conexao.desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
            // combo box - categoria
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from categoria";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.conectar();
                SqlDataReader categoria = cmd.ExecuteReader();
                cb_categoria.Items.Clear();
                while (categoria.Read())
                {
                    cb_categoria.Items.Add(categoria.GetInt32(0) + "-" + categoria.GetString(1));
                }
                conexao.desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nome_produto.Text != string.Empty &&  valor_produto.Text != string.Empty &&
                cb_marca.Text != string.Empty &&  cb_categoria.Text != string.Empty){
                string[] marca_dados = cb_marca.Text.Split('-');
                string[] categoria_dados = cb_categoria.Text.Split('-');
                if (codigo == -1)
                {

                    Cadastro_Produto cad = new Cadastro_Produto();
                    cad.cadastro_produto(nome_produto.Text, float.Parse(valor_produto.Text), int.Parse(marca_dados[0]),
                                         marca_dados[1], int.Parse(categoria_dados[0]), categoria_dados[1]);
                    carregar_lv();
                    MessageBox.Show(cad.mensagem);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja mesmo editar esse produto?", "ALERTA", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Cadastro_Produto editar = new Cadastro_Produto();
                        editar.editar_produto(codigo, nome_produto.Text, float.Parse(valor_produto.Text), int.Parse(marca_dados[0]),
                                             marca_dados[1], int.Parse(categoria_dados[0]), categoria_dados[1]);
                        carregar_lv();
                        MessageBox.Show(editar.mensagem);
                    }
                }
                limpar();
            }
            else
            {
                MessageBox.Show("Favor selecionar um item para editar ou preencher todos os campos para realizar um cadastro!");
            }
            carregar_lv();
        }

        private void cb_forn_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void carregar_lv()
        {
            lv_produto.LabelEdit = false;
            lv_produto.AllowColumnReorder = true;
            lv_produto.FullRowSelect = true;
            try
            {
                Conexao conexao = new Conexao();
                //Comando SQL --SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from produto";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.conectar();
                SqlDataReader produto = cmd.ExecuteReader();
                lv_produto.Items.Clear();
                while (produto.Read())
                {
                    var lista = new ListViewItem(produto.GetInt32(0).ToString());
                    lista.SubItems.Add(produto.GetString(1));
                    lista.SubItems.Add(produto.GetDouble(2).ToString("F2"));
                    lista.SubItems.Add(produto.GetString(4));
                    lista.SubItems.Add(produto.GetString(6));
                    lv_produto.Items.Add(lista);
                }
                conexao.desconectar();
                if (codigo != -1)
                {
                    button1.Text = "Editar";
                }
                else
                {
                    button1.Text = "Cadastrar";
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }

        private void lv_produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public string retornarmarca()
        {
            string nome_marca = "0";
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select id_marca, nome_marca from produto where id_produto = @id_produto";
                cmd.Parameters.AddWithValue("@id_produto", codigo);
                cmd.Connection = conexao.conectar();
                SqlDataReader marca = cmd.ExecuteReader();
                while (marca.Read())
                {
                    ;
                    nome_marca = marca.GetInt32(0).ToString() + "-" + marca.GetString(1);

                }

                //desconectar
                conexao.desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o banco!");
            }
            return nome_marca;
        }
        public string retornarcategoria()
        {

            string nome_categoria = "0";
            try
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select id_categoria, nome_categoria from produto where id_produto = @id_produto";
                cmd.Parameters.AddWithValue("@id_produto", codigo);
                cmd.Connection = conexao.conectar();
                SqlDataReader categoria = cmd.ExecuteReader();
                while (categoria.Read())
                {
                    ;
                    nome_categoria = categoria.GetInt32(0).ToString() + "-" + categoria.GetString(1);

                }

                //desconectar
                conexao.desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o banco!");
            }
            return nome_categoria;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (codigo != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja mesmo apagar esse produto?", "ALERTA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Cadastro_Produto excluir = new Cadastro_Produto();
                    excluir.apagar_produto(codigo);
                    MessageBox.Show(excluir.mensagem);
                    carregar_lv();
                    limpar();
                }
            }
            else
            {
                MessageBox.Show("Selecionar um item na tabela para deletar!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpar();
            carregar_lv();
        }

        private void valor_produto_TextChanged(object sender, EventArgs e)
        {
            moeda(ref valor_produto);
        }
        public void moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            n = txt.Text.Replace(",", "");
            if (n.Equals(string.Empty))
            {
                n = string.Empty;
            }
            n = n.PadLeft(3, '0');
            if (n.Length > 3 & n.Substring(0,1)=="0")
            {
                n = n.Substring(1, n.Length - 1);
                
            }
            v = Convert.ToDouble(n)/100;
            txt.Text = string.Format("{0:N}", v);
            txt.SelectionStart = txt.Text.Length;
        }

        private void lv_produto_MouseClick(object sender, MouseEventArgs e)
        {
            codigo = int.Parse(lv_produto.SelectedItems[0].SubItems[0].Text);
            nome_produto.Text = lv_produto.SelectedItems[0].SubItems[1].Text;
            valor_produto.Text = lv_produto.SelectedItems[0].SubItems[2].Text;
            cb_marca.Text = retornarmarca();
            cb_categoria.Text = retornarcategoria();
            if (codigo != -1)
            {
                button1.Text = "Editar";
            }
            else
            {
                button1.Text = "Cadastrar";
            }
        }

        private void valor_produto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
