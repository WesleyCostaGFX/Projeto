using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class Cadastro_Produto
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;
        public void cadastro_produto(string nome_produto, float valor_produto, int id_marca, string nome_marca
                                     , int id_categoria, string nome_categoria)
        {
            cmd.CommandText = "insert into produto (nome_produto, " +
                              "preco_produto, id_marca, nome_marca, " +
                              "id_categoria, nome_categoria) " +
                              "values(@nome_produto, @valor_produto," +
                              " @id_marca, @nome_marca, " +
                              "@id_categoria, @nome_categoria)";
            cmd.Parameters.AddWithValue("@nome_produto", nome_produto);
            cmd.Parameters.AddWithValue("@valor_produto", valor_produto);
            cmd.Parameters.AddWithValue("@id_marca", id_marca);
            cmd.Parameters.AddWithValue("@nome_marca", nome_marca);
            cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
            cmd.Parameters.AddWithValue("@nome_categoria", nome_categoria);
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
        public void editar_produto(int id_produto, string nome_produto, float valor_produto, int id_marca, string nome_marca,
                                   int id_categoria, string nome_categoria)
        {
            cmd.CommandText = "update produto set " +
                              "nome_produto = @nome_produto, " +
                              "preco_produto = @valor_produto, " +
                              "id_marca = @id_marca, " +
                              "nome_marca = @nome_marca, " +
                              "id_categoria = @id_categoria, " +
                              "nome_categoria = @nome_categoria " +
                              "where id_produto = @id_produto";
            cmd.Parameters.AddWithValue("@id_produto", id_produto);
            cmd.Parameters.AddWithValue("@nome_produto", nome_produto);
            cmd.Parameters.AddWithValue("@valor_produto", valor_produto);
            cmd.Parameters.AddWithValue("@id_marca", id_marca); 
            cmd.Parameters.AddWithValue("@nome_marca", nome_marca);
            cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
            cmd.Parameters.AddWithValue("@nome_categoria", nome_categoria);
            //Conectar com o banco de dados
            try
            {
                //conexão
                cmd.Connection = conexao.conectar();
                //execytar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                this.mensagem = "Editado com sucesso";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados";
            }
        }
        public void apagar_produto(int id_produto)
        {
            cmd.CommandText = "delete from produto where id_produto = @id_produto";
            cmd.Parameters.AddWithValue("@id_produto", id_produto);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                this.mensagem = "Deletado com Sucesso!";
                conexao.desconectar();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao deletar!";
            }
        }
    } 
}
