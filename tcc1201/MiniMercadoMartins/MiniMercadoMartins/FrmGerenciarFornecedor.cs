using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMercadoMartins
{
    public partial class FrmGerenciarFornecedor : Form
    {
        public FrmGerenciarFornecedor()
        {
            InitializeComponent();
            cadastrarFornecedorControl11.BringToFront();
            panel1.Height = 22;
            panel1.Visible = true;
            pictureCima.Visible = false;
            lblMenu.Text = "Menu";
        }

        private void FrmTelaGerente_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBaixo1_Click(object sender, EventArgs e)
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

        private void pictureCima_Click(object sender, EventArgs e)
        {
            if (lblVoltar.Text == "Voltar")
            {
                panel1.Height = 22;
                lblMenu.Text = "Menu";
                lblVoltar.Text = "";
                pictureCima.Visible = false;
                pictureBaixo.Visible = true;
            }
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

        private void cadastrarFornecedorControl11_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            cadastrarFornecedorControl11.BringToFront();
            panel1.Height = 22;
            lblMenu.Text = "Menu";
            lblVoltar.Text = "";
            pictureCima.Visible = false;
            pictureBaixo.Visible = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarDadosFornecedorControl11.BringToFront();
            panel1.Height = 22;
            lblMenu.Text = "Menu";
            lblVoltar.Text = "";
            pictureCima.Visible = false;
            pictureBaixo.Visible = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultarDadosFornecedorControl11.BringToFront();
            panel1.Height = 22;
            lblMenu.Text = "Menu";
            lblVoltar.Text = "";
            pictureCima.Visible = false;
            pictureBaixo.Visible = true;
        }
    }
}
