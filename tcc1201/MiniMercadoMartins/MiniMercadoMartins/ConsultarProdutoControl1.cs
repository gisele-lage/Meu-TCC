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
    public partial class ConsultarProdutoControl1 : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source = PAULO-PC;" + "Initial catalog = MiniMercadoMartins;" + "Integrated security = SSPI;");
        SqlCommand cmd = new SqlCommand();
        public ConsultarProdutoControl1()
        {
            InitializeComponent();
            cmd.Connection = conn;
            txtFiltro.Visible = true;
            cbCategoria.Visible = false;
            txtVal.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbConsultar.Text == "Quantidade")
            {
                cmd.CommandText = @" select * from Produto  order by Quantidade;";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

           
            else if (cbConsultar.Text == "Preço")
            {
                cmd.CommandText = @" select * from Produto  order by Preco_Unitario;";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            else if (cbConsultar.Text == "Data de Validade")
            {
                cmd.CommandText = @" select * from Produto  order by Data_Validade;";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                cmd.CommandText = @" select * from Produto  order by Categoria;";

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ConsultarProdutoControl1_Load(object sender, EventArgs e)
        {

        }

        private void cbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbConsultar.Text == "Categoria")
            {
                txtFiltro.Clear();
                txtFiltro.Visible = false;
                txtVal.Visible = false;
                cbCategoria.Visible = true;
            }

            else if (cbConsultar.Text == "Data de Validade")
            {
                txtFiltro.Clear();
                txtVal.Visible = true;
                txtFiltro.Visible = false;
                cbCategoria.Visible = false;
            }
            else
            {
                txtFiltro.Clear();
                txtFiltro.Visible = true;
                cbCategoria.Visible = false;
                txtVal.Visible = false;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(cbConsultar.Text == "Quantidade")
            {
                cmd.CommandText = @" select * from Produto  where Quantidade = '"+txtFiltro.Text+"';";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            } 

           
            else if (cbConsultar.Text == "Preço")
            {
                cmd.CommandText = @" select * from Produto  where Preco_Unitario = '" + txtFiltro.Text+ "';";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                cmd.CommandText = @" select * from Produto  where Categoria = '" + cbCategoria.Text + "';";

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

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtVal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
