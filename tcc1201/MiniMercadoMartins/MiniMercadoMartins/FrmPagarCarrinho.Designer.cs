namespace MiniMercadoMartins
{
    partial class FrmPagarCarrinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagarCarrinho));
            this.lblCpf = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOpcao = new System.Windows.Forms.Label();
            this.cbpcao = new System.Windows.Forms.ComboBox();
            this.btnTroco = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblTroco = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorRecebido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValorDesc = new System.Windows.Forms.Label();
            this.lblValorcDesc = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblValorSDesc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.Color.White;
            this.lblCpf.Location = new System.Drawing.Point(31, 11);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(200, 24);
            this.lblCpf.TabIndex = 53;
            this.lblCpf.Text = "Finalizar Pagamento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOpcao);
            this.groupBox1.Controls.Add(this.cbpcao);
            this.groupBox1.Controls.Add(this.btnTroco);
            this.groupBox1.Controls.Add(this.btnPagar);
            this.groupBox1.Controls.Add(this.lblTroco);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtValorRecebido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbFormaPagamento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblValorDesc);
            this.groupBox1.Controls.Add(this.lblValorcDesc);
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.lblValorSDesc);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 304);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // lblOpcao
            // 
            this.lblOpcao.AutoSize = true;
            this.lblOpcao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcao.ForeColor = System.Drawing.Color.White;
            this.lblOpcao.Location = new System.Drawing.Point(367, 106);
            this.lblOpcao.Name = "lblOpcao";
            this.lblOpcao.Size = new System.Drawing.Size(141, 18);
            this.lblOpcao.TabIndex = 74;
            this.lblOpcao.Text = "Credito ou Debito?";
            // 
            // cbpcao
            // 
            this.cbpcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpcao.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbpcao.FormattingEnabled = true;
            this.cbpcao.Items.AddRange(new object[] {
            "Debido",
            "Credito"});
            this.cbpcao.Location = new System.Drawing.Point(370, 127);
            this.cbpcao.Name = "cbpcao";
            this.cbpcao.Size = new System.Drawing.Size(158, 22);
            this.cbpcao.TabIndex = 73;
            // 
            // btnTroco
            // 
            this.btnTroco.Location = new System.Drawing.Point(336, 181);
            this.btnTroco.Name = "btnTroco";
            this.btnTroco.Size = new System.Drawing.Size(99, 23);
            this.btnTroco.TabIndex = 72;
            this.btnTroco.Text = "Calcular Troco";
            this.btnTroco.UseVisualStyleBackColor = true;
            this.btnTroco.Click += new System.EventHandler(this.btnTroco_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(406, 266);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(122, 23);
            this.btnPagar.TabIndex = 71;
            this.btnPagar.Text = "Finalizar Pagamento";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.Color.White;
            this.lblTroco.Location = new System.Drawing.Point(84, 238);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(0, 18);
            this.lblTroco.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 69;
            this.label3.Text = "Troco:";
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.ForeColor = System.Drawing.Color.Black;
            this.txtValorRecebido.Location = new System.Drawing.Point(151, 179);
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Size = new System.Drawing.Size(158, 20);
            this.txtValorRecebido.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 67;
            this.label2.Text = "Valor Recebido:";
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPagamento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Items.AddRange(new object[] {
            "Cartao",
            "Dinheiro"});
            this.cbFormaPagamento.Location = new System.Drawing.Point(187, 127);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(158, 22);
            this.cbFormaPagamento.TabIndex = 66;
            this.cbFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.cbFormaPagamento_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 65;
            this.label1.Text = "Forma de Pagamento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblValorDesc
            // 
            this.lblValorDesc.AutoSize = true;
            this.lblValorDesc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDesc.ForeColor = System.Drawing.Color.White;
            this.lblValorDesc.Location = new System.Drawing.Point(184, 80);
            this.lblValorDesc.Name = "lblValorDesc";
            this.lblValorDesc.Size = new System.Drawing.Size(0, 18);
            this.lblValorDesc.TabIndex = 64;
            // 
            // lblValorcDesc
            // 
            this.lblValorcDesc.AutoSize = true;
            this.lblValorcDesc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorcDesc.ForeColor = System.Drawing.Color.White;
            this.lblValorcDesc.Location = new System.Drawing.Point(19, 80);
            this.lblValorcDesc.Name = "lblValorcDesc";
            this.lblValorcDesc.Size = new System.Drawing.Size(146, 18);
            this.lblValorcDesc.TabIndex = 63;
            this.lblValorcDesc.Text = "Total com desconto:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(184, 30);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(0, 18);
            this.lblValor.TabIndex = 62;
            // 
            // lblValorSDesc
            // 
            this.lblValorSDesc.AutoSize = true;
            this.lblValorSDesc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorSDesc.ForeColor = System.Drawing.Color.White;
            this.lblValorSDesc.Location = new System.Drawing.Point(19, 30);
            this.lblValorSDesc.Name = "lblValorSDesc";
            this.lblValorSDesc.Size = new System.Drawing.Size(146, 18);
            this.lblValorSDesc.TabIndex = 61;
            this.lblValorSDesc.Text = "Total sem desconto:";
            // 
            // FrmPagarCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(558, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCpf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPagarCarrinho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPagarCarrinho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorDesc;
        private System.Windows.Forms.Label lblValorcDesc;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblValorSDesc;
        private System.Windows.Forms.TextBox txtValorRecebido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTroco;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbpcao;
        private System.Windows.Forms.Label lblOpcao;
    }
}