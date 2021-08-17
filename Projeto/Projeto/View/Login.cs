using Projeto.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Login : Form
    {
        public string funcao;
        public string nome_usuario;
        public int id_usuario;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controle controle = new controle();
            controle.acessar(login_usuario.Text, senha_usuario.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.funcao = controle.funcao;
                    this.nome_usuario = controle.nome_usuario;
                    this.id_usuario = controle.id_usuario;
                    Menu menu = new Menu(funcao, id_usuario, nome_usuario);
                    this.Hide();
                    menu.ShowDialog();
                    login_usuario.Text = string.Empty;
                    senha_usuario.Text = string.Empty;
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Login não encontrado! Verifique login e senha!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
