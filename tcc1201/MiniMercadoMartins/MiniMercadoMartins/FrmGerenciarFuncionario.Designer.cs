namespace MiniMercadoMartins
{
    partial class FrmGerenciarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerenciarFuncionario));
            this.lblVoltar = new System.Windows.Forms.Label();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.consultarFuncionarioControl11 = new MiniMercadoMartins.ConsultarFuncionarioControl1();
            this.alterarDadosFuncionarioControl11 = new MiniMercadoMartins.AlterarDadosFuncionarioControl1();
            this.cadastrarFuncionarioControl11 = new MiniMercadoMartins.CadastrarFuncionarioControl1();
            this.panelBarra.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVoltar.Location = new System.Drawing.Point(64, 0);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(0, 19);
            this.lblVoltar.TabIndex = 2;
            this.lblVoltar.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(2)))), ((int)(((byte)(41)))));
            this.panelBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarra.Controls.Add(this.btnVoltar);
            this.panelBarra.Controls.Add(this.panelMenu);
            this.panelBarra.Controls.Add(this.pictureBox1);
            this.panelBarra.Controls.Add(this.lblVoltar);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(162, 513);
            this.panelBarra.TabIndex = 5;
            this.panelBarra.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(33, 451);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(91, 26);
            this.btnVoltar.TabIndex = 37;
            this.btnVoltar.Text = "Voltar ao login";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnConsultar);
            this.panelMenu.Controls.Add(this.btnCadastrar);
            this.panelMenu.Controls.Add(this.btnAlterar);
            this.panelMenu.Location = new System.Drawing.Point(1, 73);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(154, 353);
            this.panelMenu.TabIndex = 6;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(19, 230);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(115, 41);
            this.btnConsultar.TabIndex = 36;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(19, 36);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(115, 41);
            this.btnCadastrar.TabIndex = 34;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(19, 134);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(115, 41);
            this.btnAlterar.TabIndex = 35;
            this.btnAlterar.Text = "Alterar Dados";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniMercadoMartins.Properties.Resources.menu;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 19);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // consultarFuncionarioControl11
            // 
            this.consultarFuncionarioControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.consultarFuncionarioControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consultarFuncionarioControl11.Location = new System.Drawing.Point(162, 0);
            this.consultarFuncionarioControl11.Name = "consultarFuncionarioControl11";
            this.consultarFuncionarioControl11.Size = new System.Drawing.Size(620, 513);
            this.consultarFuncionarioControl11.TabIndex = 8;
            // 
            // alterarDadosFuncionarioControl11
            // 
            this.alterarDadosFuncionarioControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.alterarDadosFuncionarioControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alterarDadosFuncionarioControl11.Location = new System.Drawing.Point(162, 0);
            this.alterarDadosFuncionarioControl11.Name = "alterarDadosFuncionarioControl11";
            this.alterarDadosFuncionarioControl11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.alterarDadosFuncionarioControl11.Size = new System.Drawing.Size(620, 513);
            this.alterarDadosFuncionarioControl11.TabIndex = 7;
            // 
            // cadastrarFuncionarioControl11
            // 
            this.cadastrarFuncionarioControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.cadastrarFuncionarioControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadastrarFuncionarioControl11.Location = new System.Drawing.Point(162, 0);
            this.cadastrarFuncionarioControl11.Name = "cadastrarFuncionarioControl11";
            this.cadastrarFuncionarioControl11.Size = new System.Drawing.Size(620, 513);
            this.cadastrarFuncionarioControl11.TabIndex = 6;
            // 
            // FrmGerenciarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(782, 513);
            this.Controls.Add(this.consultarFuncionarioControl11);
            this.Controls.Add(this.alterarDadosFuncionarioControl11);
            this.Controls.Add(this.cadastrarFuncionarioControl11);
            this.Controls.Add(this.panelBarra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGerenciarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmGerenciarFuncionario_Load);
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlterar;
        private CadastrarFuncionarioControl1 cadastrarFuncionarioControl11;
        private AlterarDadosFuncionarioControl1 alterarDadosFuncionarioControl11;
        private ConsultarFuncionarioControl1 consultarFuncionarioControl11;
        private System.Windows.Forms.Button btnVoltar;
    }
}