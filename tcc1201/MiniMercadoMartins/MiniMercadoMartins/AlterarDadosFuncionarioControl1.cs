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
    public partial class AlterarDadosFuncionarioControl1 : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source = PAULO-PC;" + "Initial catalog = MiniMercadoMartins;" + "Integrated security = SSPI;");
        SqlCommand cmd = new SqlCommand();
        public AlterarDadosFuncionarioControl1()
        {
            InitializeComponent();
            cmd.Connection = conn;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AlterarDadosFuncionarioControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cmd.CommandText = @"UPDATE Funcionario SET Nome = @nome,  Telefone = @tel,  Data_Nascimento = @data, Email = @email,
                               Cargo = @cargo, Endereco = @endereco, Sexo = @sexo, Banco = @banco, Agencia = @agencia,
                                Senha_Login = @senha, Salario = @sal, Conta = @conta, Hora_Entrada = @horaI, Hora_Saida = @horaF,
                                Hora_IntervaloI = @intervaloI, Hora_IntervaloF = @intervaloF, Dia_UtilInicial = @diaI, Dia_UtilFinal = @diaF,
                                 Dia_FolgaI = @diaFolgaI, Dia_FolgaII = @diaFolgaII, Situacao = @situacao  where CPF = '" + txtCpf.Text + "';";
            cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                cmd.Parameters.AddWithValue("@Data", txtDataNascimento.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Cargo", cbCargo.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@sexo", cbSexo.Text);
            cmd.Parameters.AddWithValue("@banco", txtBanco.Text);
            cmd.Parameters.AddWithValue("@agencia", txtAgencia.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
            cmd.Parameters.AddWithValue("@sal", txtSalario.Text);
            cmd.Parameters.AddWithValue("@conta", txtConta.Text);
            cmd.Parameters.AddWithValue("@horaI", txtHora1.Text);
            cmd.Parameters.AddWithValue("@horaF", txtHora2.Text);
            cmd.Parameters.AddWithValue("@intervaloI", txtIntervalo1.Text);
            cmd.Parameters.AddWithValue("@intervaloF", txtIntervalo2.Text);
            cmd.Parameters.AddWithValue("@diaI", txtDiaUtil1.Text);
            cmd.Parameters.AddWithValue("@diaF", txtDiaUtil2.Text);
            cmd.Parameters.AddWithValue("@diaFolgaI", cbDiaFolga1.Text);
            cmd.Parameters.AddWithValue("@diaFolgaII", cbDiaFolga2.Text);
            cmd.Parameters.AddWithValue("@situacao", cbSituacao.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Dados alterados com sucesso!");

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text;
            bool tem = false;

            cmd.CommandText = @"select CPF from Funcionario where cpf = '" + txtCpf.Text + "'";
            // cmd.Parameters.AddWithValue("@cpf", cpf);

            conn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            tem = rdr.HasRows;

            conn.Close();

            if (tem)
            {
                cmd.CommandText = @"select Nome, Telefone, Data_Nascimento, Email , Cargo, Endereco, Sexo, Banco,
                                     Agencia, Senha_Login, Conta , Hora_Entrada, Hora_Saida, Hora_IntervaloI,
                                     Hora_IntervaloF , Dia_UtilInicial , Dia_UtilFinal , Dia_FolgaI, Dia_FolgaII, Salario, Situacao
                 from Funcionario where CPF = '" + txtCpf.Text + "'";
                //  cmd.Parameters.AddWithValue("@cpf2", cpf);


                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();



                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        string nome = reader.GetString(0);
                        string tel = reader.GetString(1);
                        DateTime DataNascimento = reader.GetDateTime(2);
                        string data = string.Format("{0: dd/MM/yyyy}", DataNascimento);
                        string email = reader.GetString(3);
                        string cargo = reader.GetString(4);
                        string endereco = reader.GetString(5);
                        string sexo = reader.GetString(6);
                        string banco = reader.GetString(7);
                        string agencia = reader.GetString(8);
                        string senha = reader.GetString(9);
                        string conta = reader.GetString(10);
                        DateTime HoraI = reader.GetDateTime(11);
                        string horai = string.Format("{0: HH:mm}", HoraI);
                        DateTime HoraF = reader.GetDateTime(12);
                        string horaf = string.Format("{0: HH:mm}", HoraF);
                        DateTime IntervaloI = reader.GetDateTime(13);
                        string intervaloi = string.Format("{0: HH:mm}", IntervaloI);
                        DateTime IntervaloF = reader.GetDateTime(14);
                        string intervalof = string.Format("{0: HH:mm}", IntervaloF);

                        string DiaI = reader.GetString(15);
                        string DiaF = reader.GetString(16);
                        string DiaFolgaI = reader.GetString(17);
                        string DiaFolgaII = reader.GetString(18);
                        Double Sal = reader.GetDouble(19);
                        string situacao = reader.GetString(20);


                        txtNome.Text = nome;
                         txtTel.Text = tel;
                         txtDataNascimento.Text = data;
                         txtEmail.Text = email;
                         cbCargo.Text = cargo;
                         txtEndereco.Text = endereco;
                         cbSexo.Text = sexo;
                         txtBanco.Text = banco;
                        txtAgencia.Text = agencia;
                        txtSenha.Text = senha;
                        txtConta.Text = conta;
                        txtHora1.Text = horai;
                        txtHora2.Text = horaf;
                        txtIntervalo1.Text = intervaloi;
                        txtIntervalo2.Text = intervalof;
                        txtDiaUtil1.Text = DiaI;
                        txtDiaUtil2.Text = DiaF;
                        cbDiaFolga1.Text = DiaFolgaI;
                        cbDiaFolga2.Text = DiaFolgaII;
                        txtSalario.Text = Convert.ToString(Sal);
                        cbSituacao.Text = situacao;
                    }
                }
                conn.Close();
            }

        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCargo.Text == "Caixa")
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSexo_Click(object sender, EventArgs e)
        {

        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtAgencia.Text = "";
            txtBanco.Text = "";
            txtConta.Text = "";
            txtCpf.Text = "";
            txtDataNascimento.Text = "";
            txtDiaUtil1.Text = "";
            txtDiaUtil2.Text = "";
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
    }
}
