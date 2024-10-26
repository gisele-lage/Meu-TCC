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
    public partial class FrmCaixa : Form
    {
        public FrmCaixa()
        {
            InitializeComponent();
            carrinhoControl21.BringToFront();

            //carrinhoControl11.BringToFront();

        }

        private void FrmCaixa_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

       

       

        private void button10_Click(object sender, EventArgs e)
        {
            carrinhoControl21.BringToFront();
        }

      
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarClienteControl11.BringToFront();
            
        }

      
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarDadosControl11.BringToFront();
        }

        private void alterarDadosControl11_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarClienteControl11_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void alterarDadosControl11_Load_1(object sender, EventArgs e)
        {

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
