
namespace Projeto.View
{
    partial class Saida_Prod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saida_Prod));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tb_qtde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lv_estoque = new System.Windows.Forms.ListView();
            this.id_est = new System.Windows.Forms.ColumnHeader();
            this.col_idprod = new System.Windows.Forms.ColumnHeader();
            this.col_nomeprod = new System.Windows.Forms.ColumnHeader();
            this.id_forn = new System.Windows.Forms.ColumnHeader();
            this.col_forn = new System.Windows.Forms.ColumnHeader();
            this.col_loteprod = new System.Windows.Forms.ColumnHeader();
            this.col_fabr = new System.Windows.Forms.ColumnHeader();
            this.col_qtde = new System.Windows.Forms.ColumnHeader();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_codigo
            // 
            this.tb_codigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_codigo.Location = new System.Drawing.Point(62, 54);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(133, 23);
            this.tb_codigo.TabIndex = 1;
            this.tb_codigo.TextChanged += new System.EventHandler(this.tb_codigo_TextChanged);
            this.tb_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_codigo_KeyPress);
            // 
            // tb_qtde
            // 
            this.tb_qtde.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_qtde.Location = new System.Drawing.Point(121, 83);
            this.tb_qtde.Name = "tb_qtde";
            this.tb_qtde.Size = new System.Drawing.Size(52, 23);
            this.tb_qtde.TabIndex = 3;
            this.tb_qtde.TextChanged += new System.EventHandler(this.tb_qtde_TextChanged);
            this.tb_qtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(40, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Location = new System.Drawing.Point(121, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lv_estoque
            // 
            this.lv_estoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_estoque.BackColor = System.Drawing.Color.White;
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
            this.lv_estoque.Location = new System.Drawing.Point(201, 11);
            this.lv_estoque.Name = "lv_estoque";
            this.lv_estoque.Size = new System.Drawing.Size(470, 343);
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Saida_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 368);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lv_estoque);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_qtde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Saida_Prod";
            this.Text = "Baixa de Produtos";
            this.Load += new System.EventHandler(this.Saida_Prod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_qtde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lv_estoque;
        private System.Windows.Forms.ColumnHeader id_est;
        private System.Windows.Forms.ColumnHeader col_idprod;
        private System.Windows.Forms.ColumnHeader col_nomeprod;
        private System.Windows.Forms.ColumnHeader id_forn;
        private System.Windows.Forms.ColumnHeader col_forn;
        private System.Windows.Forms.ColumnHeader col_loteprod;
        private System.Windows.Forms.ColumnHeader col_fabr;
        private System.Windows.Forms.ColumnHeader col_qtde;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}