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
    public partial class FrmConsultarDados : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = PAULO-PC;" + "Initial catalog = MiniMercadoMartins;" + "Integrated security = SSPI;");
        SqlCommand cmd = new SqlCommand();
        public FrmConsultarDados()
        {
            InitializeComponent();
             cbSituacao.Visible = false;
                txtFiltro.Visible = true;
            lblCpf.Visible = true;
            lblNome.Visible = false;
            cmd.Connection = conn;
        }

        private void dgvConsultar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbConsultar.Text == "Clientes (Por nome)")
            {
               
                cmd.CommandText = @"select * from Cliente  order by Nome;";
               
                dgvConsultar.Width = 602;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }

            else if (cbConsultar.Text == "Clientes (Por situaçao)")
            {
                lblCpf.Visible = false;
                cmd.CommandText = @"select * from  Cliente  order by Situacao;";
                dgvConsultar.Width = 602;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            else if(cbConsultar.Text == "Clientes (Com maior valor de compra)")
            {
                lblCpf.Visible = true;
                cmd.CommandText = @"select * from Registro_Cliente  order by Total DESC;";
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
               


               
            }
            else if (cbConsultar.Text == "Produtos mais comprados")
            {
                lblCpf.Visible = true;
                cmd.CommandText = @"select Nome_Produto, Quantidade, Preco_Unitario from Carrinho  order by Quantidade DESC;";
               // dgvConsultar.Width = 451;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(cmd);
                DataTable lista = new DataTable();
                objAdp.Fill(lista);
                dgvConsultar.DataSource = lista;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro na exibição dos dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cbConsultar.Text == "Clientes (Por nome)")
            {
                cmd.CommandText = @"select * from Cliente  where Nome = '"+txtFiltro.Text+"';";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }

            else if (cbConsultar.Text == "Clientes (Por situaçao)")
            {
                cmd.CommandText = @"select * from  Cliente where Situacao = '"+cbSituacao.Text+"'  ;";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else if (cbConsultar.Text == "Clientes (Com maior valor de compra)")
            {
                cmd.CommandText = @"select * from Registro_Cliente  where CPF_Cliente = '"+txtFiltro.Text+"';";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                cmd.CommandText = @"select CPF_Cliente, Nome_Cliente, Nome_Produto, Quantidade, Preco_Unitario from Carrinho  where CPF_Cliente = '"+txtFiltro.Text+"';";
               // dgvConsultar.Width = 470;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(cmd);
                DataTable lista = new DataTable();
                objAdp.Fill(lista);
                dgvConsultar.DataSource = lista;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro na exibição dos dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbConsultar.Text == "Clientes (Por nome)")
            {
                txtFiltro.Clear();
                cbSituacao.Visible = false;
                txtFiltro.Visible = true;
                txtFiltro.Enabled = true;
                lblCpf.Visible = false;
                lblNome.Visible = true;
            }
            else if (cbConsultar.Text == "Clientes (Por situaçao)")
            {

                cbSituacao.Visible = true;
                txtFiltro.Visible = false;
                lblCpf.Visible = false;
                lblNome.Visible = false;
            }
            else if (cbConsultar.Text == "Clientes (Com maior valor de compra)")
            {
                txtFiltro.Clear();
                cbSituacao.Visible = false;
                txtFiltro.Visible = true;
                lblCpf.Visible = true;
                lblNome.Visible = false;
            }
            else
            {
                txtFiltro.Clear();
                cbSituacao.Visible = false;
                txtFiltro.Visible = true;
                lblCpf.Visible = true;
                lblNome.Visible = false;
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
    }
}
