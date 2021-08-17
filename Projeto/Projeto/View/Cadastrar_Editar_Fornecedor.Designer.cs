
namespace Projeto.View
{
    partial class Cadastrar_Editar_Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar_Editar_Fornecedor));
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email_fornecedor = new System.Windows.Forms.TextBox();
            this.endereco_fornecedor = new System.Windows.Forms.TextBox();
            this.cidade_fornecedor = new System.Windows.Forms.TextBox();
            this.nome_fornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lv_fornecedor = new System.Windows.Forms.ListView();
            this.col_idforn = new System.Windows.Forms.ColumnHeader();
            this.col_nomeforn = new System.Windows.Forms.ColumnHeader();
            this.col_cidforn = new System.Windows.Forms.ColumnHeader();
            this.col_endforn = new System.Windows.Forms.ColumnHeader();
            this.col_emailforn = new System.Windows.Forms.ColumnHeader();
            this.col_telforn = new System.Windows.Forms.ColumnHeader();
            this.col_cnpjforn = new System.Windows.Forms.ColumnHeader();
            this.telefone_fornecedor = new System.Windows.Forms.MaskedTextBox();
            this.cnpj_fornecedor = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "CNPJ";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Location = new System.Drawing.Point(182, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(74, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Cidade";
            // 
            // email_fornecedor
            // 
            this.email_fornecedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.email_fornecedor.Location = new System.Drawing.Point(74, 101);
            this.email_fornecedor.Name = "email_fornecedor";
            this.email_fornecedor.Size = new System.Drawing.Size(207, 23);
            this.email_fornecedor.TabIndex = 4;
            // 
            // endereco_fornecedor
            // 
            this.endereco_fornecedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.endereco_fornecedor.Location = new System.Drawing.Point(74, 72);
            this.endereco_fornecedor.Name = "endereco_fornecedor";
            this.endereco_fornecedor.Size = new System.Drawing.Size(207, 23);
            this.endereco_fornecedor.TabIndex = 3;
            // 
            // cidade_fornecedor
            // 
            this.cidade_fornecedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cidade_fornecedor.Location = new System.Drawing.Point(74, 43);
            this.cidade_fornecedor.Name = "cidade_fornecedor";
            this.cidade_fornecedor.Size = new System.Drawing.Size(207, 23);
            this.cidade_fornecedor.TabIndex = 2;
            // 
            // nome_fornecedor
            // 
            this.nome_fornecedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nome_fornecedor.Location = new System.Drawing.Point(74, 13);
            this.nome_fornecedor.Name = "nome_fornecedor";
            this.nome_fornecedor.Size = new System.Drawing.Size(207, 23);
            this.nome_fornecedor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nome";
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.Location = new System.Drawing.Point(182, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 29);
            this.button4.TabIndex = 8;
            this.button4.Text = "Deletar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lv_fornecedor
            // 
            this.lv_fornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_fornecedor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_idforn,
            this.col_nomeforn,
            this.col_cidforn,
            this.col_endforn,
            this.col_emailforn,
            this.col_telforn,
            this.col_cnpjforn});
            this.lv_fornecedor.HideSelection = false;
            this.lv_fornecedor.Location = new System.Drawing.Point(287, 11);
            this.lv_fornecedor.Name = "lv_fornecedor";
            this.lv_fornecedor.Size = new System.Drawing.Size(723, 477);
            this.lv_fornecedor.TabIndex = 11;
            this.lv_fornecedor.UseCompatibleStateImageBehavior = false;
            this.lv_fornecedor.View = System.Windows.Forms.View.Details;
            this.lv_fornecedor.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.lv_fornecedor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_fornecedor_MouseClick);
            // 
            // col_idforn
            // 
            this.col_idforn.Text = "ID";
            this.col_idforn.Width = 30;
            // 
            // col_nomeforn
            // 
            this.col_nomeforn.Text = "Nome";
            this.col_nomeforn.Width = 80;
            // 
            // col_cidforn
            // 
            this.col_cidforn.Text = "Cidade";
            this.col_cidforn.Width = 80;
            // 
            // col_endforn
            // 
            this.col_endforn.Text = "Endereço";
            this.col_endforn.Width = 140;
            // 
            // col_emailforn
            // 
            this.col_emailforn.Text = "Email";
            this.col_emailforn.Width = 140;
            // 
            // col_telforn
            // 
            this.col_telforn.Text = "Telefone";
            this.col_telforn.Width = 100;
            // 
            // col_cnpjforn
            // 
            this.col_cnpjforn.Text = "CNPJ";
            this.col_cnpjforn.Width = 120;
            // 
            // telefone_fornecedor
            // 
            this.telefone_fornecedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.telefone_fornecedor.Location = new System.Drawing.Point(74, 130);
            this.telefone_fornecedor.Mask = "(00)00000-0000";
            this.telefone_fornecedor.Name = "telefone_fornecedor";
            this.telefone_fornecedor.Size = new System.Drawing.Size(207, 23);
            this.telefone_fornecedor.TabIndex = 5;
            // 
            // cnpj_fornecedor
            // 
            this.cnpj_fornecedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cnpj_fornecedor.Location = new System.Drawing.Point(74, 159);
            this.cnpj_fornecedor.Mask = "00,000,000/0000-00";
            this.cnpj_fornecedor.Name = "cnpj_fornecedor";
            this.cnpj_fornecedor.Size = new System.Drawing.Size(207, 23);
            this.cnpj_fornecedor.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.Location = new System.Drawing.Point(74, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // Cadastrar_Editar_Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1022, 496);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cnpj_fornecedor);
            this.Controls.Add(this.telefone_fornecedor);
            this.Controls.Add(this.lv_fornecedor);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email_fornecedor);
            this.Controls.Add(this.endereco_fornecedor);
            this.Controls.Add(this.cidade_fornecedor);
            this.Controls.Add(this.nome_fornecedor);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastrar_Editar_Fornecedor";
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.Editar_Fornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_fornecedor;
        private System.Windows.Forms.TextBox endereco_fornecedor;
        private System.Windows.Forms.TextBox cidade_fornecedor;
        private System.Windows.Forms.TextBox nome_fornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView lv_fornecedor;
        private System.Windows.Forms.ColumnHeader col_idforn;
        private System.Windows.Forms.ColumnHeader col_nomeforn;
        private System.Windows.Forms.ColumnHeader col_cidforn;
        private System.Windows.Forms.ColumnHeader col_endforn;
        private System.Windows.Forms.ColumnHeader col_emailforn;
        private System.Windows.Forms.ColumnHeader col_telforn;
        private System.Windows.Forms.ColumnHeader col_cnpjforn;
        private System.Windows.Forms.MaskedTextBox telefone_fornecedor;
        private System.Windows.Forms.MaskedTextBox cnpj_fornecedor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}