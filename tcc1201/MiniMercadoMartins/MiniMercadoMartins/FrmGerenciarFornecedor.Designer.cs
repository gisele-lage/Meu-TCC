namespace MiniMercadoMartins
{
    partial class FrmGerenciarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerenciarFornecedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureCima = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.pictureBaixo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.consultarDadosFornecedorControl11 = new MiniMercadoMartins.ConsultarDadosFornecedorControl1();
            this.alterarDadosFornecedorControl11 = new MiniMercadoMartins.AlterarDadosFornecedorControl1();
            this.cadastrarFornecedorControl11 = new MiniMercadoMartins.CadastrarFornecedorControl1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBaixo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.pictureCima);
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Controls.Add(this.lblVoltar);
            this.panel1.Controls.Add(this.pictureBaixo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 88);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureCima
            // 
            this.pictureCima.BackColor = System.Drawing.Color.DarkGray;
            this.pictureCima.Image = global::MiniMercadoMartins.Properties.Resources.SetaBaixo2;
            this.pictureCima.Location = new System.Drawing.Point(750, 1);
            this.pictureCima.Name = "pictureCima";
            this.pictureCima.Size = new System.Drawing.Size(29, 19);
            this.pictureCima.TabIndex = 1;
            this.pictureCima.TabStop = false;
            this.pictureCima.Click += new System.EventHandler(this.pictureCima_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(693, 1);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(0, 18);
            this.lblMenu.TabIndex = 3;
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltar.ForeColor = System.Drawing.Color.White;
            this.lblVoltar.Location = new System.Drawing.Point(693, 1);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(0, 18);
            this.lblVoltar.TabIndex = 2;
            // 
            // pictureBaixo
            // 
            this.pictureBaixo.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBaixo.Image = global::MiniMercadoMartins.Properties.Resources.SetaCima2;
            this.pictureBaixo.Location = new System.Drawing.Point(750, 0);
            this.pictureBaixo.Name = "pictureBaixo";
            this.pictureBaixo.Size = new System.Drawing.Size(29, 19);
            this.pictureBaixo.TabIndex = 2;
            this.pictureBaixo.TabStop = false;
            this.pictureBaixo.Click += new System.EventHandler(this.pictureBaixo1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.panel2.Controls.Add(this.btnVoltar);
            this.panel2.Controls.Add(this.btnConsultar);
            this.panel2.Controls.Add(this.btnAlterar);
            this.panel2.Controls.Add(this.btnCadastrar);
            this.panel2.Location = new System.Drawing.Point(66, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 53);
            this.panel2.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(555, 16);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(91, 26);
            this.btnVoltar.TabIndex = 39;
            this.btnVoltar.Text = "Voltar ao login";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(424, 9);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(115, 41);
            this.btnConsultar.TabIndex = 38;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(239, 9);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(115, 41);
            this.btnAlterar.TabIndex = 37;
            this.btnAlterar.Text = "Alterar Dados";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(63, 9);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(115, 41);
            this.btnCadastrar.TabIndex = 36;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // consultarDadosFornecedorControl11
            // 
            this.consultarDadosFornecedorControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.consultarDadosFornecedorControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consultarDadosFornecedorControl11.Location = new System.Drawing.Point(0, 88);
            this.consultarDadosFornecedorControl11.Name = "consultarDadosFornecedorControl11";
            this.consultarDadosFornecedorControl11.Size = new System.Drawing.Size(782, 269);
            this.consultarDadosFornecedorControl11.TabIndex = 3;
            // 
            // alterarDadosFornecedorControl11
            // 
            this.alterarDadosFornecedorControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.alterarDadosFornecedorControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alterarDadosFornecedorControl11.Location = new System.Drawing.Point(0, 88);
            this.alterarDadosFornecedorControl11.Name = "alterarDadosFornecedorControl11";
            this.alterarDadosFornecedorControl11.Size = new System.Drawing.Size(782, 269);
            this.alterarDadosFornecedorControl11.TabIndex = 2;
            // 
            // cadastrarFornecedorControl11
            // 
            this.cadastrarFornecedorControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.cadastrarFornecedorControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadastrarFornecedorControl11.Location = new System.Drawing.Point(0, 88);
            this.cadastrarFornecedorControl11.Name = "cadastrarFornecedorControl11";
            this.cadastrarFornecedorControl11.Size = new System.Drawing.Size(782, 269);
            this.cadastrarFornecedorControl11.TabIndex = 1;
            this.cadastrarFornecedorControl11.Load += new System.EventHandler(this.cadastrarFornecedorControl11_Load);
            // 
            // FrmGerenciarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(782, 357);
            this.Controls.Add(this.consultarDadosFornecedorControl11);
            this.Controls.Add(this.alterarDadosFornecedorControl11);
            this.Controls.Add(this.cadastrarFornecedorControl11);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGerenciarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmTelaGerente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBaixo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.PictureBox pictureCima;
        private System.Windows.Forms.PictureBox pictureBaixo;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnVoltar;
        private CadastrarFornecedorControl1 cadastrarFornecedorControl11;
        private AlterarDadosFornecedorControl1 alterarDadosFornecedorControl11;
        private ConsultarDadosFornecedorControl1 consultarDadosFornecedorControl11;
    }
}