
namespace Projeto
{
    partial class Caixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caixa));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lv_estoque = new System.Windows.Forms.ListView();
            this.id_est = new System.Windows.Forms.ColumnHeader();
            this.col_idprod = new System.Windows.Forms.ColumnHeader();
            this.col_nomeprod = new System.Windows.Forms.ColumnHeader();
            this.col_loteprod = new System.Windows.Forms.ColumnHeader();
            this.col_fabr = new System.Windows.Forms.ColumnHeader();
            this.col_qtde = new System.Windows.Forms.ColumnHeader();
            this.col_valor = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.lv_carrinho = new System.Windows.Forms.ListView();
            this.id_estoque = new System.Windows.Forms.ColumnHeader();
            this.id_produto = new System.Windows.Forms.ColumnHeader();
            this.nome_produto = new System.Windows.Forms.ColumnHeader();
            this.lote_produto = new System.Windows.Forms.ColumnHeader();
            this.qtde_produto = new System.Windows.Forms.ColumnHeader();
            this.valor_itens = new System.Windows.Forms.ColumnHeader();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_valor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_id_venda = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da Compra";
            // 
            // tb_codigo
            // 
            this.tb_codigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_codigo.Location = new System.Drawing.Point(117, 11);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(151, 23);
            this.tb_codigo.TabIndex = 1;
            this.tb_codigo.TextChanged += new System.EventHandler(this.tb_codigo_TextChanged);
            this.tb_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_codigo_KeyPress);
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_quantidade.Location = new System.Drawing.Point(117, 82);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(151, 23);
            this.tb_quantidade.TabIndex = 2;
            this.tb_quantidade.TextChanged += new System.EventHandler(this.tb_quantidade_TextChanged);
            this.tb_quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_quantidade_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(117, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(31, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Finalizar Venda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(31, 450);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(251, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "Cancelar Venda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lv_estoque
            // 
            this.lv_estoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_estoque.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_est,
            this.col_idprod,
            this.col_nomeprod,
            this.col_loteprod,
            this.col_fabr,
            this.col_qtde,
            this.col_valor});
            this.lv_estoque.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_estoque.FullRowSelect = true;
            this.lv_estoque.HideSelection = false;
            this.lv_estoque.Location = new System.Drawing.Point(288, 11);
            this.lv_estoque.Name = "lv_estoque";
            this.lv_estoque.Size = new System.Drawing.Size(844, 313);
            this.lv_estoque.TabIndex = 25;
            this.lv_estoque.UseCompatibleStateImageBehavior = false;
            this.lv_estoque.View = System.Windows.Forms.View.Details;
            this.lv_estoque.SelectedIndexChanged += new System.EventHandler(this.lv_estoque_SelectedIndexChanged);
            this.lv_estoque.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_estoque_MouseClick);
            // 
            // id_est
            // 
            this.id_est.Text = "id_est";
            this.id_est.Width = 0;
            // 
            // col_idprod
            // 
            this.col_idprod.Text = "ID";
            this.col_idprod.Width = 30;
            // 
            // col_nomeprod
            // 
            this.col_nomeprod.Text = "Nome";
            this.col_nomeprod.Width = 170;
            // 
            // col_loteprod
            // 
            this.col_loteprod.Text = "Lote";
            // 
            // col_fabr
            // 
            this.col_fabr.Text = "Fabricação";
            this.col_fabr.Width = 80;
            // 
            // col_qtde
            // 
            this.col_qtde.Text = "Estoque";
            // 
            // col_valor
            // 
            this.col_valor.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nome: ";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.BackColor = System.Drawing.Color.Transparent;
            this.lb_nome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_nome.ForeColor = System.Drawing.Color.White;
            this.lb_nome.Location = new System.Drawing.Point(112, 40);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(12, 15);
            this.lb_nome.TabIndex = 28;
            this.lb_nome.Text = "-";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(203, 512);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 47);
            this.button5.TabIndex = 29;
            this.button5.Text = "Remover do Carrinho";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lv_carrinho
            // 
            this.lv_carrinho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_carrinho.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_estoque,
            this.id_produto,
            this.nome_produto,
            this.lote_produto,
            this.qtde_produto,
            this.valor_itens});
            this.lv_carrinho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_carrinho.FullRowSelect = true;
            this.lv_carrinho.HideSelection = false;
            this.lv_carrinho.Location = new System.Drawing.Point(288, 376);
            this.lv_carrinho.MultiSelect = false;
            this.lv_carrinho.Name = "lv_carrinho";
            this.lv_carrinho.Size = new System.Drawing.Size(844, 183);
            this.lv_carrinho.TabIndex = 30;
            this.lv_carrinho.UseCompatibleStateImageBehavior = false;
            this.lv_carrinho.View = System.Windows.Forms.View.Details;
            // 
            // id_estoque
            // 
            this.id_estoque.Text = "id_est";
            this.id_estoque.Width = 0;
            // 
            // id_produto
            // 
            this.id_produto.Text = "ID";
            this.id_produto.Width = 30;
            // 
            // nome_produto
            // 
            this.nome_produto.Text = "Nome";
            this.nome_produto.Width = 150;
            // 
            // lote_produto
            // 
            this.lote_produto.Text = "Lote";
            // 
            // qtde_produto
            // 
            this.qtde_produto.Text = "Quantidade";
            this.qtde_produto.Width = 80;
            // 
            // valor_itens
            // 
            this.valor_itens.Text = "Valor";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(446, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 46);
            this.label6.TabIndex = 31;
            this.label6.Text = "Carrinho";
            // 
            // lb_total
            // 
            this.lb_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_total.AutoSize = true;
            this.lb_total.BackColor = System.Drawing.Color.Transparent;
            this.lb_total.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_total.ForeColor = System.Drawing.Color.White;
            this.lb_total.Location = new System.Drawing.Point(65, 349);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(81, 46);
            this.lb_total.TabIndex = 32;
            this.lb_total.Text = "0,00";
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.BackColor = System.Drawing.Color.Transparent;
            this.lb_valor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_valor.ForeColor = System.Drawing.Color.White;
            this.lb_valor.Location = new System.Drawing.Point(112, 62);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(12, 15);
            this.lb_valor.TabIndex = 34;
            this.lb_valor.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(73, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "Valor";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1058, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Venda:";
            // 
            // lbl_id_venda
            // 
            this.lbl_id_venda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_id_venda.AutoSize = true;
            this.lbl_id_venda.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id_venda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_id_venda.ForeColor = System.Drawing.Color.White;
            this.lbl_id_venda.Location = new System.Drawing.Point(1114, 564);
            this.lbl_id_venda.Name = "lbl_id_venda";
            this.lbl_id_venda.Size = new System.Drawing.Size(17, 19);
            this.lbl_id_venda.TabIndex = 36;
            this.lbl_id_venda.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 46);
            this.label7.TabIndex = 37;
            this.label7.Text = "R$";
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 592);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_id_venda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_valor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lv_carrinho);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lv_estoque);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_quantidade);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Caixa";
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.Caixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView lv_estoque;
        private System.Windows.Forms.ColumnHeader id_est;
        private System.Windows.Forms.ColumnHeader col_idprod;
        private System.Windows.Forms.ColumnHeader col_nomeprod;
        private System.Windows.Forms.ColumnHeader col_loteprod;
        private System.Windows.Forms.ColumnHeader col_qtde;
        private System.Windows.Forms.ColumnHeader col_fabr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView lv_carrinho;
        private System.Windows.Forms.ColumnHeader id_estoque;
        private System.Windows.Forms.ColumnHeader id_produto;
        private System.Windows.Forms.ColumnHeader nome_produto;
        private System.Windows.Forms.ColumnHeader lote_produto;
        private System.Windows.Forms.ColumnHeader qtde_produto;
        private System.Windows.Forms.ColumnHeader valor_itens;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader col_valor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_id_venda;
        private System.Windows.Forms.Label label7;
    }
}