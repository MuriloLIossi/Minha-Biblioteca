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

namespace biblioteca
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        #region desativado

        // private void AbrirForm<MeuForm>() where MeuForm : Form, new()
        // {
        //  Form formulario;
        //  formulario = pnlMeio.Controls.OfType<MeuForm>().FirstOrDefault();
        // if (formulario != null)
        // {
        //  formulario = new MeuForm();
        //   formulario.TopLevel = false;
        //   formulario.FormBorderStyle = FormBorderStyle.None;
        //    formulario.Dock = DockStyle.Fill;
        //     pnlMeio.Controls.Add(formulario);
        //     pnlMeio.Tag = formulario;
        //      formulario.ShowDialog();
        //     formulario.BringToFront();
        //       formulario.FormClosed += new FormClosedEventHandler(FecharForms);
        //   }
        //  else{
        //       formulario.BringToFront();
        //   }
        // }


        //  private void FecharForms(object sender, EventArgs e)
        // {
        //    if (Application.OpenForms["Form2"] == null)
        //    {

        //     }
        //}
        #endregion
        private void btnMinimizate_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizate_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            #region verificador_login
            if (txtLogin.Texts == "") { 
            
                lblErrUm.Visible = true;

            } else
            {
                lblErrUm.Visible = false;
            }

            if (txtSenha.Texts == "")
            {
                lblErrDois.Visible = true;
            }
            else
            {
                lblErrDois.Visible = false;


                try
                {
                    string user = txtLogin.Texts;
                    string senha = txtSenha.Texts;

                    bool resultado = Sql.LoginVerificador(user, senha);
                    if (resultado)
                    {
                        Principal principal = new Principal();
                        this.Hide();
                        principal.ShowDialog();
                        Sql.conector.Close();
                        //Funcoes.zerador();
                    }
                    else
                    {
                        MessageBox.Show("Usuario não encontrado", "Atenção");
                        Sql.conector.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Sql.conector.Close();
                }

            }
            #endregion
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSenha__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
