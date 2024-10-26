using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MiniMercadoMartins
{
    public partial class FrmAlterarPrecoProduto : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = PAULO-PC;" + "Initial catalog = MiniMercadoMartins;" + "Integrated security = SSPI;");
        SqlCommand cmd = new SqlCommand();
        public FrmAlterarPrecoProduto()
        {
            InitializeComponent();
            cmd.Connection = conn;
        }

        private void FrmAlterarPrecoProduto_Load(object sender, EventArgs e)
        {

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
            if(txtLucro.Text == "0")
            {
                cmd.CommandText = @"UPDATE Produto SET Custo_Estoque = @custoE, Custo_Unitario = @custoU, Lucro = '0',
                                Preco_Unitario = @preco
                                 where Codigo = '" + txtCod.Text + "';";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@custoE", double.Parse(txtCustoE.Text));
                cmd.Parameters.AddWithValue("@custoU", double.Parse(txtCustoU.Text));
                cmd.Parameters.AddWithValue("@preco", double.Parse(txtPreco.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Dados alterados com sucesso!");
            }
            else
            {
                cmd.CommandText = @"UPDATE Produto SET Custo_Estoque = @custoE, Custo_Unitario = @custoU, Lucro = @lucro,
                                Preco_Unitario = @preco
                                 where Codigo = '" + txtCod.Text + "';";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@custoE", double.Parse(txtCustoE.Text));
                cmd.Parameters.AddWithValue("@custoU", double.Parse(txtCustoU.Text));
                cmd.Parameters.AddWithValue("@preco", double.Parse(txtPreco.Text));
                cmd.Parameters.AddWithValue("@lucro", double.Parse(txtLucro.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Dados alterados com sucesso!");
            }
            
        }

        private void txtCustoE_TextChanged(object sender, EventArgs e)
        {
            if (txtCustoE.Text != "")
            {
                if (txtQntd.Text != "")
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtLucro.Text == "")
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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Hide();
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
            this.Visible = false;
            this.Close();
        }
    }
}
