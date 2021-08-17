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
    
    public partial class AdicionarEditar_CategoriaMarca : Form
    {
        public int codigo_marca = -1;
        public int codigo_categoria = -1;
        public AdicionarEditar_CategoriaMarca()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void carregarlv()
        {
            //atributos lv da marca
            lv_marca.AllowColumnReorder = true;
            lv_marca.FullRowSelect = true;
            //atribusto lv da categoria
            lv_categoria.AllowColumnReorder = true;
            lv_categoria.FullRowSelect = true;
            try
            {
                Conexao conexao = new Conexao();
                // comandos marca 
                SqlCommand cmd = new SqlCommand(); 
                cmd.CommandText = "select * from marca";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.conectar();
                //comandos categoria
                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandText = "select * from categoria";
                cmd2.CommandType = CommandType.Text;
                //leitura das litas
                SqlDataReader marca = cmd.ExecuteReader();
                //preenchimento da lv marca
                lv_marca.Items.Clear();
                while (marca.Read())
                {
                    var lista = new ListViewItem(marca.GetInt32(0).ToString());
                    lista.SubItems.Add(marca.GetString(1));
                    lv_marca.Items.Add(lista);
                }
                conexao.desconectar();
                cmd2.Connection = conexao.conectar();
                //preenchimento da lv categoria
                SqlDataReader categoria = cmd2.ExecuteReader();
                lv_categoria.Items.Clear();
                while (categoria.Read())
                {
                    var lista = new ListViewItem(categoria.GetInt32(0).ToString());
                    lista.SubItems.Add(categoria.GetString(1));
                    lv_categoria.Items.Add(lista);
                }
                conexao.desconectar();
                //definição botão cadastrar/editar
                if (codigo_marca != -1 || codigo_categoria != -1)
                {
                    if (codigo_marca>-1)
                    {
                        button1.Text = "Editar marca";
                    }
                    else
                    {
                        button1.Text = "Editar categoria";
                    }
                    
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (nome_item.Text != string.Empty)
            {
                if (codigo_marca == -1 && codigo_categoria == -1)
                {
                    if (radio_marca.Checked)
                    {
                        Cadastro_Marca cad = new Cadastro_Marca();
                        cad.cadastro_Marca(nome_item.Text);
                        MessageBox.Show(cad.mensagem);
                        carregarlv();
                        limpar();
                    }
                    else if (radio_categoria.Checked)
                    {
                        Cadastro_Categoria cad = new Cadastro_Categoria();
                        cad.cadastro_Categoria(nome_item.Text);
                        MessageBox.Show(cad.mensagem);
                        limpar();
                    }
                    else
                    {
                        MessageBox.Show("Favor selecionar uma opção para cadastro!");
                    }
                }
                else if (codigo_categoria > -1)
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja mesmo editar essa categoria?", "ALERTA", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Cadastro_Categoria editar = new Cadastro_Categoria();
                        editar.editar_categoria(codigo_categoria, nome_item.Text);
                        MessageBox.Show(editar.mensagem);
                        limpar();
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja mesmo editar essa marca?", "ALERTA", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Cadastro_Marca editar = new Cadastro_Marca();
                        editar.editar_marca(codigo_marca, nome_item.Text);
                        MessageBox.Show(editar.mensagem);
                        limpar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Favor selecionar uma marca ou categoria para editar ou preencha o formulário para cadastrar!");
            }
            carregarlv();
            
            
        }

        private void lv_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AdicionarEditar_CategoriaMarca_Load(object sender, EventArgs e)
        {
            carregarlv();
        }
        public void limpar()
        {
            foreach (Control c in this.Controls)
            {

                if (c is TextBox)

                    ((TextBox)c).Text = string.Empty;
                else if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
                if (c is MaskedTextBox)
                    ((MaskedTextBox)c).Text = string.Empty;
                codigo_marca = -1;
                codigo_categoria = -1;
                carregarlv();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (codigo_marca>-1)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja mesmo apagar essa marca?", "ALERTA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Cadastro_Marca excluir = new Cadastro_Marca();
                    excluir.excluir_marca(codigo_marca);
                    MessageBox.Show(excluir.mensagem);
                }
            }
            else if (codigo_categoria > -1)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja mesmo apagar essa categoria?", "ALERTA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Cadastro_Categoria excluir = new Cadastro_Categoria();
                    excluir.excluir_categoria(codigo_categoria);
                    MessageBox.Show(excluir.mensagem);
                }
            }
            else
            {
                MessageBox.Show("Favor selecionar uma Marca ou Categoria para deletar!");
            }
            
            carregarlv();
            limpar();
        }

        private void lv_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lv_marca_MouseClick(object sender, MouseEventArgs e)
        {
            codigo_marca = int.Parse(lv_marca.SelectedItems[0].SubItems[0].Text);
            nome_item.Text = lv_marca.SelectedItems[0].SubItems[1].Text;
            radio_marca.Checked = true;
            if (codigo_marca != -1 || codigo_categoria != -1)
            {
                if (codigo_marca > -1)
                {
                    button1.Text = "Editar marca";
                }
                else
                {
                    button1.Text = "Editar categoria";
                }

            }
            else
            {
                button1.Text = "Cadastrar";
            }
        }

        private void lv_categoria_MouseClick(object sender, MouseEventArgs e)
        {
            codigo_categoria = int.Parse(lv_categoria.SelectedItems[0].SubItems[0].Text);
            nome_item.Text = lv_categoria.SelectedItems[0].SubItems[1].Text;
            radio_categoria.Checked = true;
            if (codigo_marca != -1 || codigo_categoria != -1)
            {
                if (codigo_marca > -1)
                {
                    button1.Text = "Editar categoria";
                }
                else
                {
                    button1.Text = "Editar marca";
                }

            }
            else
            {
                button1.Text = "Cadastrar";
            }
        }
    }
}
