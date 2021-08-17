using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    class EditarFornecedores
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;
        public EditarFornecedores(int id_fornecedor, string nome_fornecedor, string cidade_fornecedor, string endereco_fornecedor, string email_fornecedor, string telefone_fornecedor, string cnpj_fornecedor)
        {
            //Comando SQL --SqlCommand
            cmd.CommandText = "update fornecedor set nome_fornecedor = @nome_fornecedor, " +
                              "cidade_fornecedor = @cidade_fornecedor, " +
                              "endereco_fornecedor = @endereco_fornecedor, " +
                              "email_fornecedor = @email_fornecedor, " +
                              "telefone_fornecedor = @telefone_fornecedor, " +
                              "cnpj_fornecedor = @cnpj_fornecedor " +
                              "where id_fornecedor = @id_fornecedor";

            cmd.Parameters.AddWithValue("@id_fornecedor", id_fornecedor);
            cmd.Parameters.AddWithValue("@nome_fornecedor", nome_fornecedor);
            cmd.Parameters.AddWithValue("@cidade_fornecedor", cidade_fornecedor);
            cmd.Parameters.AddWithValue("@endereco_fornecedor", endereco_fornecedor);
            cmd.Parameters.AddWithValue("@email_fornecedor", email_fornecedor);
            cmd.Parameters.AddWithValue("@telefone_fornecedor", telefone_fornecedor);
            cmd.Parameters.AddWithValue("@cnpj_fornecedor", cnpj_fornecedor);

            //Conectar com o banco de dados
            try
            {
                //conexão
                cmd.Connection = conexao.conectar();
                //execytar comando
                DialogResult dialogResult = MessageBox.Show("Deseja mesmo editar esse fornecedor?", "ALERTA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Editado com Sucesso!");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
                
                //desconectar
                conexao.desconectar();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados";
            }

        }
    }
}
