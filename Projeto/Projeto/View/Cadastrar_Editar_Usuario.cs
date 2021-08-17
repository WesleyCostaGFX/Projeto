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
    public partial class Editar_Usuario : Form
    {
        public int codigo = -1;
        public Editar_Usuario()
        {
            InitializeComponent();
        }

        private void Editar_Usuario_Load(object sender, EventArgs e)
        {
            limpar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();
                //Comando SQL --SqlCommand
                SqlCommand cmd = new SqlCommand();
                //conexão
                cmd.Connection = conexao.conectar();
                //execytar comando
                cmd.CommandText = "delete from usuario where id_usuario = @id_usuario";
                //Parâmetros
                cmd.Parameters.AddWithValue("@id_usuario", codigo);
                if (codigo > -1)
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja mesmo apagar esse usuario?", "ALERTA", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deletado com Sucesso!");
                    }
                }
                else
                {
                    MessageBox.Show("Selecionar um usuario da lista para deletar!");
                }
                //desconectar
                conexao.desconectar();
                limpar();

            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao deletar!");
            }
            limpar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cpf_usuario.TextMaskFormat = MaskFormat.IncludePrompt;
            bool cpfval = ValidateCpf(cpf_usuario.Text);
            cpf_usuario.TextMaskFormat = MaskFormat.IncludeLiterals;
            if (cpfval == true)
            {
                if (nome_usuario.Text != string.Empty && cpf_usuario.Text != string.Empty && email_usuario.Text != string.Empty && senha_usuario.Text != string.Empty && funcao_usuario.Text != string.Empty)
                {
                    if (codigo > -1)
                    {
                        DialogResult dialogResult = MessageBox.Show("Deseja mesmo editar esse usuario?", "ALERTA", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            EditarUsuario editar = new EditarUsuario(codigo, nome_usuario.Text, cpf_usuario.Text, senha_usuario.Text, funcao_usuario.Text, email_usuario.Text);
                            MessageBox.Show(editar.mensagem);
                        }
                    }
                    else
                    {
                        CadastroDeUsuario cad_us = new CadastroDeUsuario(nome_usuario.Text, cpf_usuario.Text, senha_usuario.Text, funcao_usuario.Text, email_usuario.Text);
                        MessageBox.Show(cad_us.mensagem);
                    }

                    limpar();
                }
                else
                {
                    MessageBox.Show("Selecione um usuário para editar ou preencha todos os campos para realizar um cadastro!");
                }
            }
            else
            {
                MessageBox.Show("CPF INVÁLIDO!");
            }
        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void nome_usuario_TextChanged(object sender, EventArgs e)
        {

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
                if (c is ComboBox)
                    ((ComboBox)c).Text = "Vendedor";
                codigo = -1;
            }
            carregarlistview();
        }
        public void carregarlistview()
        {
            lv_usuario.AllowColumnReorder = true;
            lv_usuario.FullRowSelect = true;
            try
            {
                Conexao conexao = new Conexao();
                //Comando SQL --SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from usuario";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.conectar();
                SqlDataReader usuario = cmd.ExecuteReader();
                lv_usuario.Items.Clear();
                while (usuario.Read())
                {
                    var lista = new ListViewItem(usuario.GetInt32(0).ToString());
                    lista.SubItems.Add(usuario.GetString(1));
                    lista.SubItems.Add(usuario.GetString(2));
                    lista.SubItems.Add(usuario.GetString(3));
                    lista.SubItems.Add(usuario.GetString(4));
                    lista.SubItems.Add(usuario.GetString(5));
                    lv_usuario.Items.Add(lista);
                }


                conexao.desconectar();

            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
            if (codigo != -1)
            {
                button1.Text = "Editar";
            }
            else
            {
                button1.Text = "Cadastrar";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            limpar();
        }

        private void lv_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lv_usuario_MouseClick(object sender, MouseEventArgs e)
        {
            codigo = int.Parse(lv_usuario.SelectedItems[0].SubItems[0].Text);
            nome_usuario.Text = lv_usuario.SelectedItems[0].SubItems[1].Text;
            cpf_usuario.Text = lv_usuario.SelectedItems[0].SubItems[2].Text;
            email_usuario.Text = lv_usuario.SelectedItems[0].SubItems[3].Text;
            senha_usuario.Text = lv_usuario.SelectedItems[0].SubItems[4].Text;
            funcao_usuario.Text = lv_usuario.SelectedItems[0].SubItems[5].Text;
            if (codigo != -1)
            {
                button1.Text = "Editar";
            }
            else
            {
                button1.Text = "Cadastrar";
            }
        }
        public static bool ValidateCpf(string cpf)
        {
            if (cpf.Length != 11 || cpf == "11111111111")
                return false;
            else
            {
                int soma = 0;
                for (int i = 0; i < 9; i++)
                {
                    soma += (Convert.ToInt32(cpf[i]) - 48) * (10 - i);
                }
                int digito = (11 - (soma % 11)) > 9 ? 0 : 11 - (soma % 11);

                if (digito == Convert.ToInt32(cpf[9] - 48))
                {
                    soma = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        soma += (Convert.ToInt32(cpf[i]) - 48) * (11 - i);
                    }
                    digito = (11 - (soma % 11)) > 9 ? 0 : 11 - (soma % 11);

                    if (digito == Convert.ToInt32(cpf[10] - 48))
                        return true;
                }
            }
            return false;
        }
    }
}
