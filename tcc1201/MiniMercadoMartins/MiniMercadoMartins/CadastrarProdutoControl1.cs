using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MiniMercadoMartins
{
    public partial class CadastrarProdutoControl1 : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source = PAULO-PC;" + "Initial catalog = MiniMercadoMartins;" + "Integrated security = SSPI;");
        SqlCommand cmd = new SqlCommand();
        public CadastrarProdutoControl1()
        {
            InitializeComponent();
            cmd.Connection = conn;
        }

        private void CadastrarProdutoControl1_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQntd_TextChanged(object sender, EventArgs e)
        {
            if(txtQntd.Text != "" && txtCustoE.Text != "")
            {
                string qntd = txtQntd.Text;
                string custoE = txtCustoE.Text;

                double Quantidade = double.Parse(qntd);
                double CustoE = double.Parse(custoE);
                double CustoU;

                CustoU = CustoE / Quantidade;
                txtCustoU.Text = CustoU.ToString();


            }

            else
            {

            }
        }

        private void lblLucro_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
                if(txtLucro.Text == "")
                {
                  string custoU = txtCustoU.Text;
                double CustoU = double.Parse(custoU);
                 
                  double Preco;
                  Preco = CustoU;

                    txtPreco.Text = Preco.ToString();
                }

                else
                {
                   string custoU = txtCustoU.Text;
                   string lucro = txtLucro.Text;


                  double CustoU = double.Parse(custoU);
                   double Lucro = double.Parse(lucro);
                   double Preco;
                   Preco = CustoU + Lucro;
                    txtPreco.Text = Preco.ToString();
                }
            

           
            
            /* string custoE = txtCustoE.Text;
            string lucro = txtLucro.Text;
            string quantidade = txtQntd.Text;

            double Custo;
            double Lucro;
            double Despesa;
            double ValorVenda;
            double Quantidade;
            double preco;

            Custo = double.Parse(custo);
            Lucro = double.Parse(lucro);
            Despesa = double.Parse(despesa);
            Quantidade = double.Parse(quantidade);

            ValorVenda = Custo  + Lucro + Despesa;
            preco = ValorVenda / Quantidade;

            txtCustoU.Text = ValorVenda.ToString();
            txtPreco.Text = preco.ToString();*/




        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCnpj.Text = "";
            txtCod.Text = "";
            txtCustoE.Text = "";
            txtDatatF.Text = "";
            txtDataV.Text = "";
            txtDescricao.Text = "";
            txtEstoqueMax.Text = "";
            txtEstoqueMin.Text = "";
            txtLucro.Text = "";
            txtMarca.Text = "";
            txtNome.Text = "";
            txtPreco.Text = "";
            txtQntd.Text = "";
            txtSabor.Text = "";
            txtCustoU.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string estoqueMin = txtEstoqueMin.Text;
            string estoqueMax = txtEstoqueMax.Text;
            string qntd = txtQntd.Text;

            double EstoqueMin;
            double EstoqueMax;
            double Qntd;

            EstoqueMin = double.Parse(estoqueMin);
            EstoqueMax = double.Parse(estoqueMax);
            Qntd = double.Parse(qntd);

           // string cod = txtCod.Text;
            bool tem = false;

            cmd.CommandText = @"select Codigo from Produto where Codigo = '"+txtCod.Text+"'";
           // cmd.Parameters.AddWithValue("@cpf", cod);

            conn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            tem = rdr.HasRows;

            conn.Close();

            if (tem)
            {
                MessageBox.Show("Produto Existente");
            }
            else
            {
                if (Qntd < EstoqueMin || Qntd > EstoqueMax)
                {
                    MessageBox.Show("A quantidade de produtos inserida nao e permitida");
                }

                else
                {

                    if(txtLucro.Text == "")
                    {
                        cmd.CommandText = @"insert into Produto (Codigo, Nome, Categoria, Data_Fabricacao, Data_Validade, Sabor, Estoque_Min,
                                        Estoque_Max, Quantidade, Descricao, Marca, Custo_Estoque, Custo_Unitario,Lucro, Preco_Unitario, Unidade, Situacao)
                                  values (@cod, @nome, @cat, @dataF, @DataV, @sabor, @estoqueMin, @estoqueMax, @qntd, @descricao, @marca, @custoE,
                                             @custoU,'0', @preco, @unidade, 'Ativo');";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@cod", txtCod.Text);
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@cat", cbCategoria.Text);
                        cmd.Parameters.AddWithValue("@dataF", txtDatatF.Text);
                        cmd.Parameters.AddWithValue("@dataV", txtDataV.Text);
                        cmd.Parameters.AddWithValue("@sabor", txtSabor.Text);
                        cmd.Parameters.AddWithValue("@estoqueMin", double.Parse(txtEstoqueMin.Text));
                        cmd.Parameters.AddWithValue("@estoqueMax", double.Parse(txtEstoqueMax.Text));
                        cmd.Parameters.AddWithValue("@qntd", txtQntd.Text);
                        cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                        cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                        cmd.Parameters.AddWithValue("@custoE", double.Parse(txtCustoE.Text));
                        cmd.Parameters.AddWithValue("@custoU", double.Parse(txtCustoU.Text));
                        cmd.Parameters.AddWithValue("@preco", double.Parse(txtPreco.Text));
                        cmd.Parameters.AddWithValue("@unidade", cbUnidade.Text);


                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Cadastro realizado com sucesso!");
                    }

                    else
                    {
                        cmd.CommandText = @"insert into Produto (Codigo, Nome, Categoria, Data_Fabricacao, Data_Validade, Sabor, Estoque_Min,
                                        Estoque_Max, Quantidade, Descricao, Marca, Custo_Estoque, Custo_Unitario, Lucro, Preco_Unitario, Unidade, Situacao)
                                  values (@cod, @nome, @cat, @dataF, @DataV, @sabor, @estoqueMin, @estoqueMax, @qntd, @descricao, @marca, @custoE,
                                             @custoU, @lucro, @preco, @unidade, 'Ativo');";
                        cmd.Parameters.AddWithValue("@cod", txtCod.Text);
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@cat", cbCategoria.Text);
                        cmd.Parameters.AddWithValue("@dataF", txtDatatF.Text);
                        cmd.Parameters.AddWithValue("@dataV", txtDataV.Text);
                        cmd.Parameters.AddWithValue("@sabor", txtSabor.Text);
                        cmd.Parameters.AddWithValue("@estoqueMin", double.Parse(txtEstoqueMin.Text));
                        cmd.Parameters.AddWithValue("@estoqueMax", double.Parse(txtEstoqueMax.Text));
                        cmd.Parameters.AddWithValue("@qntd", txtQntd.Text);
                        cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                        cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                        cmd.Parameters.AddWithValue("@custoE", double.Parse(txtCustoE.Text));
                        cmd.Parameters.AddWithValue("@custoU", double.Parse(txtCustoU.Text));
                        cmd.Parameters.AddWithValue("@lucro", double.Parse(txtLucro.Text));
                        cmd.Parameters.AddWithValue("@preco", double.Parse(txtPreco.Text));
                        cmd.Parameters.AddWithValue("@unidade", cbUnidade.Text);


                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Cadastro realizado com sucesso!");
                    }
                  

                }
            }

           
        }

        private void lblCusto_Click(object sender, EventArgs e)
        {

        }

        private void txtLucro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustoE_TextChanged(object sender, EventArgs e)
        {
           
          
           
           

            if (txtCustoE.Text != "")
            {
                if(txtQntd.Text != "")
                {
                    string custoE = txtCustoE.Text;
                   double CustoE = double.Parse(custoE);
                    double CustoU;
                    string quantidade = txtQntd.Text;
                    double Quantidade = double.Parse(quantidade);
                    CustoU = CustoE / Quantidade;
                    txtCustoU.Text = CustoU.ToString();
                }
                else
                {

                }
              
            }
            else
            {
                txtCustoU.Text = "";
            }
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
