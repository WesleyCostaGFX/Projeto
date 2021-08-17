
namespace Projeto.View
{
    partial class AdicionarEditar_Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarEditar_Produtos));
            this.label1 = new System.Windows.Forms.Label();
            this.nome_produto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lv_produto = new System.Windows.Forms.ListView();
            this.col_id = new System.Windows.Forms.ColumnHeader();
            this.col_nome = new System.Windows.Forms.ColumnHeader();
            this.col_valor = new System.Windows.Forms.ColumnHeader();
            this.col_marca = new System.Windows.Forms.ColumnHeader();
            this.col_categoria = new System.Windows.Forms.ColumnHeader();
            this.valor_produto = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // nome_produto
            // 
            this.nome_produto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nome_produto.Location = new System.Drawing.Point(83, 19);
            this.nome_produto.Name = "nome_produto";
            this.nome_produto.Size = new System.Drawing.Size(171, 23);
            this.nome_produto.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-184, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(83, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Location = new System.Drawing.Point(164, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Deletar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_marca
            // 
            this.cb_marca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.Location = new System.Drawing.Point(83, 77);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(171, 23);
            this.cb_marca.TabIndex = 4;
            this.cb_marca.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Marca";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cb_categoria
            // 
            this.cb_categoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(83, 106);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(171, 23);
            this.cb_categoria.TabIndex = 5;
            this.cb_categoria.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Categoria";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(44, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Valor";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.Location = new System.Drawing.Point(83, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.Location = new System.Drawing.Point(164, 164);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lv_produto
            // 
            this.lv_produto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_produto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_nome,
            this.col_valor,
            this.col_marca,
            this.col_categoria});
            this.lv_produto.HideSelection = false;
            this.lv_produto.Location = new System.Drawing.Point(260, 12);
            this.lv_produto.Name = "lv_produto";
            this.lv_produto.Size = new System.Drawing.Size(571, 368);
            this.lv_produto.TabIndex = 11;
            this.lv_produto.UseCompatibleStateImageBehavior = false;
            this.lv_produto.View = System.Windows.Forms.View.Details;
            this.lv_produto.SelectedIndexChanged += new System.EventHandler(this.lv_produto_SelectedIndexChanged);
            this.lv_produto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_produto_MouseClick);
            // 
            // col_id
            // 
            this.col_id.Text = "ID";
            this.col_id.Width = 30;
            // 
            // col_nome
            // 
            this.col_nome.Text = "Nome";
            this.col_nome.Width = 100;
            // 
            // col_valor
            // 
            this.col_valor.Text = "Valor";
            // 
            // col_marca
            // 
            this.col_marca.Text = "Marca";
            this.col_marca.Width = 90;
            // 
            // col_categoria
            // 
            this.col_categoria.Text = "Categoria";
            this.col_categoria.Width = 90;
            // 
            // valor_produto
            // 
            this.valor_produto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.valor_produto.Location = new System.Drawing.Point(83, 48);
            this.valor_produto.Name = "valor_produto";
            this.valor_produto.Size = new System.Drawing.Size(171, 23);
            this.valor_produto.TabIndex = 2;
            this.valor_produto.TextChanged += new System.EventHandler(this.valor_produto_TextChanged);
            this.valor_produto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valor_produto_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // AdicionarEditar_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 396);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lv_produto);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.valor_produto);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_marca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nome_produto);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdicionarEditar_Produtos";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.AdicionarEditar_Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nome_produto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_marca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView lv_produto;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_nome;
        private System.Windows.Forms.ColumnHeader col_valor;
        private System.Windows.Forms.ColumnHeader col_marca;
        private System.Windows.Forms.ColumnHeader col_categoria;
        private System.Windows.Forms.TextBox valor_produto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}