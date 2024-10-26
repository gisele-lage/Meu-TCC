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
    public partial class AlterarDadosFornecedorControl1 : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source = PAULO-PC;" + "Initial catalog = MiniMercadoMartins;" + "Integrated security = SSPI;");
        SqlCommand cmd = new SqlCommand();
        public AlterarDadosFornecedorControl1()
        {
            InitializeComponent();
            cmd.Connection = conn;
        }

        private void AlterarDadosFornecedorControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            bool tem;
            cmd.CommandText = @"select CNPJ from Fornecedor where CNPJ = '" + txtCnpj.Text + "'";

            conn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            tem = rdr.HasRows;

            conn.Close();

            if (tem)
            {
                cmd.CommandText = @"select Nome, Cidade, Valor_Frete, CEP, Tempo_Entrega, Email, Bairro, Telefone, Endereco, Situacao
                                     
                 from Fornecedor where CNPJ = '" + txtCnpj.Text + "'";
                //  cmd.Parameters.AddWithValue("@cpf2", cpf);


                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();



                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        string nome = reader.GetString(0);
                        string cidade = reader.GetString(1);
                        double valor = reader.GetDouble(2);
                        string cep = reader.GetString(3);
                        int tempo = reader.GetInt32(4);
                        string email = reader.GetString(5);
                        string bairro = reader.GetString(6);
                        string tel = reader.GetString(7);
                        string endereco = reader.GetString(8);
                        string situacao = reader.GetString(9);
                      
                        txtNome.Text = nome;
                        txtTel.Text = tel;
                        txtCidade.Text = cidade;
                        txtEmail.Text = email;
                        txtValorFrete.Text = Convert.ToString(valor);
                        txtEndereco.Text = endereco;
                        txtCep.Text = cep;
                        txtTempoEntrega.Text = Convert.ToString(tempo);
                        txtBairro.Text = bairro;
                        cbSituacao.Text = situacao;
                    }
                }
                conn.Close();
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            cmd.CommandText = @"UPDATE Fornecedor SET Nome = @nome, Cidade = @cidade, Valor_Frete = @valor,
                                 CEP = @cep, Tempo_Entrega = @tempo, Email = @email, Bairro = @bairro, Telefone = @tel,
                                        Endereco = @endereco
                               where CNPJ = '" + txtCnpj.Text + "';";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@tel", txtTel.Text);
            cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@valor", Double.Parse(txtValorFrete.Text));
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@cep", txtCep.Text);
            cmd.Parameters.AddWithValue("@tempo",int.Parse(txtTempoEntrega.Text));
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Dados alterados com sucesso!");

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
