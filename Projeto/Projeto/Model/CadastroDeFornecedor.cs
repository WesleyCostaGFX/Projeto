using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class CadastroDeFornecedor
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;
        public CadastroDeFornecedor(string nome_fornecedor, string cidade_fornecedor, string endereco_fornecedor, string email_fornecedor, string telefone_fornecedor, string cnpj_fornecedor)
        {
            cmd.CommandText = "insert into fornecedor (nome_fornecedor, cidade_fornecedor, endereco_fornecedor, email_fornecedor, telefone_fornecedor, cnpj_fornecedor) " +
                "values(@nome_fornecedor, @cidade_fornecedor, @endereco_fornecedor, @email_fornecedor, @telefone_fornecedor, @cnpj_fornecedor)";
            cmd.Parameters.AddWithValue("@nome_fornecedor", nome_fornecedor);
            cmd.Parameters.AddWithValue("@cidade_fornecedor", cidade_fornecedor);
            cmd.Parameters.AddWithValue("@endereco_fornecedor", endereco_fornecedor);
            cmd.Parameters.AddWithValue("@email_fornecedor", email_fornecedor);
            cmd.Parameters.AddWithValue("@telefone_fornecedor", telefone_fornecedor);
            cmd.Parameters.AddWithValue("@cnpj_fornecedor", cnpj_fornecedor);
            try
            {
                //conexão
                cmd.Connection = conexao.conectar();
                //execytar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                this.mensagem = "Cadastrado com sucesso";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados";
            }
        }

    }
}
