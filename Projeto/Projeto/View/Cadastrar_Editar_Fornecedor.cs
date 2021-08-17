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
    public partial class Cadastrar_Editar_Fornecedor : Form
    {
        public int codigo=-1;
        public Cadastrar_Editar_Fornecedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnpj_fornecedor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            bool valcnpj = IsCnpj(cnpj_fornecedor.Text);
            cnpj_fornecedor.TextMaskFormat = MaskFormat.IncludeLiterals;
            telefone_fornecedor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string telefone = telefone_fornecedor.Text;
            if (valcnpj==true){
                if (nome_fornecedor.Text == string.Empty || cidade_fornecedor.Text == string.Empty || endereco_fornecedor.Text == string.Empty || email_fornecedor.Text == string.Empty || telefone.Length != 11 || cnpj_fornecedor.Text == string.Empty)
                {
                    MessageBox.Show("Favor selecionar um fornecedor na lista para editar ou preencha todos os campos para cadastrar!");
                }
                else {
                    telefone_fornecedor.TextMaskFormat = MaskFormat.IncludeLiterals;
                    if (codigo > -1)
                    {
                        EditarFornecedores editar = new EditarFornecedores(codigo, nome_fornecedor.Text, cidade_fornecedor.Text, endereco_fornecedor.Text, email_fornecedor.Text, telefone_fornecedor.Text, cnpj_fornecedor.Text);
                        Limpar();
                    }
                    else
                    {
                        CadastroDeFornecedor cadforn = new CadastroDeFornecedor(nome_fornecedor.Text, cidade_fornecedor.Text, endereco_fornecedor.Text, email_fornecedor.Text, telefone_fornecedor.Text, cnpj_fornecedor.Text);
                        MessageBox.Show(cadforn.mensagem);
                        Limpar();
                    }
                }
            }
            else
            {
                MessageBox.Show("CNPJ Inválido!");
            }
            carregar_listview();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();
                //Comando SQL --SqlCommand
                SqlCommand cmd = new SqlCommand();
                //conexão
                cmd.Connection = conexao.conectar();
                //execytar comando
                cmd.CommandText = "delete from fornecedor where id_fornecedor = @id_fornecedor";
                //Parâmetros
                cmd.Parameters.AddWithValue("@id_fornecedor", codigo);
                if (codigo > -1)
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja mesmo apagar esse fornecedor?", "ALERTA", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deletado com Sucesso!");
                    }
                else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else
                {
                    MessageBox.Show("Selecionar um fornecedor da lista para deletar!");
                }
                //desconectar
                conexao.desconectar();
                carregar_listview();

            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao deletar!");
            }
            Limpar();
        }

        private void Editar_Fornecedores_Load(object sender, EventArgs e)
        {
            carregar_listview();
        }
        public void carregar_listview()
        {
            lv_fornecedor.LabelEdit = false;
            lv_fornecedor.AllowColumnReorder = true;
            lv_fornecedor.FullRowSelect = true;
            try
            {
                Conexao conexao = new Conexao();
                //Comando SQL --SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from fornecedor";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.conectar();
                SqlDataReader fornecedores = cmd.ExecuteReader();
                lv_fornecedor.Items.Clear();
                while (fornecedores.Read())
                {
                    var lista333 = new ListViewItem(fornecedores.GetInt32(0).ToString());
                    lista333.SubItems.Add(fornecedores.GetString(1));
                    lista333.SubItems.Add(fornecedores.GetString(2));
                    lista333.SubItems.Add(fornecedores.GetString(3));
                    lista333.SubItems.Add(fornecedores.GetString(4));
                    lista333.SubItems.Add(fornecedores.GetString(5));
                    lista333.SubItems.Add(fornecedores.GetString(6));
                    lv_fornecedor.Items.Add(lista333);
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
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Limpar()
        {
            foreach (Control c in this.Controls)
            {

                if (c is TextBox)

                    ((TextBox)c).Text = string.Empty;
                else if (c is CheckBox)

                    ((CheckBox)c).Checked = false;
                if (c is MaskedTextBox)
                    ((MaskedTextBox)c).Text = string.Empty;
                codigo = -1;
                carregar_listview();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void lv_fornecedor_MouseClick(object sender, MouseEventArgs e)
        {
            codigo = int.Parse(lv_fornecedor.SelectedItems[0].SubItems[0].Text);
            nome_fornecedor.Text = lv_fornecedor.SelectedItems[0].SubItems[1].Text;
            cidade_fornecedor.Text = lv_fornecedor.SelectedItems[0].SubItems[2].Text;
            endereco_fornecedor.Text = lv_fornecedor.SelectedItems[0].SubItems[3].Text;
            email_fornecedor.Text = lv_fornecedor.SelectedItems[0].SubItems[4].Text;
            telefone_fornecedor.Text = lv_fornecedor.SelectedItems[0].SubItems[5].Text;
            cnpj_fornecedor.Text = lv_fornecedor.SelectedItems[0].SubItems[6].Text;
            if (codigo != -1)
            {
                button1.Text = "Editar";
            }
            else
            {
                button1.Text = "Cadastrar";
            }
        }
        public static bool IsCnpj(string cnpj)
        {
            int[] digitos, soma, resultado;

            int nrDig;

            string ftmt;

            bool[] CNPJOk;



            ftmt = "6543298765432";

            digitos = new int[14];

            soma = new int[2];

            soma[0] = 0;

            soma[1] = 0;

            resultado = new int[2];

            resultado[0] = 0;

            resultado[1] = 0;

            CNPJOk = new bool[2];

            CNPJOk[0] = false;

            CNPJOk[1] = false;



            try

            {

                for (nrDig = 0; nrDig < 14; nrDig++)

                {

                    digitos[nrDig] = int.Parse(

                        cnpj.Substring(nrDig, 1));

                    if (nrDig <= 11)

                        soma[0] += (digitos[nrDig] *

                          int.Parse(ftmt.Substring(

                          nrDig + 1, 1)));

                    if (nrDig <= 12)

                        soma[1] += (digitos[nrDig] *

                          int.Parse(ftmt.Substring(

                          nrDig, 1)));

                }



                for (nrDig = 0; nrDig < 2; nrDig++)

                {

                    resultado[nrDig] = (soma[nrDig] % 11);

                    if ((resultado[nrDig] == 0) || (

                         resultado[nrDig] == 1))

                        CNPJOk[nrDig] = (

                        digitos[12 + nrDig] == 0);

                    else

                        CNPJOk[nrDig] = (

                        digitos[12 + nrDig] == (

                        11 - resultado[nrDig]));

                }

                return (CNPJOk[0] && CNPJOk[1]);

            }

            catch

            {
                return false;
            }

        }
    }
}
