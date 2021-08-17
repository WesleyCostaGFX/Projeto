using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class Cadastro_Marca
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;
        public void cadastro_Marca(string nome_marca)
        {
            cmd.CommandText = "insert into marca (nome_marca) " +
                "values(@nome_marca)";
            cmd.Parameters.AddWithValue("@nome_marca", nome_marca);
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
        public void editar_marca(int id_marca, string nome_marca)
        {
            cmd.CommandText = "update marca set nome_marca = @nome_marca " +
                              "where id_marca = @id_marca";
            cmd.Parameters.AddWithValue("@id_marca", id_marca);
            cmd.Parameters.AddWithValue("@nome_marca", nome_marca);
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
        public void excluir_marca(int id_marca)
        {
            cmd.CommandText = "delete from marca where id_marca = @id_marca";
            cmd.Parameters.AddWithValue("@id_marca", id_marca);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                this.mensagem="Deletado com Sucesso!";
                conexao.desconectar();

            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao deletar!";
            }
        }
    }
}
