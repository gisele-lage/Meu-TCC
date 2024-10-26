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
    public partial class FrmLogin : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = PAULO-PC;" + "Initial catalog = MiniMercadoMartins;" + "Integrated security = SSPI;");
        SqlCommand cmd = new SqlCommand();
        public void invisivel()
        {
            lblemail.Visible = false;
            txtEmail.Visible = false;
            pemail.Visible = false;
            lblsenha.Visible = false;
            txtSenha.Visible = false;
            psenha.Visible = false;
        }

        public void visivel()
        {
            lblemail.Visible = true;
            txtEmail.Visible = true;
            pemail.Visible = true;
            lblsenha.Visible = true;
            txtSenha.Visible = true;
            psenha.Visible = true;
        }

        public void mostrar()
        {
            cbOpcoes.Visible = true;
        }

        public void Nmostrar()
        {
            cbOpcoes.Visible = false;
        }


        public FrmLogin()
        {
            InitializeComponent();
            pictureimagem.Visible = false;
            Nmostrar();
            cmd.Connection = conn;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbcargo.Text == "Caixa")
            {
                invisivel();
                pictureimagem.Visible = true;
            }
            else
            {
                visivel();
                pictureimagem.Visible = false;
            }

            if(cbcargo.Text == "Gerente")
            {
                mostrar();
            }
            else
            {
                Nmostrar();
            }

        }

       

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            if (cbcargo.Text == "Caixa")
            {
                this.Visible = false;
                this.Hide();
                FrmCaixa caixa = new FrmCaixa();
                caixa.ShowDialog();
                this.Visible = false;
                this.Close();
            }
            else if (cbcargo.Text == "Administrador")
            {
              //  bool tem;
               // cmd.CommandText = @"select Email from Funcionario where Email = '" + txtEmail.Text + "' AND Cargo = 'Administrador'";

               // conn.Open();

              //  SqlDataReader rdr = cmd.ExecuteReader();

              //  tem = rdr.HasRows;

               // conn.Close();

              //  if (tem)
               // {
                  //  cmd.CommandText = @"select Senha_Login from Funcionario where Email = '" + txtEmail.Text + "' AND Cargo = 'Administrador'";

                 //   conn.Open();

                 //   SqlDataReader reader = cmd.ExecuteReader();

                  //  if (reader.HasRows)
                  //  {
                      //  while (reader.Read())
                      //  {
                          //  string senha = reader.GetString(0);

                         //   if (txtSenha.Text == senha)
                        //    {
                                this.Visible = false;
                                this.Hide();
                                FrmGerenciarFuncionario gereF = new FrmGerenciarFuncionario();
                                gereF.ShowDialog();
                                this.Visible = false;
                                this.Close();
                        //    }
                         //   else
                      //      {
                         //       MessageBox.Show("Senha incorreta!");
                      //      }
                    //    }
                 //   }
             //   }
             //   else
              //  {
              //      MessageBox.Show("Email incorreto!");
             //   }

               
            }
            else if (cbcargo.Text == "Estoquista")
            {

                bool tem;
                cmd.CommandText = @"select Email from Funcionario where Email = '" + txtEmail.Text + "' AND Cargo = 'Estoquista'";

                conn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                tem = rdr.HasRows;

                conn.Close();

                if (tem)
                {
                    cmd.CommandText = @"select Senha_Login from Funcionario where Email = '" + txtEmail.Text + "' AND Cargo = 'Estoquista'";

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string senha = reader.GetString(0);

                            if (txtSenha.Text == senha)
                            {
                                this.Visible = false;
                                this.Hide();
                                FrmGerenciarProduto gereP = new FrmGerenciarProduto();
                                gereP.ShowDialog();
                                this.Visible = false;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Senha incorreta!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Email incorreto!");
                }


                   
            }
            else if (cbcargo.Text == "Gerente")
            {

             

                if(cbOpcoes.Text == "Gerenciar Fornecedor")
                {
                    bool tem;
                    cmd.CommandText = @"select Email from Funcionario where Email = '" + txtEmail.Text + "' AND Cargo = 'Gerente'";

                    conn.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    tem = rdr.HasRows;

                    conn.Close();

                    if (tem)
                    {
                        cmd.CommandText = @"select Senha_Login from Funcionario where Email = '" + txtEmail.Text + "' AND Cargo = 'Gerente'";

                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string senha = reader.GetString(0);

                                if (txtSenha.Text == senha)
                                {
                                    this.Visible = false;
                                    this.Hide();
                                    FrmGerenciarFornecedor telaG = new FrmGerenciarFornecedor();
                                    telaG.ShowDialog();
                                    this.Visible = false;
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Senha incorreta!");
                                }
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Email incorreto!");
                    }


                }

                else if(cbOpcoes.Text == "Alterar Preço de Produto")
                {
                    bool tem;
                    cmd.CommandText = @"select Email from Funcionario where Email = '" + txtEmail.Text + "' AND Cargo = 'Gerente'";

                    conn.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    tem = rdr.HasRows;

                    conn.Close();

                    if (tem)
                    {
                        cmd.CommandText = @"select Senha_Login from Funcionario where Email = '" + txtEmail.Text + "' AND Cargo = 'Gerente'";

                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string senha = reader.GetString(0);

                                if (txtSenha.Text == senha)
                                {
                                    this.Visible = false;
                                    this.Hide();
                                    FrmAlterarPrecoProduto telaG = new FrmAlterarPrecoProduto();
                                    telaG.ShowDialog();
                                    this.Visible = false;
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Senha incorreta!");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email incorreto!");
                    }


                }
                else if(cbOpcoes.Text == "Consultar Dados")
                {
                    bool tem;
                    cmd.CommandText = @"select Email from Funcionario where Email = '" + txtEmail.Text + "' AND Cargo = 'Gerente'";

                    conn.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    tem = rdr.HasRows;

                    conn.Close();

                    if (tem)
                    {
                        cmd.CommandText = @"select Senha_Login from Funcionario where Email = '" + txtEmail.Text + "' AND Cargo = 'Gerente'";

                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string senha = reader.GetString(0);

                                if (txtSenha.Text == senha)
                                {
                                    this.Visible = false;
                                    this.Hide();
                                    FrmConsultarDados dados = new FrmConsultarDados();
                                    dados.ShowDialog();
                                    this.Visible = false;
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Senha incorreta!");
                                }
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Email incorreto!");
                    }

                }
                else
                {
                    MessageBox.Show("Escolha em qual tela deseja entrar!");
                }
            }

            else
            {
                MessageBox.Show("Insira um cargo valido!");
            }

        }
    }
}
