namespace MiniMercadoMartins
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.cbcargo = new System.Windows.Forms.ComboBox();
            this.pemail = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.psenha = new System.Windows.Forms.Panel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.pictureimagem = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureimagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbcargo
            // 
            this.cbcargo.BackColor = System.Drawing.Color.White;
            this.cbcargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcargo.FormattingEnabled = true;
            this.cbcargo.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Estoquista",
            "Caixa"});
            this.cbcargo.Location = new System.Drawing.Point(88, 185);
            this.cbcargo.Name = "cbcargo";
            this.cbcargo.Size = new System.Drawing.Size(121, 21);
            this.cbcargo.TabIndex = 2;
            this.cbcargo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pemail
            // 
            this.pemail.BackColor = System.Drawing.Color.Black;
            this.pemail.Location = new System.Drawing.Point(59, 310);
            this.pemail.Name = "pemail";
            this.pemail.Size = new System.Drawing.Size(196, 1);
            this.pemail.TabIndex = 3;
            this.pemail.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(159)))), ((int)(((byte)(173)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(59, 288);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(159)))), ((int)(((byte)(173)))));
            this.lblemail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(61)))), ((int)(((byte)(109)))));
            this.lblemail.Location = new System.Drawing.Point(56, 258);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(45, 16);
            this.lblemail.TabIndex = 5;
            this.lblemail.Text = "E-mail";
            this.lblemail.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(159)))), ((int)(((byte)(173)))));
            this.lblsenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(61)))), ((int)(((byte)(109)))));
            this.lblsenha.Location = new System.Drawing.Point(56, 362);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(45, 16);
            this.lblsenha.TabIndex = 8;
            this.lblsenha.Text = "Senha";
            this.lblsenha.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(159)))), ((int)(((byte)(173)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(59, 390);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(196, 18);
            this.txtSenha.TabIndex = 7;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // psenha
            // 
            this.psenha.BackColor = System.Drawing.Color.Black;
            this.psenha.Location = new System.Drawing.Point(59, 414);
            this.psenha.Name = "psenha";
            this.psenha.Size = new System.Drawing.Size(196, 1);
            this.psenha.TabIndex = 6;
            this.psenha.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(88, 458);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(121, 31);
            this.btnEntrar.TabIndex = 34;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click_1);
            // 
            // cbOpcoes
            // 
            this.cbOpcoes.BackColor = System.Drawing.Color.White;
            this.cbOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcoes.FormattingEnabled = true;
            this.cbOpcoes.Items.AddRange(new object[] {
            "Gerenciar Fornecedor",
            "Consultar Dados",
            "Alterar Preço de Produto"});
            this.cbOpcoes.Location = new System.Drawing.Point(88, 212);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(121, 21);
            this.cbOpcoes.TabIndex = 35;
            // 
            // pictureimagem
            // 
            this.pictureimagem.Image = global::MiniMercadoMartins.Properties.Resources.imagemcaixa3;
            this.pictureimagem.Location = new System.Drawing.Point(56, 258);
            this.pictureimagem.Name = "pictureimagem";
            this.pictureimagem.Size = new System.Drawing.Size(196, 161);
            this.pictureimagem.TabIndex = 14;
            this.pictureimagem.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniMercadoMartins.Properties.Resources.tcc3;
            this.pictureBox1.Location = new System.Drawing.Point(76, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 135);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(159)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(310, 533);
            this.Controls.Add(this.cbOpcoes);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.pictureimagem);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.psenha);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pemail);
            this.Controls.Add(this.cbcargo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureimagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbcargo;
        private System.Windows.Forms.Panel pemail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel psenha;
        private System.Windows.Forms.PictureBox pictureimagem;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.ComboBox cbOpcoes;
    }
}

