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
    public partial class FrmPagarCarrinho : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = PAULO-PC;" + "Initial catalog = MiniMercadoMartins;" + "Integrated security = SSPI;");
        SqlCommand cmd = new SqlCommand();
        double valor1;
        string valor2;
        double valor3;
        double valor4;
        double valor5;
        bool v = false;

        public FrmPagarCarrinho()
        {
            InitializeComponent();
            cmd.Connection = conn;
            

        }

        public FrmPagarCarrinho(string valor, string Valor)
        {
            InitializeComponent();
            lblValor.Text = valor.ToString();
            lblValorDesc.Text = Valor.ToString();
            valor2 = valor;
            cbpcao.Visible = false;
            lblOpcao.Visible = false;

        }
        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFormaPagamento.Text == "Cartao")
            {
                cbpcao.Visible = true;
                lblOpcao.Visible = true;
                txtValorRecebido.Enabled = false;
            }
            else
            {
                cbpcao.Visible = false;
                lblOpcao.Visible = false;
                txtValorRecebido.Enabled = true;
            }
        }

        private void FrmPagarCarrinho_Load(object sender, EventArgs e)
        {

        }

        private void BtnDesconto_Click(object sender, EventArgs e)
        {
            bool tem = false;

            cmd.Connection = conn;
          //  cmd.CommandText = @"select CPF FROM Cliente where CPF = '"+txtCpf.Text+"'";
            // cmd.Parameters.AddWithValue("@cpf", cpf);


            conn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            tem = rdr.HasRows;

            conn.Close();

            /*  if (txtCpf.Text == "")
           // {
                MessageBox.Show("Insira um CPF valido!");
           // }

           else if (tem)
            {
                valor1 = double.Parse(valor2);

                if (valor1 >= 150 && valor1 <= 310)
                {
                    valor3 = valor1 * 0.05;

                    valor4 = valor1 - valor3;

                    valor5 = valor1;

                    lblValorDesc.Text = valor4.ToString("C");
                    v = true;
                }
                else if (valor1 >= 310)
                {

                    valor3 = valor1 * 0.1;

                    valor4 = valor1 - valor3;

                    valor5 = valor1;

                    lblValorDesc.Text = valor4.ToString("C");
                    v = true;
                }
                else
                {
                    MessageBox.Show("O Cliente não atingiu o valor mínimo da compra para receber desconto");

                }
            }

           

            else
            {
               
                MessageBox.Show("Cliente nao cadastrado!");
            }*/

        }

        private void btnTroco_Click(object sender, EventArgs e)
        {
            

            if (lblValorDesc.Text != "Nao tem" && txtValorRecebido.Enabled == true)
            {
                if(txtValorRecebido.Text == "")
                {
                    MessageBox.Show("Insira o valor recebido!");

                }
                else
                {
                    string valorRecebido = txtValorRecebido.Text;
                    string valorDesc = lblValorDesc.Text;
                    string valorCompra = lblValor.Text;
                    double ValorRecebido2;
                    double troco;
                    double desc = double.Parse(valorDesc);
                    ValorRecebido2 = double.Parse(valorRecebido);

                    troco = ValorRecebido2 - desc;

                    lblTroco.Text = troco.ToString("C");
                }
              
            }

            else if (lblValorDesc.Text == "Nao tem" && txtValorRecebido.Enabled == true)
            {
                if (txtValorRecebido.Text == "")
                {
                    MessageBox.Show("Insira o valor recebido!");

                }

                else
                {
                    string valorRecebido = txtValorRecebido.Text;
                    //string valorDesc = lblValorDesc.Text;
                    string valorCompra = lblValor.Text;
                    double ValorRecebido2;
                    double troco;
                    //  double desc = double.Parse(valorDesc);
                    ValorRecebido2 = double.Parse(valorRecebido);

                    valor5 = double.Parse(valorCompra);

                    troco = ValorRecebido2 - valor5;

                    lblTroco.Text = troco.ToString("C");
                }
                
            }
            else
            {
                MessageBox.Show("A forma de pagamento selecionada nao permite calcular o troco");
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if(cbFormaPagamento.Text == "Cartao" && cbpcao.Text != "")
            {
               
                MessageBox.Show("Pagamento realizado com sucesso!");
              
                this.Visible = false;
                this.Close();
            }

           else if(cbFormaPagamento.Text == "Dinheiro" && txtValorRecebido.Text != "")
            {
              
                MessageBox.Show("Pagamento realizado com sucesso!");
               
                this.Visible = false;
                this.Close();
            }

            else
            {
                MessageBox.Show("Impossivel realizar o pagamento!");
            }
        }
    }
}
