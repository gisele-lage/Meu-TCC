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
    public partial class AlterarDadosProdutoControl1 : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source = PAULO-PC;" + "Initial catalog = MiniMercadoMartins;" + "Integrated security = SSPI;");
        SqlCommand cmd = new SqlCommand();
        public AlterarDadosProdutoControl1()
        {
            InitializeComponent();
            cmd.Connection = conn;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string Cod = txtCod.Text;
            bool tem = false;

            cmd.CommandText = @"select Codigo from Produto where Codigo = '" + txtCod.Text + "'";

            conn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            tem = rdr.HasRows;

            conn.Close();

            if (tem)
            {
                

                cmd.CommandText = @"select  Nome, Categoria, Data_Fabricacao, Data_Validade, Sabor, Estoque_Min,
                                        Estoque_Max, Quantidade, Descricao, Marca, Custo_Estoque, Custo_Unitario, Lucro, Preco_Unitario, Situacao, 
                                         Unidade
                 from Produto where Codigo = '" + txtCod.Text + "'";

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        string nome = reader.GetString(0);
                        string cat = reader.GetString(1);
                        DateTime DataFabricacao = reader.GetDateTime(2);
                        string data = string.Format("{0: dd/MM/yyyy}", DataFabricacao);
                        DateTime DataValidade = reader.GetDateTime(3);
                        string data1 = string.Format("{0: dd/MM/yyyy}", DataValidade);
                        string sabor = reader.GetString(4);
                       double EstoqueMin = reader.GetDouble(5);
                       double EstoqueMax = reader.GetDouble(6);
                        double qntd = reader.GetDouble(7);
                        string desc = reader.GetString(8);
                        string marca = reader.GetString(9);
                        double custoE = reader.GetDouble(10);
                        double custoU = reader.GetDouble(11);
                        double lucro = reader.GetDouble(12);
                        double preco = reader.GetDouble(13);
                        string situacao = reader.GetString(14);
                        string unidade = reader.GetString(15);




                        txtNome.Text = nome;
                        cbCategoria.Text = cat;
                        txtDatatF.Text = data;
                        txtDataV.Text = data1;
                        txtSabor.Text = sabor;
                        txtEstoqueMin.Text = Convert.ToString(EstoqueMin);
                        txtEstoqueMax.Text = Convert.ToString(EstoqueMax);
                        txtQntd.Text = Convert.ToString(qntd);
                        txtDescricao.Text = desc;
                        txtMarca.Text = marca;
                        txtCustoE.Text = Convert.ToString(custoE);
                        txtCustoU.Text = Convert.ToString(custoU);
                        txtLucro.Text = Convert.ToString(lucro);
                        txtPreco.Text = Convert.ToString(preco);
                        cbSituacao.Text = situacao;
                        cbUnidade.Text = unidade;
                      


                        // cbSituacao.Text = situacao;



                    }
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Produto Inexistente");
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
           
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblQntd_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
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

            if (Qntd < EstoqueMin || Qntd > EstoqueMax)
            {
                MessageBox.Show("A quantidade de produtos inserida nao e permitida");
            }

            else
            { 
            cmd.CommandText = @"UPDATE Produto SET Nome = @nome,  Categoria = @cat,  Data_Fabricacao = @dataF, Data_Validade = @dataV,
                               Sabor = @sabor, Estoque_Min = @estoqueMin, Estoque_Max = @estoqueMax, Descricao = @descricao,
                                 Quantidade = @qntd, Marca = @marca, Situacao = @situacao, Unidade = @unidade
                                    
                                 where Codigo = '" + txtCod.Text + "';";
                cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cat", cbCategoria.Text);
            cmd.Parameters.AddWithValue("@DataF", txtDatatF.Text);
            cmd.Parameters.AddWithValue("@dataV", txtDataV.Text);
            cmd.Parameters.AddWithValue("@sabor", txtSabor.Text);
            cmd.Parameters.AddWithValue("@estoqueMin", double.Parse(txtEstoqueMin.Text));
            cmd.Parameters.AddWithValue("@estoqueMax", double.Parse(txtEstoqueMax.Text));
            cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
            cmd.Parameters.AddWithValue("@qntd", double.Parse(txtQntd.Text));
            cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
            cmd.Parameters.AddWithValue("@situacao", cbSituacao.Text);
            cmd.Parameters.AddWithValue("@unidade", cbUnidade.Text);



            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Dados alterados com sucesso!");
        }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            txtCnpj.Text = "";
            txtCod.Text = "";
            txtCustoE.Text = "";
            txtDatatF.Text = "";
            txtDataV.Text = "";
            txtDescricao.Text = "";
            txtCustoU.Text = "";
            txtEstoqueMax.Text = "";
            txtEstoqueMin.Text = "";
            txtLucro.Text = "";
            txtMarca.Text = "";
            txtNome.Text = "";
            txtPreco.Text = "";
            txtQntd.Text = "";
            txtSabor.Text = "";
        }

        private void txtCustoU_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQntd_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void AlterarDadosProdutoControl1_Load(object sender, EventArgs e)
        {

        }

        private void txtCustoE_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }

