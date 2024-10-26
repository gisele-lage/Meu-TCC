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
    public partial class AlterarDadosControl1 : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source = PAULO-PC;" + "Initial catalog = MiniMercadoMartins;" + "Integrated security = SSPI;");
        SqlCommand cmd = new SqlCommand();
        public AlterarDadosControl1()
        {
            InitializeComponent();
            cmd.Connection = conn;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text;
            bool tem = false;

            cmd.CommandText = @"select CPF from Cliente where cpf = '" + txtCpf.Text + "'";
            // cmd.Parameters.AddWithValue("@cpf", cpf);

            conn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            tem = rdr.HasRows;

            conn.Close();

            if (tem)
            {
                cmd.CommandText = @"select Nome, Celular, Data_Nascimento, Email , Profissao, Endereco, Sexo, Situacao  
                 from Cliente where CPF = '" + txtCpf.Text + "'";
                //  cmd.Parameters.AddWithValue("@cpf2", cpf);


                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();



                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       
                        string nome = reader.GetString(0);
                        string cel = reader.GetString(1);
                        DateTime DataNascimento = reader.GetDateTime(2);
                        string data = string.Format("{0: dd/MM/yyyy}",DataNascimento);
                        string email = reader.GetString(3);
                        string profissao = reader.GetString(4);
                        string endereco = reader.GetString(5);
                        string sexo = reader.GetString(6);
                        string situacao = reader.GetString(7);


                        txtNome.Text = nome;
                        txtCelular.Text = cel;
                        txtDataNascimento.Text = data;
                        txtEmail.Text = email;
                        cbProfissao.Text = profissao;
                        txtEndereco.Text = endereco;
                        cbSexo.Text = sexo;
                        cbSituacao.Text = situacao;



                    }
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Cliente inexistente!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            cmd.CommandText = @"UPDATE Cliente SET Nome = @nome,  Celular = @cel,  Data_Nascimento = @data, Email = @email,
                               Profissao = @profissao, Endereco = @endereco, Sexo = @sexo, Situacao = @situacao   
                                 where CPF = '" + txtCpf.Text + "';";

            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cel", txtCelular.Text);
            cmd.Parameters.AddWithValue("@Data", txtDataNascimento.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@profissao", cbProfissao.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@sexo", cbSexo.Text);
            cmd.Parameters.AddWithValue("@situacao", cbSituacao.Text);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Dados alterados com sucesso!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtEmail.Text = "";
            txtDataNascimento.Text = "";
            txtCpf.Text = "";
            txtCelular.Text = "";
            //Console.(cbSexo.Text);
            cbProfissao.Text = "";
        }

        private void AlterarDadosControl1_Load(object sender, EventArgs e)
        {

        }
    }
}

