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
    public partial class CadAutor : Form
    {


        public CadAutor()
        {
            #region config
            InitializeComponent();
            txtNomeNacio.Enabled = false;
            txtAutor.Texts = Global.nomeAutor;
            txtNomeNacio.Texts = Global.usarNomeNacionalidade;
            #endregion
        }

        private void btnMinimizate_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomeAutor__TextChanged(object sender, EventArgs e)
        {
        }

        private void btnPesquidarIdi_Click(object sender, EventArgs e)
        {
            #region consultaNacionalidade

            Nacionalidade nacionalidade = new Nacionalidade();
            nacionalidade.ShowDialog();
            txtNomeNacio.Texts = Global.usarNomeNacionalidade;

            #endregion
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            txtNomeNacio.Texts = Global.usarNomeNacionalidade.ToUpper();

        }

        public void btnConfirmar_Click(object sender, EventArgs e)
        {
            #region adicionando_autor
            Sql.conector.Close();
            try
            {

                Sql.conector.Open();

                Global.pkBuscada = buscaPk();

                Sql.conector.Close();
                Sql.conector.Open();
                string Autor = txtAutor.Texts.ToUpper();
                string query = "INSERT INTO Autor (nome_autor, fk_id_nacionalidade_autor) VALUES (@autor, @fkNacio)";
                using (SqlCommand inserir = new SqlCommand(query, Sql.conector))
                {
                    inserir.Parameters.AddWithValue("@autor", Autor);
                    inserir.Parameters.AddWithValue("@fkNacio", Global.pkBuscada);
                    inserir.ExecuteNonQuery();
                }
                Sql.conector.Close();
                MessageBox.Show("Sucesso!");
                Global.usarNomeAutor = txtAutor.Texts;
                Global.UsarAutor = Global.nomeAutor.ToUpper();

            }
            catch (SqlException ex)
            {
                string err = ex.Message;
                MessageBox.Show(err);
                Sql.conector.Close();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                MessageBox.Show(err);
                Sql.conector.Close();
            }
            finally
            {
                Sql.conector.Close();
            }


            #endregion
        }

        private void txtAutor__TextChanged(object sender, EventArgs e)
        {


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Recarregar();
        }

        public void Recarregar()
        {
            this.Hide();
            CadAutor autor = new CadAutor();
            autor.ShowDialog();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Global.pkBuscada);
           // MessageBox.Show(Global.pkNacio);
        }

        #region metodo_secreto_pk_to_string
        public string buscaPk()
        {
            string resultado = string.Empty;

            string query = "SELECT pk_id_nacionalidade FROM Nacionalidade WHERE nome_nacionalidade = @usarNomeNacionalidade";
            using (SqlCommand buscapk = new SqlCommand(query, Sql.conector))
            {
                buscapk.Parameters.AddWithValue("@usarNomeNacionalidade", Global.usarNomeNacionalidade);
                using(SqlDataReader reader = buscapk.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        resultado = reader["pk_id_nacionalidade"].ToString();
                    }
                }
            }
            return resultado;
            

        }
        #endregion
    }
}

