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
    public partial class carrinhoControl2 : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source = PAULO-PC;" + "Initial catalog = MiniMercadoMartins;" + "Integrated security = SSPI;");
        SqlCommand cmd = new SqlCommand();
        //  double valor1;
        //   string valor2;
        //double valor3;
        // double valor4;
        //  double valor5;
        double valor3;
        bool v = false;
        // string totalCancelado;
        double TotalCancelado;
        double novoValor;
        double Total = 0;
        bool pagar;
        public void DataGridView()
        {
            dgvProduto.ColumnCount = 3;
            dgvProduto.RowCount = 1000;
            dgvProduto.Columns[0].Name = "Codigo";
            dgvProduto.Columns[0].Width = 200;
            dgvProduto.Columns[1].Name = "Nome";
            dgvProduto.Columns[1].Width = 200;
            dgvProduto.Columns[2].Name = "Preço Unitario";
            dgvProduto.Columns[2].Width = 252;

        }
        public carrinhoControl2()
        {
            InitializeComponent();
            DataGridView();
            dgvProduto.Rows.Clear();
            pLogin.Visible = false;
            pCancelar.Visible = false;
            txtTotal.Text = Total.ToString();
            cmd.Connection = conn;

           
        }


        public carrinhoControl2(string valor)
        {
            InitializeComponent();
            lblValor.Text = valor;
         


        }
        private void txtQntd2_TextChanged(object sender, EventArgs e)
        {

        }

        private void carrinhoControl2_Load(object sender, EventArgs e)
        {

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            if (txtCod.Text == "")
            {
                txtPreco.Text = "";
                txtNome.Text = "";
            }
            else if (txtCod.Text != "" && txtQntd.Text != "")
            {
                bool tem;
                cmd.CommandText = @"select Codigo from Produto where Codigo = '" + txtCod.Text + "'";

                conn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                tem = rdr.HasRows;

                conn.Close();

                if (tem)
                {
                    cmd.CommandText = @"select Nome, Preco_Unitario from Produto where Codigo = '" + txtCod.Text + "'";
                    //  cmd.Parameters.AddWithValue("@cpf2", cpf);


                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();



                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            string nome = reader.GetString(0);
                            double preco = reader.GetDouble(1);
                            string qntd = txtQntd.Text;
                            double Qntd = Double.Parse(qntd);
                            double subtotal;
                            subtotal = preco * Qntd;
                            txtNome.Text = nome;
                            txtPreco.Text = Convert.ToString(preco);
                            txtSubTotal.Text = Convert.ToString(subtotal);
                        }
                    }

                    conn.Close();
                }
            }
            else
            {


                bool tem;
                cmd.CommandText = @"select Codigo from Produto where Codigo = '" + txtCod.Text + "'";

                conn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                tem = rdr.HasRows;

                conn.Close();

                if (tem)
                {
                    cmd.CommandText = @"select Nome, Preco_Unitario from Produto where Codigo = '" + txtCod.Text + "'";
                    //  cmd.Parameters.AddWithValue("@cpf2", cpf);


                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();



                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            string nome = reader.GetString(0);
                            double preco = reader.GetDouble(1);


                            txtNome.Text = nome;
                            txtPreco.Text = Convert.ToString(preco);
                            txtSubTotal.Text = Convert.ToString(preco);

                        }
                    }

                    conn.Close();
                }


            }
        }

        private void txtQntd_TextChanged(object sender, EventArgs e)
        {
            if (txtQntd.Text == "")
            {
                txtSubTotal.Text = txtPreco.Text;
            }

            else if(txtCod.Text == "")
            {
                MessageBox.Show("Insira o codigo do produto!");
                txtQntd.Text = "";
            }
            else
            {
                string preco = txtPreco.Text;
                string qntd = txtQntd.Text;

                double Preco = Double.Parse(preco);
                double Qntd = double.Parse(qntd);
                double SubTotal;

                SubTotal = Preco * Qntd;

                txtSubTotal.Text = SubTotal.ToString();

            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtQntd.Text == "")
            {
                MessageBox.Show("O campo quantidade nao pode ser vazio!");

            }

            else
            {

                /* cmd.CommandText = @"UPDATE Produto SET Quantidade = Quantidade - '"+txtQntd.Text+"' where Codigo = '" + txtCod.Text + "';";

                 conn.Open();
                 cmd.ExecuteNonQuery();
                 conn.Close();*/
                if (txtCpf.Text != "")
                {

                    if (txtNomeCliente.Text == "")
                    {
                        MessageBox.Show("O CPF nao foi verificado");
                    }
                    else
                   {

                    


                    string subTotal = txtSubTotal.Text;

                    string total1 = txtTotal.Text;
                    double total2 = double.Parse(total1);

                    double SubTotal = double.Parse(subTotal);

                    double total;
                    total = total2 + SubTotal;
                    dgvProduto.Rows.Add(txtCod.Text, txtNome.Text, txtPreco.Text);
                    txtTotal.Text = total.ToString();

                    bool tem = false;

                    cmd.CommandText = @"select Cod_Produto from Carrinho where Cod_Produto = '" + txtCod.Text + "' AND CPF_Cliente = '" + txtCpf.Text + "'";


                    conn.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    tem = rdr.HasRows;

                    conn.Close();

                    if (tem)
                    {



                        /*  cmd.CommandText = @"select  Nome , Preco_Unitario from Produto where Codigo = '" + txtCod.Text + "';";

                          conn.Open();
                          cmd.ExecuteNonQuery();
                          conn.Close();

                          conn.Open();

                          SqlDataReader reader = cmd.ExecuteReader();

                          if (reader.Read())
                          {
                              string nome = reader.GetString(0);
                              double preco = reader.GetDouble(1);


                             // listProduto1.View = View.Details;
                              ListViewItem item = new ListViewItem(nome);
                              item.SubItems.Add(preco.ToString("C"));

                            //  this.listProduto1.Items.Add(item);




                          }
                          conn.Close();*/

                        cmd.CommandText = @"UPDATE Carrinho SET Quantidade =  '" + txtQntd.Text + "' where Cod_Produto = '" + txtCod.Text + "';";

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        cmd.CommandText = @"UPDATE Produto SET Quantidade = Quantidade - '" + txtQntd.Text + "' where Codigo = '" + txtCod.Text + "';";

                        //  cmd.Parameters.AddWithValue("@qntd",double.Parse(txtQntd.Text));
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    else
                    {
                        string qntd = txtQntd.Text;
                        double Qntd = double.Parse(qntd);
                        cmd.CommandText = @"insert into Carrinho (Cod_Produto, Nome_Produto, Preco_Unitario, Quantidade, CPF_Cliente, Nome_Cliente) values
                                     ('" + txtCod.Text + "', (select Nome from Produto where Codigo = '" + txtCod.Text + "'), (select Preco_Unitario from Produto where Codigo = '" + txtCod.Text + "'), '" + txtQntd.Text + "', '" + txtCpf.Text + "', '" + txtNomeCliente.Text + "')";

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();


                        cmd.CommandText = @"UPDATE Produto SET Quantidade = Quantidade - '" + Qntd + "' where Codigo = '" + txtCod.Text + "';";
                        // cmd.Parameters.AddWithValue("@qntd2", double.Parse(txtQntd.Text));
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();


                    }
                }
                }
                else
                {
                    string subTotal = txtSubTotal.Text;

                    double SubTotal = double.Parse(subTotal);

                    string total1 = txtTotal.Text;
                    double total2 = double.Parse(total1);
                    double total;

                    total = total2 + SubTotal;

                    string preco = txtPreco.Text;
                    double Preco = Convert.ToDouble(preco);
                    // Preco.ToString("C");


                    dgvProduto.Rows.Add(txtCod.Text, txtNome.Text, Preco.ToString("C"));
                    txtTotal.Text = total.ToString();

                    cmd.CommandText = @"UPDATE Produto SET Quantidade = Quantidade - '" + txtQntd.Text + "' where Codigo = '" + txtCod.Text + "';";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtNome.Text = "";
            txtPreco.Text = "";
            txtQntd.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = Total.ToString();
            dgvProduto.Rows.Clear();
            txtTotalDesc.Text = "";
            txtCpf.Text = "";
            txtNomeCliente.Text = "";
            Total = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(txtTotal.Text == "0")
            {
                MessageBox.Show("Nao ha itens para ser cancelado");
            }

            else
            {
                pLogin.Visible = true;
            }
            








            /*bool tem = false;


            cmd.CommandText = @"select Cod_Produto from NotaFiscal1 where Cod_Produto = '" + txtCod2.Text + "'";



            conn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            tem = rdr.HasRows;

            conn.Close();

            if (tem)
            {
                if (txtQntd2.Text == "")
                {
                    MessageBox.Show("Insira a quantidade de produtos que deseja cancelar");
                }
                else
                {


                    cmd.CommandText = @"select  Preco_Unitario from NotaFiscal1 where Cod_Produto = '" + txtCod2.Text + "'";


                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();



                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            double preco = reader.GetDouble(0);
                            string qntd = txtQntd2.Text;
                            double Qntd = double.Parse(qntd);
                            double total1;

                            total1 = preco * Qntd;

                            Total = Total - total1;

                            txtTotal.Text = Total.ToString();



                        }
                    }

                    conn.Close();

                    cmd.CommandText = @"UPDATE NotaFiscal1 SET Quantidade = Quantidade - '" + txtQntd2.Text + "' where Cod_Produto = '" + txtCod2.Text + "';";

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    cmd.CommandText = @"UPDATE Produto SET Quantidade = Quantidade + '" + txtQntd2.Text + "' where Codigo = '" + txtCod2.Text + "';";

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Item cancelado com sucesso!");


                }

            }

            else
            {
                MessageBox.Show("Produto inexistente!");
            }*/
        }

        private void button7_Click(object sender, EventArgs e)
        {
           

            


                if (txtTotal.Text == "0")
                {
                    MessageBox.Show("Impossivel realizar pagamento!");
                }

                else if (txtTotalDesc.Text == "")
                {
                    if (txtCpf.Text != "")
                    {
                        string total1 = txtTotal.Text;
                        double total2 = double.Parse(total1);
                        string result = Convert.ToString(total2);

                        // double valorDesc = 0;
                        string Result = "Nao tem";
                        FrmPagarCarrinho destino = new FrmPagarCarrinho(result, Result);

                        destino.Show();
                        bool tem = false;

                        cmd.CommandText = @"select CPF_Cliente from Registro_Cliente where  CPF_Cliente = '" + txtCpf.Text + "'";


                        conn.Open();

                        SqlDataReader rdr = cmd.ExecuteReader();

                        tem = rdr.HasRows;
                        conn.Close();

                        if (tem)
                        {
                            string total = txtTotal.Text;
                            double Total1 = double.Parse(total);
                            cmd.CommandText = @"UPDATE Registro_Cliente SET Total = @total1 where CPF_Cliente = '" + txtCpf.Text + "'";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@total1", double.Parse(txtTotal.Text));
                            //  cmd.Parameters.AddWithValue("@cpf2", txtCpf.Text);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        else
                        {
                            string total = txtTotal.Text;
                            double Total1 = double.Parse(total);
                            cmd.CommandText = @"insert into Registro_Cliente (Total , CPF_Cliente , Nome_Cliente) values
                      (@total, '" + txtCpf.Text + "', '" + txtNomeCliente.Text + "')";
                        cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@total", double.Parse(txtTotal.Text));
                            //  cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                            //  cmd.Parameters.AddWithValue("@nome", txtNomeCliente.Text);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                    }

                    else
                    {
                        string total1 = txtTotal.Text;
                        double total2 = double.Parse(total1);
                        string result = Convert.ToString(total2);

                        // double valorDesc = 0;
                        string Result = "Nao tem";
                        FrmPagarCarrinho destino = new FrmPagarCarrinho(result, Result);

                        destino.Show();
                    }

                }

                else
                {
                    string total1 = txtTotal.Text;
                    double total2 = double.Parse(total1);
                    string result = Convert.ToString(total2);

                    string valor1 = txtTotalDesc.Text;
                    double valor2 = double.Parse(valor1);
                    string Result = Convert.ToString(valor2);

                    FrmPagarCarrinho destino = new FrmPagarCarrinho(result, Result);

                    destino.Show();

                    bool tem = false;

                    cmd.CommandText = @"select CPF_Cliente from Registro_Cliente where  CPF_Cliente = '" + txtCpf.Text + "'";


                    conn.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    tem = rdr.HasRows;
                    conn.Close();

                    if (tem)
                    {
                    conn.Open();
                        string total = txtTotalDesc.Text;
                        double Total1 = double.Parse(total);
                        cmd.CommandText = @"UPDATE Registro_Cliente SET Total = @desconto where CPF_Cliente = '" + txtCpf.Text + "'";
                       cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@desconto", double.Parse(txtTotalDesc.Text));
                      //  conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    else
                    {
                        string total = txtTotalDesc.Text;
                        double Total1 = double.Parse(total);
                        cmd.CommandText = @"insert into Registro_Cliente (Total, CPF_Cliente, Nome_Cliente) values
                      (@valor, '" + txtCpf.Text + "', '" + txtNomeCliente.Text + "')";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@valor", double.Parse(txtTotalDesc.Text));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                }
            
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            bool tem;
            if (txtCpf.Text == "")
            {
                txtNomeCliente.Text = "";
            }
            /* else
             {
                 cmd.CommandText = @"select CPF from Cliente where CPF = '" + txtCpf.Text + "'";

                 conn.Open();

                 SqlDataReader rdr = cmd.ExecuteReader();

                 tem = rdr.HasRows;

                 conn.Close();

                 if (tem)
                 {
                     cmd.CommandText = @"select Nome from Cliente where CPF = '" + txtCpf.Text + "'";



                     conn.Open();

                     SqlDataReader reader = cmd.ExecuteReader();

                     if (reader.HasRows)
                     {
                         while (reader.Read())
                         {
                             string nome = reader.GetString(0);
                             txtNomeCliente.Text = nome;
                         }
                     }
                     conn.Close();
                 }




             }*/
        }

        private void BtnDesconto_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "")
            {
                MessageBox.Show("Impossivel realizar desconto!");
            }

            else
            {
                bool tem = false;
                string valor1 = txtTotal.Text;
                double Valor1 = double.Parse(valor1);
                double valor2;


                cmd.Connection = conn;
                cmd.CommandText = @"select CPF FROM Cliente where CPF = '" + txtCpf.Text + "'";
                // cmd.Parameters.AddWithValue("@cpf", cpf);


                conn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                tem = rdr.HasRows;

                conn.Close();

                if (txtCpf.Text == "")
                {
                    MessageBox.Show("Insira um CPF valido!");
                }


                else if (tem)
                {
                    if (txtNomeCliente.Text == "")
                    {
                        MessageBox.Show("O CPF nao foi verificado!");
                    }

                    else
                   {

                    

                    if (Valor1 >= 150 && Valor1 <= 310)
                    {
                        valor2 = Valor1 * 0.05;

                        valor3 = Valor1 - valor2;

                        txtTotalDesc.Text = valor3.ToString();

                        // valor5 = valor1;

                        //   lblValorDesc.Text = valor4.ToString("C");
                        v = true;
                    }
                    else if (Valor1 >= 310)
                    {

                        valor2 = Valor1 * 0.1;

                        valor3 = Valor1 - valor2;
                        txtTotalDesc.Text = valor3.ToString();

                        //  valor5 = valor1;

                        // lblValorDesc.Text = valor4.ToString("C");
                        v = true;
                    }
                    else
                    {
                        MessageBox.Show("O Cliente não atingiu o valor mínimo da compra para receber desconto");

                    }
                }
                }

                else
                {
                    MessageBox.Show("Cliente inexistente!");
                }

            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtCpf.Text == "")
            {
                MessageBox.Show("Insira um CPF para ser verificado!");
            }

            else
            {

            

            bool tem;
            cmd.CommandText = @"select CPF from Cliente where CPF = '" + txtCpf.Text + "'";

            conn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            tem = rdr.HasRows;

            conn.Close();

            if (tem)
            {
                cmd.CommandText = @"select Nome from Cliente where CPF = '" + txtCpf.Text + "'";



                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string nome = reader.GetString(0);
                        txtNomeCliente.Text = nome;
                    }
                }


                conn.Close();

            }

            else
            {
                MessageBox.Show("Cliente inexistente!");
                txtCpf.Text = "";
            }

        }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //TotalCancelado = double.Parse(totalCancelado);

            string tot = txtTotal.Text;

            double Tot = double.Parse(tot);
            novoValor = Tot - TotalCancelado;



            txtTotal.Text = novoValor.ToString();


        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            //string valor = lblValor.Text;

            // TotalCancelado = double.Parse(valor);
            //  Total = Total - TotalCancelado;

            //  txtTotal.Text = Total.ToString();

            pCancelar.Visible = true;
            pLogin.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (pLogin.Visible == true)
            {
                btnCancelarItem.Enabled = false;
                btnPagar.Enabled = false;
                btnExcluir.Enabled = false;
                btnVerificar.Enabled = false;
                btnAdicionar.Enabled = false;
                BtnDesconto.Enabled = false;

            }
            else if(pLogin.Visible == false)
            {
                btnCancelarItem.Enabled = true;
                btnPagar.Enabled = true;
                btnExcluir.Enabled = true;
                btnVerificar.Enabled = true;
                btnAdicionar.Enabled = true;
                BtnDesconto.Enabled = true;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Ger" && txtSenha.Text == "123")
            {
                pCancelar.Visible = true;
             
                pLogin.Visible = false;
                txtEmail.Clear();
                txtSenha.Clear();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos!");
                txtEmail.Clear();
                txtSenha.Clear();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            pLogin.Visible = false;
            txtEmail.Clear();
            txtSenha.Clear();
            btnCancelarItem.Enabled = true;
            btnPagar.Enabled = true;
            btnExcluir.Enabled = true;
            btnVerificar.Enabled = true;
            btnAdicionar.Enabled = true;
            BtnDesconto.Enabled = true;
        }

        private void pCancelar_Paint(object sender, PaintEventArgs e)
        {
            if (pCancelar.Visible == true)
            {
                btnCancelarItem.Enabled = false;
                btnPagar.Enabled = false;
                btnExcluir.Enabled = false;
                btnVerificar.Enabled = false;
                btnAdicionar.Enabled = false;
                BtnDesconto.Enabled = false;

            }
            else
            {
                btnCancelarItem.Enabled = true;
                btnPagar.Enabled = true;
                btnExcluir.Enabled = true;
                btnVerificar.Enabled = true;
                btnAdicionar.Enabled = true;
                BtnDesconto.Enabled = true;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            pCancelar.Visible = false;
            txtCodCancelar.Clear();
            txtPrecoCancelar.Clear();
            txtQuantidadeCancelar.Clear();
            btnCancelarItem.Enabled = true;
            btnPagar.Enabled = true;
            btnExcluir.Enabled = true;
            btnVerificar.Enabled = true;
            btnAdicionar.Enabled = true;
            BtnDesconto.Enabled = true;
        }

        private void txtCodCancelar_TextChanged(object sender, EventArgs e)
        {
            if (txtCod.Text == "")
            {
                txtPreco.Text = "";
            }
            else
            {
                bool tem;
                cmd.CommandText = @"select Codigo from Produto where Codigo = '" + txtCodCancelar.Text + "'";

                conn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                tem = rdr.HasRows;

                conn.Close();

                if (tem)
                {

                    cmd.CommandText = @"select Preco_Unitario from Produto where Codigo = '" + txtCodCancelar.Text + "'";

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            double preco = reader.GetDouble(0);

                            txtPrecoCancelar.Text = preco.ToString();
                        }
                    }

                    conn.Close();


                }
                else
                {

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            if(txtCpf.Text != "")
            {
                if (txtTotalDesc.Text == "")
                {
                    string qntd = txtQuantidadeCancelar.Text;
                    double Qntd = double.Parse(qntd);
                    string preco = txtPrecoCancelar.Text;
                    double Preco = double.Parse(preco);
                    string total1 = txtTotal.Text;
                    double total2 = double.Parse(total1);
                    double valor = Preco * Qntd;
                    double novototal;

                    novototal = total2 - valor;

                    txtTotal.Text = novototal.ToString();

                    MessageBox.Show("Item cancelado com sucesso!");

                    cmd.CommandText = @"UPDATE Produto SET Quantidade = Quantidade + '" + txtQuantidadeCancelar.Text + "' where Codigo = '" + txtCodCancelar.Text + "';";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    cmd.CommandText = @"UPDATE Carrinho SET Quantidade = Quantidade - '" + txtQuantidadeCancelar.Text + "' where Cod_Produto = '" + txtCodCancelar.Text + "' AND CPF_Cliente = '"+txtCpf.Text+"';";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();


                    // sair do carrinho

                    pCancelar.Visible = false;
                    txtCodCancelar.Clear();
                    txtPrecoCancelar.Clear();
                    txtQuantidadeCancelar.Clear();

                   

                }
                else
                {
                    string qntd = txtQuantidadeCancelar.Text;
                    double Qntd = double.Parse(qntd);
                    string preco = txtPrecoCancelar.Text;
                    double Preco = double.Parse(preco);
                    string total1 = txtTotalDesc.Text;
                    double total2 = double.Parse(total1);
                    double valor = Preco * Qntd;
                    double novototal;

                   
                    novototal = total2 - valor;

                    txtTotalDesc.Text = novototal.ToString();

                    MessageBox.Show("Item cancelado com sucesso!");

                    cmd.CommandText = @"UPDATE Produto SET Quantidade = (select Quantidade from Produto where Codigo = '" + txtCodCancelar.Text + "') + '" + txtQuantidadeCancelar.Text + "' where Codigo = '" + txtCodCancelar.Text + "';";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    cmd.CommandText = @"UPDATE Carrinho SET Quantidade = Quantidade - '" + txtQuantidadeCancelar.Text + "' where Cod_Produto = '" + txtCodCancelar.Text + "' AND CPF_Cliente = '" + txtCpf.Text + "';";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                   
                    pCancelar.Visible = false;
                    txtCodCancelar.Clear();
                    txtPrecoCancelar.Clear();
                    txtQuantidadeCancelar.Clear();

                    
                  
                }
            }

            else if(txtCpf.Text == "")
            {
                string qntd = txtQuantidadeCancelar.Text;
                double Qntd = double.Parse(qntd);
                string preco = txtPrecoCancelar.Text;
                double Preco = double.Parse(preco);
                string total1 = txtTotal.Text;
                double total2 = double.Parse(total1);
                double valor = Preco * Qntd;
                double novototal;

                novototal = total2 - valor;

                txtTotal.Text = novototal.ToString();

                MessageBox.Show("Item cancelado com sucesso!");

                cmd.CommandText = @"UPDATE Produto SET Quantidade = (select Quantidade from Produto where Codigo = '" + txtCodCancelar.Text + "') + '" + txtQuantidadeCancelar.Text + "' where Codigo = '" + txtCodCancelar.Text + "';";
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                pCancelar.Visible = false;
                txtCodCancelar.Clear();
                txtPrecoCancelar.Clear();
                txtQuantidadeCancelar.Clear();

               
            }

            btnCancelarItem.Enabled = true;
            btnPagar.Enabled = true;
            btnExcluir.Enabled = true;
            btnVerificar.Enabled = true;
            btnAdicionar.Enabled = true;
            BtnDesconto.Enabled = true;
        }
    }
}
