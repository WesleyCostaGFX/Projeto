
namespace Projeto.View
{
    partial class Entrada_Prod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada_Prod));
            this.aaa = new System.Windows.Forms.TextBox();
            this.lbl_qtd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_lote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cal_fab = new System.Windows.Forms.MonthCalendar();
            this.lbl_nomeprod = new System.Windows.Forms.Label();
            this.cb_forn = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lv_estoque = new System.Windows.Forms.ListView();
            this.id_est = new System.Windows.Forms.ColumnHeader();
            this.col_idprod = new System.Windows.Forms.ColumnHeader();
            this.col_nomeprod = new System.Windows.Forms.ColumnHeader();
            this.id_forn = new System.Windows.Forms.ColumnHeader();
            this.col_forn = new System.Windows.Forms.ColumnHeader();
            this.col_loteprod = new System.Windows.Forms.ColumnHeader();
            this.col_fabr = new System.Windows.Forms.ColumnHeader();
            this.col_qtde = new System.Windows.Forms.ColumnHeader();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aaa
            // 
            this.aaa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.aaa.Location = new System.Drawing.Point(146, 122);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(58, 23);
            this.aaa.TabIndex = 15;
            this.aaa.TextChanged += new System.EventHandler(this.tb_qtde_TextChanged);
            this.aaa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aaa_KeyPress);
            // 
            // lbl_qtd
            // 
            this.lbl_qtd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_qtd.AutoSize = true;
            this.lbl_qtd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_qtd.ForeColor = System.Drawing.Color.White;
            this.lbl_qtd.Location = new System.Drawing.Point(60, 125);
            this.lbl_qtd.Name = "lbl_qtd";
            this.lbl_qtd.Size = new System.Drawing.Size(69, 15);
            this.lbl_qtd.TabIndex = 14;
            this.lbl_qtd.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(123, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fabricação";
            // 
            // tb_lote
            // 
            this.tb_lote.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_lote.Location = new System.Drawing.Point(91, 91);
            this.tb_lote.Name = "tb_lote";
            this.tb_lote.Size = new System.Drawing.Size(171, 23);
            this.tb_lote.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lote";
            // 
            // tb_cod
            // 
            this.tb_cod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_cod.Location = new System.Drawing.Point(91, 18);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.Size = new System.Drawing.Size(171, 23);
            this.tb_cod.TabIndex = 9;
            this.tb_cod.TextChanged += new System.EventHandler(this.tb_cod_TextChanged);
            this.tb_cod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cod_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Código";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Location = new System.Drawing.Point(155, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(39, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Adicionar/Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cal_fab
            // 
            this.cal_fab.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cal_fab.Location = new System.Drawing.Point(39, 170);
            this.cal_fab.Name = "cal_fab";
            this.cal_fab.ShowToday = false;
            this.cal_fab.TabIndex = 19;
            // 
            // lbl_nomeprod
            // 
            this.lbl_nomeprod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_nomeprod.AutoSize = true;
            this.lbl_nomeprod.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nomeprod.ForeColor = System.Drawing.Color.White;
            this.lbl_nomeprod.Location = new System.Drawing.Point(91, 44);
            this.lbl_nomeprod.Name = "lbl_nomeprod";
            this.lbl_nomeprod.Size = new System.Drawing.Size(12, 15);
            this.lbl_nomeprod.TabIndex = 21;
            this.lbl_nomeprod.Text = "-";
            // 
            // cb_forn
            // 
            this.cb_forn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_forn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_forn.FormattingEnabled = true;
            this.cb_forn.Location = new System.Drawing.Point(91, 62);
            this.cb_forn.Name = "cb_forn";
            this.cb_forn.Size = new System.Drawing.Size(171, 23);
            this.cb_forn.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fornecedor";
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
            this.id_forn,
            this.col_forn,
            this.col_loteprod,
            this.col_fabr,
            this.col_qtde});
            this.lv_estoque.HideSelection = false;
            this.lv_estoque.Location = new System.Drawing.Point(278, 12);
            this.lv_estoque.Name = "lv_estoque";
            this.lv_estoque.Size = new System.Drawing.Size(807, 611);
            this.lv_estoque.TabIndex = 24;
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
            this.col_nomeprod.Width = 100;
            // 
            // id_forn
            // 
            this.id_forn.Text = "id_fornecedor";
            this.id_forn.Width = 0;
            // 
            // col_forn
            // 
            this.col_forn.Text = "Fornecedor";
            this.col_forn.Width = 80;
            // 
            // col_loteprod
            // 
            this.col_loteprod.Text = "Lote";
            // 
            // col_fabr
            // 
            this.col_fabr.Text = "Fabricação";
            this.col_fabr.Width = 70;
            // 
            // col_qtde
            // 
            this.col_qtde.Text = "Estoque";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(47, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nome:";
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.Location = new System.Drawing.Point(39, 373);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(223, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 416);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Entrada_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1097, 628);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lv_estoque);
            this.Controls.Add(this.cb_forn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_nomeprod);
            this.Controls.Add(this.cal_fab);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.lbl_qtd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_lote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cod);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entrada_Prod";
            this.Text = "Entrada de Produtos";
            this.Load += new System.EventHandler(this.Entrada_Prod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aaa;
        private System.Windows.Forms.Label lbl_qtd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_lote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar cal_fab;
        private System.Windows.Forms.Label lbl_nomeprod;
        private System.Windows.Forms.ComboBox cb_forn;
        protected System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lv_estoque;
        private System.Windows.Forms.ColumnHeader col_idprod;
        private System.Windows.Forms.ColumnHeader col_nomeprod;
        private System.Windows.Forms.ColumnHeader col_loteprod;
        private System.Windows.Forms.ColumnHeader col_fabr;
        private System.Windows.Forms.ColumnHeader col_qtde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader col_forn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader id_forn;
        private System.Windows.Forms.ColumnHeader id_est;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}