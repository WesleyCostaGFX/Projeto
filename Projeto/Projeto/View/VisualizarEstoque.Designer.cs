
namespace Projeto.View
{
    partial class VisualizarEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarEstoque));
            this.lv_estoque = new System.Windows.Forms.ListView();
            this.id_est = new System.Windows.Forms.ColumnHeader();
            this.col_idprod = new System.Windows.Forms.ColumnHeader();
            this.col_nomeprod = new System.Windows.Forms.ColumnHeader();
            this.id_forn = new System.Windows.Forms.ColumnHeader();
            this.col_forn = new System.Windows.Forms.ColumnHeader();
            this.col_loteprod = new System.Windows.Forms.ColumnHeader();
            this.col_fabr = new System.Windows.Forms.ColumnHeader();
            this.col_qtde = new System.Windows.Forms.ColumnHeader();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.lv_estoque.Location = new System.Drawing.Point(223, 39);
            this.lv_estoque.Name = "lv_estoque";
            this.lv_estoque.Size = new System.Drawing.Size(615, 459);
            this.lv_estoque.TabIndex = 33;
            this.lv_estoque.UseCompatibleStateImageBehavior = false;
            this.lv_estoque.View = System.Windows.Forms.View.Details;
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
            this.col_forn.Width = 120;
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
            // tb_codigo
            // 
            this.tb_codigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_codigo.Location = new System.Drawing.Point(64, 10);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(774, 23);
            this.tb_codigo.TabIndex = 27;
            this.tb_codigo.TextChanged += new System.EventHandler(this.tb_codigo_TextChanged);
            this.tb_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_codigo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Código";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // VisualizarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 504);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lv_estoque);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisualizarEstoque";
            this.Text = "VisualizarEstoque";
            this.Load += new System.EventHandler(this.VisualizarEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_estoque;
        private System.Windows.Forms.ColumnHeader id_est;
        private System.Windows.Forms.ColumnHeader col_idprod;
        private System.Windows.Forms.ColumnHeader col_nomeprod;
        private System.Windows.Forms.ColumnHeader id_forn;
        private System.Windows.Forms.ColumnHeader col_forn;
        private System.Windows.Forms.ColumnHeader col_loteprod;
        private System.Windows.Forms.ColumnHeader col_fabr;
        private System.Windows.Forms.ColumnHeader col_qtde;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}