using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.View
{
    public partial class Menu : Form
    {
        public string funcao;
        public int id_usuario;
        public string nome_usuario;
        public Menu()
        {
            InitializeComponent();
        }
        public Menu(string funcao_usuario, int id, string nome)
        {
            funcao = funcao_usuario;
            id_usuario = id;
            nome_usuario = nome;
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Administrador") || funcao.Equals("Caixa"))
            {
                this.Hide();
                Cadastrar_Editar_Fornecedor editar_Fornecedores = new Cadastrar_Editar_Fornecedor();
                editar_Fornecedores.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para essa função!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Administrador"))
            {
                this.Hide();
                Editar_Usuario editar_Usuario = new Editar_Usuario();
                editar_Usuario.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para essa função!");
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Administrador")|| funcao.Equals("Caixa"))
            {
                this.Hide();
                AdicionarEditar_Produtos adicionarEditar_Produtos = new AdicionarEditar_Produtos();
                adicionarEditar_Produtos.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para essa função!");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (funcao.Equals("Administrador") || funcao.Equals("Caixa"))
            {
                this.Hide();
                AdicionarEditar_CategoriaMarca adicionarEditar_CategoriaMarca = new AdicionarEditar_CategoriaMarca();
                adicionarEditar_CategoriaMarca.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para essa função!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Administrador") || funcao.Equals("Caixa"))
            {
                this.Hide();
                Entrada_Prod entrada_Prod = new Entrada_Prod();
                entrada_Prod.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para essa função!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Administrador") || funcao.Equals("Caixa"))
            {
                this.Hide();
                Caixa caixa = new Caixa(id_usuario, nome_usuario);
                caixa.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para essa função!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (funcao.Equals("Administrador") || funcao.Equals("Caixa"))
            {
                this.Hide();
                Saida_Prod baixa = new Saida_Prod();
                baixa.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para essa função!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisualizarEstoque vizuestoq = new VisualizarEstoque();
            vizuestoq.ShowDialog();
            this.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}