
namespace Projeto.View
{
    partial class Editar_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Usuario));
            this.funcao_usuario = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.senha_usuario = new System.Windows.Forms.TextBox();
            this.email_usuario = new System.Windows.Forms.TextBox();
            this.nome_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lv_usuario = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.nome = new System.Windows.Forms.ColumnHeader();
            this.cpf = new System.Windows.Forms.ColumnHeader();
            this.email = new System.Windows.Forms.ColumnHeader();
            this.senha = new System.Windows.Forms.ColumnHeader();
            this.funcao = new System.Windows.Forms.ColumnHeader();
            this.button4 = new System.Windows.Forms.Button();
            this.cpf_usuario = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // funcao_usuario
            // 
            this.funcao_usuario.AccessibleName = "";
            this.funcao_usuario.AllowDrop = true;
            this.funcao_usuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.funcao_usuario.DisplayMember = "Vendedor";
            this.funcao_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcao_usuario.FormattingEnabled = true;
            this.funcao_usuario.Items.AddRange(new object[] {
            "Caixa",
            "Administrador",
            "Vendedor"});
            this.funcao_usuario.Location = new System.Drawing.Point(72, 155);
            this.funcao_usuario.Name = "funcao_usuario";
            this.funcao_usuario.Size = new System.Drawing.Size(171, 23);
            this.funcao_usuario.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Location = new System.Drawing.Point(168, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(72, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 6;
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
            this.label6.Location = new System.Drawing.Point(5, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 46;
            this.label6.Text = "Permissão";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "Senha";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "CPF";
            // 
            // senha_usuario
            // 
            this.senha_usuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.senha_usuario.Location = new System.Drawing.Point(72, 126);
            this.senha_usuario.Name = "senha_usuario";
            this.senha_usuario.PasswordChar = '*';
            this.senha_usuario.Size = new System.Drawing.Size(171, 23);
            this.senha_usuario.TabIndex = 4;
            // 
            // email_usuario
            // 
            this.email_usuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.email_usuario.Location = new System.Drawing.Point(72, 97);
            this.email_usuario.Name = "email_usuario";
            this.email_usuario.Size = new System.Drawing.Size(171, 23);
            this.email_usuario.TabIndex = 3;
            // 
            // nome_usuario
            // 
            this.nome_usuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nome_usuario.Location = new System.Drawing.Point(72, 39);
            this.nome_usuario.Name = "nome_usuario";
            this.nome_usuario.Size = new System.Drawing.Size(171, 23);
            this.nome_usuario.TabIndex = 1;
            this.nome_usuario.TextChanged += new System.EventHandler(this.nome_usuario_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nome";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.Location = new System.Drawing.Point(168, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Deletar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lv_usuario
            // 
            this.lv_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_usuario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nome,
            this.cpf,
            this.email,
            this.senha,
            this.funcao});
            this.lv_usuario.HideSelection = false;
            this.lv_usuario.Location = new System.Drawing.Point(266, 12);
            this.lv_usuario.Name = "lv_usuario";
            this.lv_usuario.Size = new System.Drawing.Size(787, 480);
            this.lv_usuario.TabIndex = 10;
            this.lv_usuario.UseCompatibleStateImageBehavior = false;
            this.lv_usuario.View = System.Windows.Forms.View.Details;
            this.lv_usuario.SelectedIndexChanged += new System.EventHandler(this.lv_usuario_SelectedIndexChanged);
            this.lv_usuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_usuario_MouseClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 30;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 140;
            // 
            // cpf
            // 
            this.cpf.Text = "CPF";
            this.cpf.Width = 120;
            // 
            // email
            // 
            this.email.Text = "E-Mail";
            this.email.Width = 140;
            // 
            // senha
            // 
            this.senha.Text = "Senha";
            this.senha.Width = 100;
            // 
            // funcao
            // 
            this.funcao.Text = "Função";
            this.funcao.Width = 100;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.Location = new System.Drawing.Point(72, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 24);
            this.button4.TabIndex = 8;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // cpf_usuario
            // 
            this.cpf_usuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cpf_usuario.Location = new System.Drawing.Point(72, 68);
            this.cpf_usuario.Mask = "000,000,000-00";
            this.cpf_usuario.Name = "cpf_usuario";
            this.cpf_usuario.Size = new System.Drawing.Size(171, 23);
            this.cpf_usuario.TabIndex = 2;
            this.cpf_usuario.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // Editar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cpf_usuario);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lv_usuario);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.funcao_usuario);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.senha_usuario);
            this.Controls.Add(this.email_usuario);
            this.Controls.Add(this.nome_usuario);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editar_Usuario";
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.Editar_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox funcao_usuario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox senha_usuario;
        private System.Windows.Forms.TextBox email_usuario;
        private System.Windows.Forms.TextBox nome_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView lv_usuario;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader cpf;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader senha;
        private System.Windows.Forms.ColumnHeader funcao;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MaskedTextBox cpf_usuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}