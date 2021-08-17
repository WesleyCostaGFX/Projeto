using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class Cadastro_Categoria
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;
        public void cadastro_Categoria(string nome_categoria)
        {
            cmd.CommandText = "insert into categoria (nome_categoria) " +
                "values(@nome_categoria)";
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
        public void editar_categoria(int id_categoria, string nome_categoria)
        {
            cmd.CommandText = "update categoria set nome_categoria = @nome_categoria " +
                              "where id_categoria = @id_categoria";
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
        public void excluir_categoria(int id_categoria)
        {
            cmd.CommandText = "delete from categoria where id_categoria = @id_categoria";
            cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
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
