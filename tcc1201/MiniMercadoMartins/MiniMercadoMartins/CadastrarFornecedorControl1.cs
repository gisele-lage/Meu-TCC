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
    public partial class CadastrarFornecedorControl1 : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source = PAULO-PC;" + "Initial catalog = MiniMercadoMartins;" + "Integrated security = SSPI;");
        SqlCommand cmd = new SqlCommand();
        public CadastrarFornecedorControl1()
        {
            InitializeComponent();
            cmd.Connection = conn;
        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarFornecedorControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool tem = false;


            cmd.CommandText = @"select CNPJ from Fornecedor where CNPJ = '" + txtCnpj.Text + "'";

            conn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            tem = rdr.HasRows;

            conn.Close();



            if (tem)
            {
                MessageBox.Show("Ja existe um funcionario com este CPF e/ou E-mail");
            }

            else
            {
                cmd.CommandText = @"insert into Fornecedor ( CNPJ, Nome, Cidade, Valor_Frete, CEP, Tempo_Entrega, Email, Bairro, Telefone, Endereco, Situacao)
                                                      values (@cnpj, @nome, @cidade, @frete, @cep, @tempo, @email, @bairro, @tel, @endereco, 'Ativo' );";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cnpj", txtCnpj.Text);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@frete", double.Parse(txtValorFrete.Text));
                cmd.Parameters.AddWithValue("@tempo", txtTempoEntrega.Text);
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("@cep", txtCep.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cadastro realizado com sucesso!");

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBairro.Text = "";
            txtCep.Text = "";
            txtCidade.Text = "";
            txtCnpj.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtNome.Text = "";
            txtTel.Text = "";
            txtTempoEntrega.Text = "";
            txtValorFrete.Text = "";
        }
    }
}
