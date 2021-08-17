using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class Cadastro_estoque
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;
        public void cadastro_estoque(int id_produto, string nome_produto, int id_fornecedor, string nome_fornecedor, string lote_produto, DateTime data_fabricacao, int quantidade, double valor_produto)
        {
            cmd.CommandText = "insert into estoque (id_produto, nome_produto, id_fornecedor, nome_fornecedor, lote_produto, data_fabricacao, quantidade, valor_produto) " +
                              "values(@id_produto, @nome_produto, @id_fornecedor, @nome_fornecedor, @lote_produto, @data_fabricacao, @quantidade, @valor_produto)";
            cmd.Parameters.AddWithValue("@id_produto", id_produto);
            cmd.Parameters.AddWithValue("@nome_produto", nome_produto);
            cmd.Parameters.AddWithValue("@id_fornecedor", id_fornecedor);
            cmd.Parameters.AddWithValue("@nome_fornecedor", nome_fornecedor);
            cmd.Parameters.AddWithValue("@lote_produto", lote_produto);
            cmd.Parameters.AddWithValue("@data_fabricacao", data_fabricacao);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@valor_produto", valor_produto);
            try
            {
                //conexão
                cmd.Connection = conexao.conectar();
                //execytar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                this.mensagem = "Lote adicionado com sucesso!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados";
            }
        }
        public void editar_estoque(int id_estoque, int id_produto, string nome_produto, int id_fornecedor, string nome_fornecedor, string lote_produto, DateTime data_fabricacao, int quantidade, double valor_produto)
        {
            cmd.CommandText = "update estoque set id_produto = @id_produto, nome_produto = @nome_produto, id_fornecedor = @id_fornecedor, " +
                              "nome_fornecedor = @nome_fornecedor, lote_produto = @lote_produto, data_fabricacao = @data_fabricacao, " +
                              "quantidade = @quantidade, valor_produto = @valor_produto where id_estoque = @id_estoque";
            cmd.Parameters.AddWithValue("@id_produto", id_produto);
            cmd.Parameters.AddWithValue("@nome_produto", nome_produto);
            cmd.Parameters.AddWithValue("@id_fornecedor", id_fornecedor);
            cmd.Parameters.AddWithValue("@nome_fornecedor", nome_fornecedor);
            cmd.Parameters.AddWithValue("@lote_produto", lote_produto);
            cmd.Parameters.AddWithValue("@data_fabricacao", data_fabricacao);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@valor_produto", valor_produto);
            cmd.Parameters.AddWithValue("@id_estoque", id_estoque);
            try
            {
                //conexão
                cmd.Connection = conexao.conectar();
                //execytar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                if (quantidade == 0)
                {
                    this.mensagem = "Lote editado com sucesso!";
                }
                else
                {
                    this.mensagem = "Quantidade adicionada com sucesso!";
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados";
            }
        }
    }
}
