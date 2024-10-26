namespace MiniMercadoMartins
{
    partial class FrmGerenciarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerenciarProduto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.pictureBaixo = new System.Windows.Forms.PictureBox();
            this.pictureCima = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.consultarProdutoControl11 = new MiniMercadoMartins.ConsultarProdutoControl1();
            this.alterarDadosProdutoControl11 = new MiniMercadoMartins.AlterarDadosProdutoControl1();
            this.cadastrarProdutoControl11 = new MiniMercadoMartins.CadastrarProdutoControl1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBaixo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCima)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Controls.Add(this.lblVoltar);
            this.panel1.Controls.Add(this.pictureBaixo);
            this.panel1.Controls.Add(this.pictureCima);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 88);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMenu.Location = new System.Drawing.Point(670, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(0, 19);
            this.lblMenu.TabIndex = 4;
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVoltar.Location = new System.Drawing.Point(670, 0);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(0, 19);
            this.lblVoltar.TabIndex = 3;
            // 
            // pictureBaixo
            // 
            this.pictureBaixo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(107)))));
            this.pictureBaixo.Image = global::MiniMercadoMartins.Properties.Resources.SetaBaixo1;
            this.pictureBaixo.Location = new System.Drawing.Point(750, 0);
            this.pictureBaixo.Name = "pictureBaixo";
            this.pictureBaixo.Size = new System.Drawing.Size(29, 18);
            this.pictureBaixo.TabIndex = 1;
            this.pictureBaixo.TabStop = false;
            this.pictureBaixo.Click += new System.EventHandler(this.pictureBaixo_Click);
            // 
            // pictureCima
            // 
            this.pictureCima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(107)))));
            this.pictureCima.Image = global::MiniMercadoMartins.Properties.Resources.SetaCima;
            this.pictureCima.Location = new System.Drawing.Point(750, 0);
            this.pictureCima.Name = "pictureCima";
            this.pictureCima.Size = new System.Drawing.Size(29, 18);
            this.pictureCima.TabIndex = 2;
            this.pictureCima.TabStop = false;
            this.pictureCima.Click += new System.EventHandler(this.pictureCima_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(107)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.btnVoltar);
            this.panel2.Controls.Add(this.btnConsultar);
            this.panel2.Controls.Add(this.btnAlterar);
            this.panel2.Controls.Add(this.btnCadastrar);
            this.panel2.Location = new System.Drawing.Point(12, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 56);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(662, 19);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(91, 26);
            this.btnVoltar.TabIndex = 38;
            this.btnVoltar.Text = "Voltar ao login";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(543, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(115, 41);
            this.btnConsultar.TabIndex = 37;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(341, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(115, 41);
            this.btnAlterar.TabIndex = 36;
            this.btnAlterar.Text = "Alterar Dados";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(116, 12);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(115, 41);
            this.btnCadastrar.TabIndex = 35;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // consultarProdutoControl11
            // 
            this.consultarProdutoControl11.BackColor = System.Drawing.Color.Gray;
            this.consultarProdutoControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consultarProdutoControl11.Location = new System.Drawing.Point(0, 88);
            this.consultarProdutoControl11.Name = "consultarProdutoControl11";
            this.consultarProdutoControl11.Size = new System.Drawing.Size(782, 401);
            this.consultarProdutoControl11.TabIndex = 3;
            // 
            // alterarDadosProdutoControl11
            // 
            this.alterarDadosProdutoControl11.BackColor = System.Drawing.Color.Gray;
            this.alterarDadosProdutoControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alterarDadosProdutoControl11.Location = new System.Drawing.Point(0, 88);
            this.alterarDadosProdutoControl11.Name = "alterarDadosProdutoControl11";
            this.alterarDadosProdutoControl11.Size = new System.Drawing.Size(782, 401);
            this.alterarDadosProdutoControl11.TabIndex = 2;
            // 
            // cadastrarProdutoControl11
            // 
            this.cadastrarProdutoControl11.BackColor = System.Drawing.Color.Gray;
            this.cadastrarProdutoControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadastrarProdutoControl11.Location = new System.Drawing.Point(0, 88);
            this.cadastrarProdutoControl11.Name = "cadastrarProdutoControl11";
            this.cadastrarProdutoControl11.Size = new System.Drawing.Size(782, 401);
            this.cadastrarProdutoControl11.TabIndex = 1;
            this.cadastrarProdutoControl11.Load += new System.EventHandler(this.cadastrarProdutoControl11_Load);
            // 
            // FrmGerenciarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(782, 489);
            this.Controls.Add(this.consultarProdutoControl11);
            this.Controls.Add(this.alterarDadosProdutoControl11);
            this.Controls.Add(this.cadastrarProdutoControl11);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGerenciarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmGerenciarProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBaixo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCima)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.PictureBox pictureBaixo;
        private System.Windows.Forms.PictureBox pictureCima;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.Label lblMenu;
        private CadastrarProdutoControl1 cadastrarProdutoControl11;
        private AlterarDadosProdutoControl1 alterarDadosProdutoControl11;
        private ConsultarProdutoControl1 consultarProdutoControl11;
        private System.Windows.Forms.Button btnVoltar;
    }
}