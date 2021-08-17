using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public string mensagem = "";
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string funcao;
        public string nome_usuario;
        public int id_usuario;
        public bool verificarlogin(string login, string senha)
        {
            cmd.CommandText = "select * from usuario where email_usuario = @login and senha_usuario = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = conexao.conectar();
                //execytar comando
                SqlDataReader dr = cmd.ExecuteReader();
                //desconectar
                if(dr.HasRows)
                {
                    tem = true;
                    while (dr.Read())
                    {
                        funcao = dr.GetString(5);
                        nome_usuario = dr.GetString(1);
                        id_usuario = dr.GetInt32(0);
                    }
                }
            }
            catch (SqlException)
            {
                mensagem = "Erro com banco de dados!";
            }
            return tem;
        }
    }
}
