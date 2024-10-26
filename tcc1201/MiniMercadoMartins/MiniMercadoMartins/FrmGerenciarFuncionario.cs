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
    public partial class FrmGerenciarFuncionario : Form
    {
        public FrmGerenciarFuncionario()
        {
            InitializeComponent();
            panelBarra.Width = 28;
            panelMenu.Width = 1;
            cadastrarFuncionarioControl11.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmGerenciarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lblVoltar.Text == "")
            {
                panelBarra.Width = 162;
                panelMenu.Width = 154;
//cadastrarFuncionarioControl11.Width = 711;
                lblVoltar.Text = "Voltar";
            }
            else if (lblVoltar.Text == "Voltar")
            {
                panelBarra.Width = 28;
                panelMenu.Width = 1;
             //   cadastrarFuncionarioControl11.Width = 577;
                lblVoltar.Text = "";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarFuncionarioControl11.BringToFront();
            panelBarra.Width = 28;
            panelMenu.Width = 1;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblConsultar_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
          

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarDadosFuncionarioControl11.BringToFront();
            panelBarra.Width = 28;
            panelMenu.Width = 1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultarFuncionarioControl11.BringToFront();
            panelBarra.Width = 28;
            panelMenu.Width = 1;
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
