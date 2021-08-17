using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class DeletarUsuario
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;
        public DeletarUsuario(int id_usuario)
        {
            //Comando SQL
            cmd.CommandText = "delete from usuario where id_usuario = @id_usuario";
            //Parâmetros
            cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
            try
            {
                //conexão
                cmd.Connection = conexao.conectar();
                //execytar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                this.mensagem = "Deletado com sucesso";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados";
            }
        }
    }
}
