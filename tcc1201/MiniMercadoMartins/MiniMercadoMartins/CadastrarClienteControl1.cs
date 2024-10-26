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
    public partial class CadastrarClienteControl1 : UserControl 
    {
        SqlConnection conn = new SqlConnection("Data Source = PAULO-PC;" + "Initial catalog = MiniMercadoMartins;" + "Integrated security = SSPI;");
        SqlCommand cmd = new SqlCommand();
        public CadastrarClienteControl1() 
        {
            InitializeComponent();
            cmd.Connection = conn;
        }

        private void CadastrarClienteControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text;
            bool tem = false;

            cmd.CommandText = @"select cpf from Cliente where cpf = @cpf";
            cmd.Parameters.AddWithValue("@cpf", cpf);

            conn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            tem = rdr.HasRows;

            conn.Close();

            if (tem)
            {
                MessageBox.Show("Cliente Existente");
            }
            else if (txtCpf.Text != "")
             
            {
                cmd.CommandText = @"insert into Cliente (CPF, Nome, Data_Nascimento, Endereco, Celular, Email, Profissao, Sexo, Situacao) values (@cpf2, @nome, @DataNascimento, @endereco, @cel, @email, @profissao, @sexo, 'Ativo');";
                cmd.Parameters.AddWithValue("@cpf2", txtCpf.Text);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@DataNascimento", txtDataNascimento.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@cel", txtCelular.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@profissao", cbProfissao.Text);
                cmd.Parameters.AddWithValue("@sexo", cbSexo.Text);


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Campo CPF obrigatorio");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtEmail.Text = "";
            txtDataNascimento.Text = "";
            txtCpf.Text = "";
            txtCelular.Text = "";
            cbSexo.Text = "";
            cbProfissao.Text = "";
        }

        private void txtDataNascimento_TextChanged(object sender, EventArgs e)
        {
           
            
            // DateTime data = new DateTime();
           // this.Text = txtDataNascimento.Text.ToString("dd/MM/yyyy", data);
            //this.txtDataNascimento = Convert.ToDateTime(this.txtDataNascimento).ToString("dd/MM/yyyy");
            /* DateTime data = new DateTime();
            if (txtDataNascimento.Text == "{0: dd")
            {
                txtDataNascimento.Text = "/";
            }*/
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text;
            bool tem = false;

            cmd.CommandText = @"select cpf from Cliente where cpf = @cpf";
            cmd.Parameters.AddWithValue("@cpf", cpf);

            conn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            tem = rdr.HasRows;

            conn.Close();

            if (tem)
            {
                MessageBox.Show("Cliente Existente");
            }
            else if (txtCpf.Text != "")

            {
                cmd.CommandText = @"insert into Cliente (CPF, Nome, Data_Nascimento, Endereco, Celular, Email, Profissao, Sexo, Situacao) values (@cpf2, @nome, @DataNascimento, @endereco, @cel, @email, @profissao, @sexo, 'Ativo');";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cpf2", txtCpf.Text);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@DataNascimento", txtDataNascimento.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@cel", txtCelular.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@profissao", cbProfissao.Text);
                cmd.Parameters.AddWithValue("@sexo", cbSexo.Text);


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Campo CPF obrigatorio");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtEmail.Text = "";
            txtDataNascimento.Text = "";
            txtCpf.Text = "";
            txtCelular.Text = "";
            cbSexo.Text = "";
            cbProfissao.Text = "";
        }
    }
}
