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

namespace Projeto
{

    public partial class Caixa : Form
    {
        public int id_usuario;
        public string nome_usuario;
        public int id_venda;
        public Caixa()
        {
            InitializeComponent();
        }
        public Caixa(int id, string nome)
        {
            id_usuario = id;
            nome_usuario = nome;
            InitializeComponent();
        }

        private void Caixa_Load(object sender, EventArgs e)
        {
            carregar_id_venda();
            carregarlvcomp();
        }
        public void carregarlvcomp()
        {
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
                    lista.SubItems.Add(estoque.GetString(5));
                    lista.SubItems.Add(estoque.GetDateTime(6).ToString("dd/MM/yyyy"));
                    lista.SubItems.Add(estoque.GetInt32(7).ToString());
                    lista.SubItems.Add(estoque.GetDouble(8).ToString("F2"));
                    lv_estoque.Items.Add(lista);
                }
                conexao.desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }
        public void carregarlv()
        {
            try
            {
                Conexao conexao = new Conexao();
                //Comando SQL --SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from estoque where id_produto = @id_produto";
                cmd.Parameters.AddWithValue("@id_produto", int.Parse(tb_codigo.Text));
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.conectar();
                SqlDataReader estoque = cmd.ExecuteReader();
                lv_estoque.Items.Clear();
                while (estoque.Read())
                {
                    var lista = new ListViewItem(estoque.GetInt32(0).ToString());
                    lista.SubItems.Add(estoque.GetInt32(1).ToString());
                    lista.SubItems.Add(estoque.GetString(2));
                    lista.SubItems.Add(estoque.GetString(5));
                    lista.SubItems.Add(estoque.GetDateTime(6).ToString("dd/MM/yyyy"));
                    lista.SubItems.Add(estoque.GetInt32(7).ToString());
                    lista.SubItems.Add(estoque.GetDouble(8).ToString("F2"));
                    lv_estoque.Items.Add(lista);
                }
                conexao.desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tb_codigo.Text == string.Empty)
            {
                MessageBox.Show("Favor inserir um código!");
            }
            else
            {
                carregarlv();
            }
        }
        private void lv_estoque_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ja_tem = false;
            for (int i = 0; i < lv_carrinho.Items.Count; i++)
            {
                if (lv_estoque.SelectedItems[0].SubItems[0].Text == lv_carrinho.Items[i].SubItems[0].Text)
                {
                    ja_tem = true;
                }
            }
            if (ja_tem == false)
            {

                if (tb_quantidade.Text != string.Empty && int.Parse(tb_quantidade.Text) > 0)
                {
                    if (int.Parse(tb_quantidade.Text) <= int.Parse(lv_estoque.SelectedItems[0].SubItems[5].Text))
                    {
                        var lista = new ListViewItem(lv_estoque.SelectedItems[0].SubItems[0].Text);
                        lista.SubItems.Add(lv_estoque.SelectedItems[0].SubItems[1].Text);
                        lista.SubItems.Add(lv_estoque.SelectedItems[0].SubItems[2].Text);
                        lista.SubItems.Add(lv_estoque.SelectedItems[0].SubItems[3].Text);
                        lista.SubItems.Add(tb_quantidade.Text);
                        lista.SubItems.Add(((float.Parse(tb_quantidade.Text) * float.Parse(lv_estoque.SelectedItems[0].SubItems[6].Text)).ToString("F2")));
                        lv_carrinho.Items.Add(lista);
                        limpar();
                    }
                    else
                    {
                        MessageBox.Show("Valor ultrapassa a quantidade em estoque.\n Verifique a quantidade!");
                    }
                }
                else
                {
                    MessageBox.Show("Favor inserir a quantidade!");
                }
            }
            else
            {
                MessageBox.Show("Item já adicionado no carrinho!\nRemover o item do carrinho e adicionar a quantidade desejada.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lv_carrinho.SelectedItems.Count > 0)
            {
                lv_carrinho.Items.Remove(lv_carrinho.SelectedItems[0]);
                carregarvalortotal();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lv_carrinho.Items.Clear();
            limpar();
        }
        public void limpar()
        {
            tb_codigo.Text = string.Empty;
            lb_nome.Text = "-";
            lb_valor.Text = "-";
            tb_quantidade.Text = string.Empty;
            carregarvalortotal();
            carregarlvcomp();
        }

        private void tb_codigo_TextChanged(object sender, EventArgs e)
        {
            if (tb_codigo.Text != string.Empty)
            {
                carregarlv();
            }
            else
            {
                carregarlvcomp();
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

        private void tb_quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
        public void carregarvalortotal()
        {
            var total = 0m;
            for (int i = 0; i < lv_carrinho.Items.Count; i++)
            {
                total += decimal.Parse(lv_carrinho.Items[i].SubItems[5].Text);

            }
            lb_total.Text = total.ToString("F2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Realizar_Venda venda = new Realizar_Venda();
            venda.realizar_venda(id_usuario, nome_usuario, float.Parse(lb_total.Text));
            for (int i = 0; i < lv_carrinho.Items.Count; i++)
            {
                Realizar_Venda vendaitem = new Realizar_Venda();
                vendaitem.preencher_itens_venda(id_venda, int.Parse(lv_carrinho.Items[i].SubItems[1].Text), lv_carrinho.Items[i].SubItems[2].Text,
                                            lv_carrinho.Items[i].SubItems[3].Text, int.Parse(lv_carrinho.Items[i].SubItems[4].Text),
                                            float.Parse(lv_carrinho.Items[i].SubItems[5].Text));
                vendaitem.baixaritens_venda(int.Parse(lv_carrinho.Items[i].SubItems[4].Text), lv_carrinho.Items[i].SubItems[3].Text);
            }
            MessageBox.Show(venda.mensagem);
            lv_carrinho.Items.Clear();
            carregar_id_venda();
            limpar();
        }
        public void carregar_id_venda()
        {
            try
            {
                Conexao conexao = new Conexao();
                //Comando SQL --SqlCommand
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select MAX(id_venda) from venda";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexao.conectar();
                if (cmd.ExecuteScalar() == DBNull.Value)
                {
                    id_venda = 1;
                    lbl_id_venda.Text = "1";
                }
                else
                {
                    id_venda = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                    lbl_id_venda.Text = id_venda.ToString();
                }

                conexao.desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar no banco de dados!!!");
            }
        }

        private void lv_estoque_MouseClick(object sender, MouseEventArgs e)
        {
            lb_nome.Text = lv_estoque.SelectedItems[0].SubItems[2].Text;
            lb_valor.Text = lv_estoque.SelectedItems[0].SubItems[6].Text;
            tb_quantidade.Text = "1";
        }

        private void tb_quantidade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
