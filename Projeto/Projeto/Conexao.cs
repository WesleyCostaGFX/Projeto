using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-C7VO1M8\SQLEXPRESS;Initial Catalog=PDV_Wes;Integrated Security=True";
        }
        public SqlConnection conectar()
        {
            if (con.State== System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            return;
        }

    }
}
