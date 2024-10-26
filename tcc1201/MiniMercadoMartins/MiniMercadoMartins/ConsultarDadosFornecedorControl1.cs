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
    public partial class ConsultarDadosFornecedorControl1 : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source = PAULO-PC;" + "Initial catalog = MiniMercadoMartins;" + "Integrated security = SSPI;");
        SqlCommand cmd = new SqlCommand();
        public ConsultarDadosFornecedorControl1()
        {
            InitializeComponent();
            cmd.Connection = conn;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvConsultar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvConsultar_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ConsultarDadosFornecedorControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cbConsultar.Text == "Valor do Frete")
            {
                cmd.CommandText = @"select * from Fornecedor  order by Valor_Frete;";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }

            else if (cbConsultar.Text == "Situacao")
            {
                cmd.CommandText = @"select * from Fornecedor  order by Situacao;";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else 
            {
                cmd.CommandText = @"select * from Fornecedor  order by Tempo_Entrega;";

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
           

             if (cbConsultar.Text == "Situacao")
            {
                cmd.CommandText = @"select * from Fornecedor  where Situacao = '" + cbOpcao.Text + "';";
              
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            else if (cbConsultar.Text == "Tempo medio de entrega")
            {
                cmd.CommandText = @"select * from Fornecedor  where Tempo_Entrega = '" + txtFiltro.Text + "';";
               
                
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
            if (cbConsultar.Text == "Valor do Frete")
            {
                txtFiltro.Clear();
                txtFiltro.Enabled = false;
                cbOpcao.Visible = false;
            }
            else if (cbConsultar.Text == "Situacao")
            {
                txtFiltro.Clear();
                txtFiltro.Visible = false;
                cbOpcao.Visible = true;
            }
            else
            {
                txtFiltro.Clear();
                txtFiltro.Visible = true;
                txtFiltro.Enabled = true;
                cbOpcao.Visible = false;
            }
        }
    }
}
