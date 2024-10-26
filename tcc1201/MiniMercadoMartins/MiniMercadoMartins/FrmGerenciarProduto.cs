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
    public partial class FrmGerenciarProduto : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = PAULO-PC;" + "Initial catalog = MiniMercadoMartins;" + "Integrated security = SSPI;");
        SqlCommand cmd = new SqlCommand();

        public void VerificarEstoque()
        {
            cmd.CommandText = @"select Quantidade, Estoque_Min from Produto";

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            bool v = false;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    double quantidade = reader.GetDouble(0);
                    double EstoqueMin = reader.GetDouble(1);

                    if (quantidade <= EstoqueMin + 5)
                    {
                        v = true;
                    }
                }
            }
            if (v == true)
            {
                MessageBox.Show("Há produtos em pouca quantidade no estoque");

            }
            else { }
            conn.Close();
        }

        public void VerificarValidade()
        {
            DateTime hoje = DateTime.Now;

            cmd.CommandText = @"select Data_Validade from Produto";

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                DateTime data = reader.GetDateTime(0);

                TimeSpan date = Convert.ToDateTime(data) - Convert.ToDateTime(hoje);

                int totaldias = date.Days;

                if (totaldias <= 7)
                {
                    MessageBox.Show("Há produtos próximos da validade no estoque");
                }
                else { }

                conn.Close();
            }
        }
        public FrmGerenciarProduto()
        {
            InitializeComponent();
            cmd.Connection = conn;
            VerificarEstoque();
            VerificarValidade();
            panel1.Height = 25;
            pictureBaixo.Visible = true;
            pictureCima.Visible = false;
            lblMenu.Text = "Menu";
            cadastrarProdutoControl11.BringToFront();


        }

        private void FrmGerenciarProduto_Load(object sender, EventArgs e)
        {

        }

        private void pictureBaixo_Click(object sender, EventArgs e)
        {
            if (lblVoltar.Text == "")
            {
                panel1.Height = 88;
                
                lblVoltar.Text = "Voltar";
                lblMenu.Text = "";
                pictureBaixo.Visible = false;
                pictureCima.Visible = true;
            }
            else
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureCima_Click(object sender, EventArgs e)
        {
            if(lblVoltar.Text == "Voltar")
            {
                panel1.Height = 25;
                lblMenu.Text = "Menu";
                lblVoltar.Text = "";
                pictureCima.Visible = false;
                pictureBaixo.Visible = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarProdutoControl11.BringToFront();
            panel1.Height = 25;
            lblMenu.Text = "Menu";
            lblVoltar.Text = "";
            pictureCima.Visible = false;
            pictureBaixo.Visible = true;
        }

        private void cadastrarProdutoControl11_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarDadosProdutoControl11.BringToFront();
            panel1.Height = 25;
            lblMenu.Text = "Menu";
            lblVoltar.Text = "";
            pictureCima.Visible = false;
            pictureBaixo.Visible = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultarProdutoControl11.BringToFront();
            panel1.Height = 25;
            lblMenu.Text = "Menu";
            lblVoltar.Text = "";
            pictureCima.Visible = false;
            pictureBaixo.Visible = true;
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
