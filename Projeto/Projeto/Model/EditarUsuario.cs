using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class EditarUsuario
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;
        public EditarUsuario(int id_usuario, string nome_usuario, string cpf_usuario, string senha_usuario, string funcao_usuario, string email_usuario)
        {
            //Comando SQL --SqlCommand
            cmd.CommandText = "update usuario set nome_usuario = @nome_usuario, " +
                              "cpf_usuario = @cpf_usuario, " +
                              "senha_usuario = @senha_usuario, " +
                              "funcao_usuario = @funcao_usuario, " +
                              "email_usuario = @email_usuario " +
                              "where id_usuario = @id_usuario";

            cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
            cmd.Parameters.AddWithValue("@nome_usuario", nome_usuario);
            cmd.Parameters.AddWithValue("@cpf_usuario", cpf_usuario);
            cmd.Parameters.AddWithValue("@senha_usuario", senha_usuario);
            cmd.Parameters.AddWithValue("@funcao_usuario", funcao_usuario);
            cmd.Parameters.AddWithValue("@email_usuario", email_usuario);

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
    }
}
