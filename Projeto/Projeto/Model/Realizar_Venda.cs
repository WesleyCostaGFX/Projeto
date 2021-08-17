using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class Realizar_Venda
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;
        public void realizar_venda(int id_usuario, string nome_usuario, float valor_total)
        {
            cmd.CommandText = "insert into venda (id_usuario, nome_usuario, data_venda, valor_total) " +
                              "values(@id_usuario, @nome_usuario, @data_venda, @valor_total)";
            cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
            cmd.Parameters.AddWithValue("@nome_usuario", nome_usuario);
            cmd.Parameters.AddWithValue("@data_venda", DateTime.Today.Date);
            cmd.Parameters.AddWithValue("@valor_total", valor_total);
            try
            {
                //conexão
                cmd.Connection = conexao.conectar();
                //execytar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                this.mensagem = "Venda finalizada com sucesso!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados";
            }
        }
        public void preencher_itens_venda(int id_venda, int id_produto, string nome_produto, string lote_produto, int quantidade_produto, float valortotal_produto)
        {
            cmd.CommandText = "insert into itens_venda (id_venda, id_produto, nome_produto, lote_produto, quantidade_produto, valortotal_produto) " +
                              "values(@id_venda, @id_produto, @nome_produto, @lote_produto, @quantidade_produto, @valortotal_produto)";
            cmd.Parameters.AddWithValue("@id_venda", id_venda);
            cmd.Parameters.AddWithValue("@id_produto", id_produto);
            cmd.Parameters.AddWithValue("@nome_produto", nome_produto);
            cmd.Parameters.AddWithValue("@lote_produto", lote_produto);
            cmd.Parameters.AddWithValue("@quantidade_produto", quantidade_produto);
            cmd.Parameters.AddWithValue("@valortotal_produto", valortotal_produto);
            try
            {
                //conexão
                cmd.Connection = conexao.conectar();
                //execytar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                this.mensagem = "Venda realizada com sucesso!\nSeguir com o recebimento do pagamento!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados";
            }
        }
        public void baixaritens_venda(int quantidade, string lote)
        {

            int id_estoque = -1, quantidade_atual = 0;
            //pegar id_estoque e quantidade_estoque
            try
            {
                Conexao conexao = new Conexao();
                //Comando SQL --SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select id_estoque, quantidade from estoque where lote_produto = @lote_produto";
                cmd.Parameters.AddWithValue("@lote_produto", lote);
                cmd.Connection = conexao.conectar();
                SqlDataReader estoque = cmd.ExecuteReader();
                while (estoque.Read())
                {
                    id_estoque = estoque.GetInt32(0);
                    quantidade_atual = estoque.GetInt32(1);
                }

                conexao.desconectar();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados";
            }
            int nova_quantidade = quantidade_atual - quantidade;
            if (nova_quantidade > 0)
            {
                //Dar baixa no estoque do id_venda selecionado
                try
                {
                    Conexao conexao = new Conexao();
                    //Comando SQL --SqlCommand
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "update estoque set quantidade = @nova_quantidade where id_estoque = @id_estoque";
                    cmd.Parameters.AddWithValue("@nova_quantidade", nova_quantidade);
                    cmd.Parameters.AddWithValue("@id_estoque", id_estoque);
                    cmd.Connection = conexao.conectar();
                    cmd.ExecuteNonQuery();
                    conexao.desconectar();
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro ao se conectar com o banco de dados";
                }
            }
            else
            {
                try
                {
                    Conexao conexao = new Conexao();
                    //Comando SQL --SqlCommand
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "delete from estoque where id_estoque = @id_Estoque";
                    cmd.Parameters.AddWithValue("@id_estoque", id_estoque);
                    cmd.Connection = conexao.conectar();
                    cmd.ExecuteNonQuery();
                    conexao.desconectar();
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro ao se conectar com o banco de dados";
                }
            }
        }
    }
}
