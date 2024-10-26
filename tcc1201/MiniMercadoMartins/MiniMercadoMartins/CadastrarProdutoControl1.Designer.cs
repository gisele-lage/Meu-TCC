namespace MiniMercadoMartins
{
    partial class CadastrarProdutoControl1
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbUnidade = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLucro = new System.Windows.Forms.TextBox();
            this.txtCustoU = new System.Windows.Forms.TextBox();
            this.lblValorV = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCustoE = new System.Windows.Forms.TextBox();
            this.lblCusto = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtQntd = new System.Windows.Forms.TextBox();
            this.lblEstoqueMax = new System.Windows.Forms.Label();
            this.lblEstoqueMin = new System.Windows.Forms.Label();
            this.txtDataV = new System.Windows.Forms.TextBox();
            this.lblDataV = new System.Windows.Forms.Label();
            this.txtDatatF = new System.Windows.Forms.TextBox();
            this.lblDataF = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtSabor = new System.Windows.Forms.TextBox();
            this.lblSabor = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtEstoqueMax = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtEstoqueMin = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbUnidade);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtCustoU);
            this.groupBox1.Controls.Add(this.lblValorV);
            this.groupBox1.Controls.Add(this.lblUnidade);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.lblPreco);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtCustoE);
            this.groupBox1.Controls.Add(this.lblCusto);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.txtQntd);
            this.groupBox1.Controls.Add(this.lblEstoqueMax);
            this.groupBox1.Controls.Add(this.lblEstoqueMin);
            this.groupBox1.Controls.Add(this.txtDataV);
            this.groupBox1.Controls.Add(this.lblDataV);
            this.groupBox1.Controls.Add(this.txtDatatF);
            this.groupBox1.Controls.Add(this.lblDataF);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.lblDescricao);
            this.groupBox1.Controls.Add(this.txtCnpj);
            this.groupBox1.Controls.Add(this.lblCnpj);
            this.groupBox1.Controls.Add(this.txtSabor);
            this.groupBox1.Controls.Add(this.lblSabor);
            this.groupBox1.Controls.Add(this.lblCategoria);
            this.groupBox1.Controls.Add(this.txtEstoqueMax);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.txtEstoqueMin);
            this.groupBox1.Controls.Add(this.txtCod);
            this.groupBox1.Controls.Add(this.lblCod);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Location = new System.Drawing.Point(8, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 391);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbUnidade
            // 
            this.cbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidade.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidade.FormattingEnabled = true;
            this.cbUnidade.Items.AddRange(new object[] {
            "Litro",
            "Mililitro",
            "Grama",
            "Quilograma"});
            this.cbUnidade.Location = new System.Drawing.Point(601, 191);
            this.cbUnidade.Name = "cbUnidade";
            this.cbUnidade.Size = new System.Drawing.Size(122, 22);
            this.cbUnidade.TabIndex = 60;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLucro);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(394, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 53);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adicionar Lucro";
            // 
            // txtLucro
            // 
            this.txtLucro.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLucro.Location = new System.Drawing.Point(12, 22);
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.Size = new System.Drawing.Size(122, 20);
            this.txtLucro.TabIndex = 42;
            this.txtLucro.TextChanged += new System.EventHandler(this.txtLucro_TextChanged);
            // 
            // txtCustoU
            // 
            this.txtCustoU.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoU.Location = new System.Drawing.Point(209, 275);
            this.txtCustoU.Name = "txtCustoU";
            this.txtCustoU.Size = new System.Drawing.Size(122, 20);
            this.txtCustoU.TabIndex = 58;
            // 
            // lblValorV
            // 
            this.lblValorV.AutoSize = true;
            this.lblValorV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorV.ForeColor = System.Drawing.Color.White;
            this.lblValorV.Location = new System.Drawing.Point(206, 253);
            this.lblValorV.Name = "lblValorV";
            this.lblValorV.Size = new System.Drawing.Size(142, 18);
            this.lblValorV.TabIndex = 57;
            this.lblValorV.Text = "Valor de Custo/Unit";
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.ForeColor = System.Drawing.Color.White;
            this.lblUnidade.Location = new System.Drawing.Point(598, 170);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(67, 18);
            this.lblUnidade.TabIndex = 53;
            this.lblUnidade.Text = "Unidade";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(601, 276);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(91, 23);
            this.btnCalcular.TabIndex = 50;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(559, 354);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 23);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(663, 354);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(91, 23);
            this.btnCadastrar.TabIndex = 48;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(9, 346);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(122, 20);
            this.txtPreco.TabIndex = 47;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.White;
            this.lblPreco.Location = new System.Drawing.Point(6, 325);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(108, 18);
            this.lblPreco.TabIndex = 46;
            this.lblPreco.Text = "Preço Unitario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 1);
            this.panel1.TabIndex = 45;
            // 
            // txtCustoE
            // 
            this.txtCustoE.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoE.Location = new System.Drawing.Point(9, 276);
            this.txtCustoE.Name = "txtCustoE";
            this.txtCustoE.Size = new System.Drawing.Size(122, 20);
            this.txtCustoE.TabIndex = 40;
            this.txtCustoE.TextChanged += new System.EventHandler(this.txtCustoE_TextChanged);
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusto.ForeColor = System.Drawing.Color.White;
            this.lblCusto.Location = new System.Drawing.Point(6, 253);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(156, 18);
            this.lblCusto.TabIndex = 39;
            this.lblCusto.Text = "Valor de Custo/Estoq";
            this.lblCusto.Click += new System.EventHandler(this.lblCusto_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(406, 191);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(122, 20);
            this.txtMarca.TabIndex = 38;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // txtQntd
            // 
            this.txtQntd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQntd.Location = new System.Drawing.Point(601, 219);
            this.txtQntd.Name = "txtQntd";
            this.txtQntd.Size = new System.Drawing.Size(122, 20);
            this.txtQntd.TabIndex = 37;
            this.txtQntd.TextChanged += new System.EventHandler(this.txtQntd_TextChanged);
            // 
            // lblEstoqueMax
            // 
            this.lblEstoqueMax.AutoSize = true;
            this.lblEstoqueMax.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoqueMax.ForeColor = System.Drawing.Color.White;
            this.lblEstoqueMax.Location = new System.Drawing.Point(598, 16);
            this.lblEstoqueMax.Name = "lblEstoqueMax";
            this.lblEstoqueMax.Size = new System.Drawing.Size(125, 18);
            this.lblEstoqueMax.TabIndex = 36;
            this.lblEstoqueMax.Text = "Estoque Maximo";
            // 
            // lblEstoqueMin
            // 
            this.lblEstoqueMin.AutoSize = true;
            this.lblEstoqueMin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoqueMin.ForeColor = System.Drawing.Color.White;
            this.lblEstoqueMin.Location = new System.Drawing.Point(403, 16);
            this.lblEstoqueMin.Name = "lblEstoqueMin";
            this.lblEstoqueMin.Size = new System.Drawing.Size(121, 18);
            this.lblEstoqueMin.TabIndex = 35;
            this.lblEstoqueMin.Text = "Estoque Minimo";
            // 
            // txtDataV
            // 
            this.txtDataV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataV.Location = new System.Drawing.Point(209, 191);
            this.txtDataV.MaxLength = 10;
            this.txtDataV.Name = "txtDataV";
            this.txtDataV.Size = new System.Drawing.Size(122, 20);
            this.txtDataV.TabIndex = 34;
            // 
            // lblDataV
            // 
            this.lblDataV.AutoSize = true;
            this.lblDataV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataV.ForeColor = System.Drawing.Color.White;
            this.lblDataV.Location = new System.Drawing.Point(206, 170);
            this.lblDataV.Name = "lblDataV";
            this.lblDataV.Size = new System.Drawing.Size(130, 18);
            this.lblDataV.TabIndex = 33;
            this.lblDataV.Text = "Data de Validade";
            // 
            // txtDatatF
            // 
            this.txtDatatF.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatatF.Location = new System.Drawing.Point(9, 191);
            this.txtDatatF.MaxLength = 10;
            this.txtDatatF.Name = "txtDatatF";
            this.txtDatatF.Size = new System.Drawing.Size(122, 20);
            this.txtDatatF.TabIndex = 32;
            // 
            // lblDataF
            // 
            this.lblDataF.AutoSize = true;
            this.lblDataF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataF.ForeColor = System.Drawing.Color.White;
            this.lblDataF.Location = new System.Drawing.Point(6, 170);
            this.lblDataF.Name = "lblDataF";
            this.lblDataF.Size = new System.Drawing.Size(148, 18);
            this.lblDataF.TabIndex = 31;
            this.lblDataF.Text = "Data de Fabricaçao";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "HortiFruti",
            "Limpeza",
            "Higiene",
            "Alimentos Pereciveis",
            "Alimentos Nao Pereciveis",
            "Bebidas e Sucos"});
            this.cbCategoria.Location = new System.Drawing.Point(9, 109);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(122, 22);
            this.cbCategoria.TabIndex = 30;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(406, 111);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(122, 20);
            this.txtDescricao.TabIndex = 29;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(403, 88);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 18);
            this.lblDescricao.TabIndex = 28;
            this.lblDescricao.Text = "Descriçao";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(601, 111);
            this.txtCnpj.MaxLength = 16;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(122, 20);
            this.txtCnpj.TabIndex = 27;
            this.txtCnpj.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.ForeColor = System.Drawing.Color.White;
            this.lblCnpj.Location = new System.Drawing.Point(598, 88);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(157, 18);
            this.lblCnpj.TabIndex = 26;
            this.lblCnpj.Text = "CNPJ do Fornecedor";
            // 
            // txtSabor
            // 
            this.txtSabor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSabor.Location = new System.Drawing.Point(209, 111);
            this.txtSabor.Name = "txtSabor";
            this.txtSabor.Size = new System.Drawing.Size(122, 20);
            this.txtSabor.TabIndex = 25;
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabor.ForeColor = System.Drawing.Color.White;
            this.lblSabor.Location = new System.Drawing.Point(206, 88);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(51, 18);
            this.lblSabor.TabIndex = 24;
            this.lblSabor.Text = "Sabor";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(6, 88);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(78, 18);
            this.lblCategoria.TabIndex = 22;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtEstoqueMax
            // 
            this.txtEstoqueMax.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueMax.Location = new System.Drawing.Point(601, 37);
            this.txtEstoqueMax.Name = "txtEstoqueMax";
            this.txtEstoqueMax.Size = new System.Drawing.Size(122, 20);
            this.txtEstoqueMax.TabIndex = 21;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(403, 170);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(52, 18);
            this.lblMarca.TabIndex = 20;
            this.lblMarca.Text = "Marca";
            this.lblMarca.Click += new System.EventHandler(this.lblMarca_Click);
            // 
            // txtEstoqueMin
            // 
            this.txtEstoqueMin.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueMin.Location = new System.Drawing.Point(406, 37);
            this.txtEstoqueMin.Name = "txtEstoqueMin";
            this.txtEstoqueMin.Size = new System.Drawing.Size(122, 20);
            this.txtEstoqueMin.TabIndex = 19;
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(209, 37);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(122, 20);
            this.txtCod.TabIndex = 17;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.ForeColor = System.Drawing.Color.White;
            this.lblCod.Location = new System.Drawing.Point(206, 16);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(60, 18);
            this.lblCod.TabIndex = 16;
            this.lblCod.Text = "Codigo";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(9, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(122, 20);
            this.txtNome.TabIndex = 15;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(6, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 18);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome";
            // 
            // CadastrarProdutoControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarProdutoControl1";
            this.Size = new System.Drawing.Size(782, 452);
            this.Load += new System.EventHandler(this.CadastrarProdutoControl1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtEstoqueMin;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtEstoqueMax;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtSabor;
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblEstoqueMin;
        private System.Windows.Forms.TextBox txtDataV;
        private System.Windows.Forms.Label lblDataV;
        private System.Windows.Forms.TextBox txtDatatF;
        private System.Windows.Forms.Label lblDataF;
        private System.Windows.Forms.Label lblEstoqueMax;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtQntd;
        private System.Windows.Forms.TextBox txtCustoE;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLucro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.TextBox txtCustoU;
        private System.Windows.Forms.Label lblValorV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbUnidade;
    }
}
