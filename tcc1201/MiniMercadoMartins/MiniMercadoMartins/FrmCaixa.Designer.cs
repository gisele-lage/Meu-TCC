namespace MiniMercadoMartins
{
    partial class FrmCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaixa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCarrinho = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.carrinhoControl21 = new MiniMercadoMartins.carrinhoControl2();
            this.alterarDadosControl11 = new MiniMercadoMartins.AlterarDadosControl1();
            this.cadastrarClienteControl11 = new MiniMercadoMartins.CadastrarClienteControl1();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnCarrinho);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 418);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(33, 338);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(91, 23);
            this.btnVoltar.TabIndex = 36;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(12, 240);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(138, 41);
            this.btnAlterar.TabIndex = 35;
            this.btnAlterar.Text = "Alterar Dados do Cliente";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(12, 157);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(138, 41);
            this.btnCadastrar.TabIndex = 34;
            this.btnCadastrar.Text = "Cadastrar Cliente";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrinho.Location = new System.Drawing.Point(12, 71);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(138, 41);
            this.btnCarrinho.TabIndex = 33;
            this.btnCarrinho.Text = "Carrinho";
            this.btnCarrinho.UseVisualStyleBackColor = true;
            this.btnCarrinho.Click += new System.EventHandler(this.button10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Menu";
            // 
            // carrinhoControl21
            // 
            this.carrinhoControl21.BackColor = System.Drawing.Color.SlateGray;
            this.carrinhoControl21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carrinhoControl21.Location = new System.Drawing.Point(159, 0);
            this.carrinhoControl21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.carrinhoControl21.Name = "carrinhoControl21";
            this.carrinhoControl21.Size = new System.Drawing.Size(715, 418);
            this.carrinhoControl21.TabIndex = 9;
            // 
            // alterarDadosControl11
            // 
            this.alterarDadosControl11.BackColor = System.Drawing.Color.SlateGray;
            this.alterarDadosControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alterarDadosControl11.Location = new System.Drawing.Point(159, 0);
            this.alterarDadosControl11.Name = "alterarDadosControl11";
            this.alterarDadosControl11.Size = new System.Drawing.Size(715, 418);
            this.alterarDadosControl11.TabIndex = 8;
            this.alterarDadosControl11.Load += new System.EventHandler(this.alterarDadosControl11_Load_1);
            // 
            // cadastrarClienteControl11
            // 
            this.cadastrarClienteControl11.BackColor = System.Drawing.Color.SlateGray;
            this.cadastrarClienteControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadastrarClienteControl11.Location = new System.Drawing.Point(159, 0);
            this.cadastrarClienteControl11.Name = "cadastrarClienteControl11";
            this.cadastrarClienteControl11.Size = new System.Drawing.Size(715, 418);
            this.cadastrarClienteControl11.TabIndex = 7;
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 418);
            this.Controls.Add(this.carrinhoControl21);
            this.Controls.Add(this.alterarDadosControl11);
            this.Controls.Add(this.cadastrarClienteControl11);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCaixa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCarrinho;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private CadastrarClienteControl1 cadastrarClienteControl11;
        private AlterarDadosControl1 alterarDadosControl11;
        private System.Windows.Forms.Button btnVoltar;
        private carrinhoControl2 carrinhoControl21;
    }
}