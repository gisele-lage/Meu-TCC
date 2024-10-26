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
    public partial class ConsultarFuncionarioControl1 : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source = PAULO-PC;" + "Initial catalog = MiniMercadoMartins;" + "Integrated security = SSPI;");
        SqlCommand cmd = new SqlCommand();
        public ConsultarFuncionarioControl1()
        {
            InitializeComponent();
            cmd.Connection = conn;
            cbSituacao.Visible = false;
            cbCargo.Visible = false;
            txtFiltro.Visible = true;
        }


        private void ConsultarFuncionarioControl1_Load(object sender, EventArgs e)
        {

        }
        private void cbConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbConsultar.Text == "Cargo")
            {
                txtFiltro.Clear();
                txtFiltro.Visible = false;
                cbSituacao.Visible = false;
                cbCargo.Visible = true;
            }
            else if (cbConsultar.Text == "Situaçao")
            {
                txtFiltro.Clear();
                cbSituacao.Visible = true;
                cbCargo.Visible = false;
                txtFiltro.Visible = false;
            }
            else
            {
                txtFiltro.Clear();
                cbCargo.Visible = false;
                cbSituacao.Visible = false;
                txtFiltro.Visible = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (cbConsultar.Text == "Nome")
            {


                cmd.CommandText = @"select CPF,  Nome, Data_Nascimento, Endereco, Telefone, Cargo, Email, Sexo, Banco, Agencia, Senha_Login, Salario,
                            Conta, Situacao, Dia_UtilInicial, Dia_UtilFinal, Dia_FolgaI, Dia_FolgaII, 
                           Hora_Entrada = 
                           (select  FORMAT (CAST (Hora_Entrada  as datetime2), 'HH:mm')),  Hora_Saida =
                         (select  FORMAT (CAST (Hora_Saida  as datetime2), 'HH:mm')),  Hora_IntervaloI =
                       (select  FORMAT (CAST (Hora_IntervaloI  as datetime2), 'HH:mm')), Hora_IntervaloF = 
                  (select  FORMAT (CAST (Hora_IntervaloF  as datetime2), 'HH:mm'))  from Funcionario  order by Nome;";


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else if (cbConsultar.Text == "Cargo")
            {
                cmd.CommandText = @" select CPF,  Nome, Data_Nascimento, Endereco, Telefone, Cargo, Email, Sexo, Banco, Agencia, Senha_Login, Salario,
                            Conta, Situacao, Dia_UtilInicial, Dia_UtilFinal, Dia_FolgaI, Dia_FolgaII,
                           Hora_Entrada = 
                           (select  FORMAT (CAST (Hora_Entrada  as datetime2), 'HH:mm')),  Hora_Saida =
                         (select  FORMAT (CAST (Hora_Saida  as datetime2), 'HH:mm')),  Hora_IntervaloI =
                       (select  FORMAT (CAST (Hora_IntervaloI  as datetime2), 'HH:mm')), Hora_IntervaloF = 
                  (select  FORMAT (CAST (Hora_IntervaloF  as datetime2), 'HH:mm'))  from Funcionario order by Cargo;";


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            else if (cbConsultar.Text == "Situacao")
            {
                cmd.CommandText = @"select CPF,  Nome, Data_Nascimento, Endereco, Telefone, Cargo, Email, Sexo, Banco, Agencia, Senha_Login, Salario,
                            Conta, Situacao, Dia_UtilInicial, Dia_UtilFinal, Dia_FolgaI, Dia_FolgaII,
                           Hora_Entrada = 
                           (select  FORMAT (CAST ( Hora_Entrada  as datetime2), 'HH:mm')),  Hora_Saida =
                         (select  FORMAT (CAST (Hora_Saida  as datetime2), 'HH:mm')),   Hora_IntervaloI =
                       (select  FORMAT (CAST ( Hora_IntervaloI  as datetime2), 'HH:mm')),Hora_IntervaloF = 
                  (select  FORMAT (CAST (Hora_IntervaloF  as datetime2), 'HH:mm'))  from Funcionario  order by Situacao;";


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            else
            {
                cmd.CommandText = @"select CPF,  Nome, Data_Nascimento, Endereco, Telefone, Cargo, Email, Sexo, Banco, Agencia, Senha_Login, Salario,
                            Conta, Situacao, Dia_UtilInicial, Dia_UtilFinal, Dia_FolgaI, Dia_FolgaII,
                           Hora_Entrada  = 
                           (select  FORMAT (CAST (Hora_Entrada   as datetime2), 'HH:mm')), Hora_Saida =
                         (select  FORMAT (CAST (Hora_Saida  as datetime2), 'HH:mm')),  Hora_IntervaloI =
                       (select  FORMAT (CAST ( Hora_IntervaloI  as datetime2), 'HH:mm')), Hora_IntervaloF = 
                  (select  FORMAT (CAST (Hora_IntervaloF  as datetime2), 'HH:mm'))  from Funcionario  order by Salario;";


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
            if (cbConsultar.Text == "Nome")
            {


                cmd.CommandText = @"select CPF,  Nome, Data_Nascimento, Endereco, Telefone, Cargo, Email, Sexo, Banco, Agencia, Senha_Login, Salario,
                            Conta, Situacao, Dia_UtilInicial, Dia_UtilFinal, Dia_FolgaI, Dia_FolgaII,
                           Hora_Entrada  = 
                           (select  FORMAT (CAST (Hora_Entrada   as datetime2), 'HH:mm')), Hora_Saida =
                         (select  FORMAT (CAST (Hora_Saida  as datetime2), 'HH:mm')),  Hora_IntervaloI =
                       (select  FORMAT (CAST ( Hora_IntervaloI  as datetime2), 'HH:mm')), Hora_IntervaloF = 
                  (select  FORMAT (CAST (Hora_IntervaloF  as datetime2), 'HH:mm'))  from Funcionario  where Nome = '" + txtFiltro.Text + "'";


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else if (cbConsultar.Text == "Cargo")
            {
                cmd.CommandText = @"select CPF,  Nome, Data_Nascimento, Endereco, Telefone, Cargo, Email, Sexo, Banco, Agencia, Senha_Login, Salario,
                            Conta, Situacao, Dia_UtilInicial, Dia_UtilFinal, Dia_FolgaI, Dia_FolgaII,
                           Hora_Entrada  = 
                           (select  FORMAT (CAST (Hora_Entrada   as datetime2), 'HH:mm')), Hora_Saida =
                         (select  FORMAT (CAST (Hora_Saida  as datetime2), 'HH:mm')),  Hora_IntervaloI =
                       (select  FORMAT (CAST ( Hora_IntervaloI  as datetime2), 'HH:mm')), Hora_IntervaloF = 
                  (select  FORMAT (CAST (Hora_IntervaloF  as datetime2), 'HH:mm'))  from Funcionario   where Cargo = '" + cbCargo.Text + "'";


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            else if (cbConsultar.Text == "Salario")
            {
                cmd.CommandText = @"select CPF,  Nome, Data_Nascimento, Endereco, Telefone, Cargo, Email, Sexo, Banco, Agencia, Senha_Login, Salario,
                            Conta, Situacao, Dia_UtilInicial, Dia_UtilFinal, Dia_FolgaI, Dia_FolgaII,
                           Hora_Entrada  = 
                           (select  FORMAT (CAST (Hora_Entrada   as datetime2), 'HH:mm')), Hora_Saida =
                         (select  FORMAT (CAST (Hora_Saida  as datetime2), 'HH:mm')),  Hora_IntervaloI =
                       (select  FORMAT (CAST ( Hora_IntervaloI  as datetime2), 'HH:mm')), Hora_IntervaloF = 
                  (select  FORMAT (CAST (Hora_IntervaloF  as datetime2), 'HH:mm'))  from Funcionario  where Salario = '" + txtFiltro.Text + "'";


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                cmd.CommandText = @"select CPF,  Nome, Data_Nascimento, Endereco, Telefone, Cargo, Email, Sexo, Banco, Agencia, Senha_Login, Salario,
                            Conta, Situacao, Dia_UtilInicial, Dia_UtilFinal, Dia_FolgaI, Dia_FolgaII,
                           Hora_Entrada  = 
                           (select  FORMAT (CAST (Hora_Entrada   as datetime2), 'HH:mm')), Hora_Saida =
                         (select  FORMAT (CAST (Hora_Saida  as datetime2), 'HH:mm')),  Hora_IntervaloI =
                       (select  FORMAT (CAST ( Hora_IntervaloI  as datetime2), 'HH:mm')), Hora_IntervaloF = 
                  (select  FORMAT (CAST (Hora_IntervaloF  as datetime2), 'HH:mm'))  from Funcionario   where Situacao = '" + cbSituacao.Text + "'";


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

        private void lblConsultar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
