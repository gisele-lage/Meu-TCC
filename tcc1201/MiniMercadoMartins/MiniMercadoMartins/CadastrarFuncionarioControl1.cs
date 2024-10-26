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
    public partial class CadastrarFuncionarioControl1 : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source = PAULO-PC;" + "Initial catalog = MiniMercadoMartins;" + "Integrated security = SSPI;");
        SqlCommand cmd = new SqlCommand();
        public CadastrarFuncionarioControl1()
        {
            InitializeComponent();
            cmd.Connection = conn;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  if (cbCargo.Text == "Administrador")
            {
                txtEndereco.Enabled = false;
                lblEndereco.Enabled = false;
                txtTel.Enabled = false;
                lblTel.Enabled = false;
                txtDataNascimento.Enabled = false;
                lblDataNascimento.Enabled = false;
                cbSexo.Enabled = false;
                lblSexo.Enabled = false;
                txtSalario.Enabled = false;
                lblSalario.Enabled = false;
               // txtNome.Enabled = false;
               // lblNome.Enabled = false;
               // txtCpf.Enabled = false;
                //lblCpf.Enabled = false;
            }*/
             if(cbCargo.Text == "Caixa")
            {
                txtSenha.Enabled = false;
                lblSenha.Enabled = false;
                txtCpf.Enabled = true;
                lblCpf.Enabled = true;
                txtDataNascimento.Enabled = true;
                lblDataNascimento.Enabled = true;
                txtEmail.Enabled = true;
                lblEmail.Enabled = true;
                txtEndereco.Enabled = true;
                lblEndereco.Enabled = true;
                txtNome.Enabled = true;
                lblNome.Enabled = true;
                txtSalario.Enabled = true;
                lblSalario.Enabled = true;
                txtTel.Enabled = true;
                lblTel.Enabled = true;
                cbSexo.Enabled = true;
                lblSexo.Enabled = true;
            }
            else
            {
                txtCpf.Enabled = true;
                lblCpf.Enabled = true;
                txtDataNascimento.Enabled = true;
                lblDataNascimento.Enabled = true;
                txtEmail.Enabled = true;
                lblEmail.Enabled = true;
                txtEndereco.Enabled = true;
                lblEndereco.Enabled = true;
                txtNome.Enabled = true;
                lblNome.Enabled = true;
                txtSalario.Enabled = true;
                lblSalario.Enabled = true;
                txtSenha.Enabled = true;
                lblSenha.Enabled = true;
                txtTel.Enabled = true;
                lblTel.Enabled = true;
                cbSexo.Enabled = true;
                lblSexo.Enabled = true;
            }
        }

        private void lblTel_Click(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAte_Click(object sender, EventArgs e)
        {

        }

        private void lblDiasUteis_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblIntervalo_Click(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblConta_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtAgencia.Text = "";
            txtBanco.Text = "";
            txtConta.Text = "";
            txtCpf.Text = "";
            txtDataNascimento.Text = "";
            cbDiaUtil1.Text = "";
            cbDiaUtil2.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtHora1.Text = "";
            txtHora2.Text = "";
            txtIntervalo1.Text = "";
            txtIntervalo2.Text = "";
            txtNome.Text = "";
            txtSalario.Text = "";
            txtSenha.Text = "";
            txtTel.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
          //  string cpf = txtCpf.Text;
          
            bool tem = false;
          

            cmd.CommandText = @"select CPF, Email from Funcionario where CPF = '"+txtCpf.Text+"'";
           // cmd.Parameters.AddWithValue("@cpf", cpf);
           

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
                cmd.CommandText = @"insert into Funcionario (CPF,  Nome, Data_Nascimento, Endereco, Telefone, Cargo, Email, Sexo, Banco, Agencia, Senha_Login, Salario, Conta, 
                                                             Hora_Entrada, Hora_Saida, Hora_IntervaloI, Hora_IntervaloF, Dia_UtilInicial, Dia_UtilFinal, Dia_FolgaI, Dia_FolgaII, Situacao) 
                                  values (@cpf2, @nome, @DataNascimento, @endereco, @tel, @cargo, @email, @sexo, @banco, @agencia, @senha, 
                                           @sal, @conta, @horaI, @horaF, @intervaloI, @intervaloF, @diaI, @diaF, @diaFolgaI, @diaFolgaII, 'Ativo');";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cpf2", txtCpf.Text);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@DataNascimento", txtDataNascimento.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@sexo", cbSexo.Text);
                cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
                cmd.Parameters.AddWithValue("@banco", txtBanco.Text);
                cmd.Parameters.AddWithValue("@agencia", txtAgencia.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                cmd.Parameters.AddWithValue("@sal", txtSalario.Text);
                cmd.Parameters.AddWithValue("@conta", txtConta.Text);
                cmd.Parameters.AddWithValue("@horaI",txtHora1.Text);
                cmd.Parameters.AddWithValue("@horaF", txtHora2.Text);
                cmd.Parameters.AddWithValue("@intervaloI", txtIntervalo1.Text);
                cmd.Parameters.AddWithValue("@intervaloF", txtIntervalo2.Text);
                cmd.Parameters.AddWithValue("@diaI", cbDiaUtil1.Text);
                cmd.Parameters.AddWithValue("@diaF", cbDiaUtil2.Text);
                cmd.Parameters.AddWithValue("@diaFolgaI", cbDiaFolga1.Text);
                cmd.Parameters.AddWithValue("@diaFolgaII", cbDiaFolga2.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cadastro realizado com sucesso!");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarFuncionarioControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
