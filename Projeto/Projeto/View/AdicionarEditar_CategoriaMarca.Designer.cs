
namespace Projeto.View
{
    partial class AdicionarEditar_CategoriaMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarEditar_CategoriaMarca));
            this.button3 = new System.Windows.Forms.Button();
            this.lv_categoria = new System.Windows.Forms.ListView();
            this.col_idcat = new System.Windows.Forms.ColumnHeader();
            this.col_nomecat = new System.Windows.Forms.ColumnHeader();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nome_item = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_marca = new System.Windows.Forms.ListView();
            this.col_idmarc = new System.Windows.Forms.ColumnHeader();
            this.col_nomemarc = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radio_marca = new System.Windows.Forms.RadioButton();
            this.radio_categoria = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lv_categoria
            // 
            this.lv_categoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_categoria.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_idcat,
            this.col_nomecat});
            this.lv_categoria.HideSelection = false;
            this.lv_categoria.Location = new System.Drawing.Point(520, 37);
            this.lv_categoria.Name = "lv_categoria";
            this.lv_categoria.Size = new System.Drawing.Size(248, 326);
            this.lv_categoria.TabIndex = 9;
            this.lv_categoria.UseCompatibleStateImageBehavior = false;
            this.lv_categoria.View = System.Windows.Forms.View.Details;
            this.lv_categoria.SelectedIndexChanged += new System.EventHandler(this.lv_categoria_SelectedIndexChanged);
            this.lv_categoria.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_categoria_MouseClick);
            // 
            // col_idcat
            // 
            this.col_idcat.Text = "ID";
            this.col_idcat.Width = 30;
            // 
            // col_nomecat
            // 
            this.col_nomecat.Text = "Nome";
            this.col_nomecat.Width = 110;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(165, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 29);
            this.button4.TabIndex = 5;
            this.button4.Text = "Deletar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nome_item
            // 
            this.nome_item.Location = new System.Drawing.Point(57, 12);
            this.nome_item.Name = "nome_item";
            this.nome_item.Size = new System.Drawing.Size(207, 23);
            this.nome_item.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nome";
            // 
            // lv_marca
            // 
            this.lv_marca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lv_marca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_idmarc,
            this.col_nomemarc});
            this.lv_marca.HideSelection = false;
            this.lv_marca.Location = new System.Drawing.Point(284, 37);
            this.lv_marca.Name = "lv_marca";
            this.lv_marca.Size = new System.Drawing.Size(230, 326);
            this.lv_marca.TabIndex = 8;
            this.lv_marca.UseCompatibleStateImageBehavior = false;
            this.lv_marca.View = System.Windows.Forms.View.Details;
            this.lv_marca.SelectedIndexChanged += new System.EventHandler(this.lv_marca_SelectedIndexChanged);
            this.lv_marca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_marca_MouseClick);
            // 
            // col_idmarc
            // 
            this.col_idmarc.Text = "ID";
            this.col_idmarc.Width = 30;
            // 
            // col_nomemarc
            // 
            this.col_nomemarc.Text = "Nome";
            this.col_nomemarc.Width = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(359, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 30);
            this.label2.TabIndex = 71;
            this.label2.Text = "Marcas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(583, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 30);
            this.label3.TabIndex = 72;
            this.label3.Text = "Categorias";
            // 
            // radio_marca
            // 
            this.radio_marca.AutoSize = true;
            this.radio_marca.BackColor = System.Drawing.Color.Transparent;
            this.radio_marca.ForeColor = System.Drawing.Color.White;
            this.radio_marca.Location = new System.Drawing.Point(86, 41);
            this.radio_marca.Name = "radio_marca";
            this.radio_marca.Size = new System.Drawing.Size(58, 19);
            this.radio_marca.TabIndex = 2;
            this.radio_marca.TabStop = true;
            this.radio_marca.Text = "Marca";
            this.radio_marca.UseVisualStyleBackColor = false;
            // 
            // radio_categoria
            // 
            this.radio_categoria.AutoSize = true;
            this.radio_categoria.BackColor = System.Drawing.Color.Transparent;
            this.radio_categoria.ForeColor = System.Drawing.Color.White;
            this.radio_categoria.Location = new System.Drawing.Point(165, 41);
            this.radio_categoria.Name = "radio_categoria";
            this.radio_categoria.Size = new System.Drawing.Size(76, 19);
            this.radio_categoria.TabIndex = 3;
            this.radio_categoria.TabStop = true;
            this.radio_categoria.Text = "Categoria";
            this.radio_categoria.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // AdicionarEditar_CategoriaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 368);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radio_categoria);
            this.Controls.Add(this.radio_marca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lv_marca);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lv_categoria);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nome_item);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdicionarEditar_CategoriaMarca";
            this.Text = "AdicionarEditar_CategoriaMarca";
            this.Load += new System.EventHandler(this.AdicionarEditar_CategoriaMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView lv_categoria;
        private System.Windows.Forms.ColumnHeader col_idcat;
        private System.Windows.Forms.ColumnHeader col_nomecat;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nome_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_marca;
        private System.Windows.Forms.ColumnHeader col_idmarc;
        private System.Windows.Forms.ColumnHeader col_nomemarc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radio_marca;
        private System.Windows.Forms.RadioButton radio_categoria;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}