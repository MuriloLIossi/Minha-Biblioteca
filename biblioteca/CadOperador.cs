using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class CadOperador : Form
    {
        public CadOperador()
        {
            InitializeComponent();
        }

        private void txtUsername__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string usernameOp = txtUser.Texts;
            string nomeOp = txtName.Texts;
            string senhaOp = txtPass.Texts;
            bool verificarUser;



            try
            {

                Sql.conector.Open();
                string queryUsername = "SELECT username_operador FROM Operador WHERE username_operador = @username";
                using (SqlCommand usernamepesq = new SqlCommand(queryUsername, Sql.conector))
                {
                    usernamepesq.Parameters.AddWithValue("@username", usernameOp);
                    verificarUser = usernamepesq.ExecuteReader().HasRows;
                    Sql.conector.Close();

                }

                if (verificarUser != true)
                {
                    Sql.conector.Open();
                    Global.senhaCript = BCrypt.Net.BCrypt.HashPassword(senhaOp, workFactor: 12);
                    string queryInsertOp = "INSERT INTO Operador (nome_operador, username_operador, senha_operador, fk_id_tipo_usuario) VALUES (@nome, @username, @senha, 1)";
                    using (SqlCommand insertOperador = new SqlCommand(queryInsertOp, Sql.conector))
                    {
                        insertOperador.Parameters.AddWithValue("@nome", nomeOp);
                        insertOperador.Parameters.AddWithValue("@username", usernameOp);
                        insertOperador.Parameters.AddWithValue("@senha", Global.senhaCript);
                        insertOperador.ExecuteNonQuery();
                        MessageBox.Show("Operador cadastrado com sucesso!");
                        Sql.conector.Close();
                    }
                    Sql.conector.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar o operador. Username já existente.");
                    Sql.conector.Close();
                }
                Sql.conector.Close();
            }
            catch (SqlException ex) { MessageBox.Show($"Ocorreu um erro: {ex.Message}"); Sql.conector.Close(); }
            catch (Exception ex) { MessageBox.Show($"Ocorreu um erro: {ex.Message}"); Sql.conector.Close(); }
            finally { Sql.conector.Close(); }
        }

        private void txtSenha__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
