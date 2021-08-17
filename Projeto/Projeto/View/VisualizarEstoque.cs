using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.View
{
    public partial class VisualizarEstoque : Form
    {
        public VisualizarEstoque()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        private void carregarlv_item()
        {
            lv_estoque.LabelEdit = false;
            lv_estoque.AllowColumnReorder = true;
            lv_estoque.FullRowSelect = true;
            try
            {
                Conexao conexao = new Conexao();
                //Comando SQL --SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from estoque where id_produto = @id_produto";
                cmd.Parameters.AddWithValue("@id_produto", tb_codigo.Text);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.conectar();
                SqlDataReader estoque = cmd.ExecuteReader();
                lv_estoque.Items.Clear();
                while (estoque.Read())
                {
                    var lista = new ListViewItem(estoque.GetInt32(0).ToString());
                    lista.SubItems.Add(estoque.GetInt32(1).ToString());
                    lista.SubItems.Add(estoque.GetString(2));
                    lista.SubItems.Add(estoque.GetInt32(3).ToString());
                    lista.SubItems.Add(estoque.GetString(4));
                    lista.SubItems.Add(estoque.GetString(5));
                    lista.SubItems.Add(estoque.GetDateTime(6).ToString("dd/MM/yyyy"));
                    lista.SubItems.Add(estoque.GetInt32(7).ToString());
                    lv_estoque.Items.Add(lista);
                }
                conexao.desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }
        private void carregarlv_total()
        {
            lv_estoque.LabelEdit = false;
            lv_estoque.AllowColumnReorder = true;
            lv_estoque.FullRowSelect = true;
            try
            {
                Conexao conexao = new Conexao();
                //Comando SQL --SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from estoque";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.conectar();
                SqlDataReader estoque = cmd.ExecuteReader();
                lv_estoque.Items.Clear();
                while (estoque.Read())
                {
                    var lista = new ListViewItem(estoque.GetInt32(0).ToString());
                    lista.SubItems.Add(estoque.GetInt32(1).ToString());
                    lista.SubItems.Add(estoque.GetString(2));
                    lista.SubItems.Add(estoque.GetInt32(3).ToString());
                    lista.SubItems.Add(estoque.GetString(4));
                    lista.SubItems.Add(estoque.GetString(5));
                    lista.SubItems.Add(estoque.GetDateTime(6).ToString("dd/MM/yyyy"));
                    lista.SubItems.Add(estoque.GetInt32(7).ToString());
                    lv_estoque.Items.Add(lista);
                }
                conexao.desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            carregarlv_total();
            tb_codigo.Text = string.Empty;
        }

        private void VisualizarEstoque_Load(object sender, EventArgs e)
        {
            carregarlv_total();
        }

        private void tb_codigo_TextChanged(object sender, EventArgs e)
        {
            if(tb_codigo.Text == string.Empty)
            {
                carregarlv_total();
            }
            else
            {
                carregarlv_item();
            }
        }

        private void tb_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
