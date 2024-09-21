using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public class Funcoes
    {


        public static void StringCon()
        {
            try
            {
                SqlConnection conector = new SqlConnection(@"Data Source=MURILOIOSSI\IOSSI; Initial Catalog = BIBLIOTECAPROJETO; Integrated Security = true");

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }

        public static int CadLivro()
        {

            CadLivro cadlivro = new CadLivro();
            cadlivro.ShowDialog();

            return 0;
        }

        public static int GerarTombo1() 
        {

            Random random = new Random();
            int randomN = random.Next(10000, 100000);


            return randomN; 
        }


        public static void zerador()
        {
            Global.nomeAutor = string.Empty;
            Global.usarNomeAutor = string.Empty;
            Global.resultNomeAutor = false;
            Global.nomeNacionalidade = string.Empty;
            Global.resultNomeNacionalidade = false;
            Global.usarNomeNacionalidade = string.Empty;
            Global.pkBuscada = string.Empty;
            Global.nomeIdioma = string.Empty;
            Global.usarNomeIdioma = string.Empty;
            Global.refresh = 0;
            Global.nomeIdioma = String.Empty;
            Global.resultIdioma = false;
            Global.usarNomeIdioma = String.Empty;

        }

        public static string PegaEditora() 
        {
            try
            {
                Sql.conector.Close();
                Sql.conector.Open();
                string query = $"SELECT pk_id_editora FROM Editora WHERE nome_editora = '{Global.mainEditora}' ";
                using (SqlCommand cmd = new SqlCommand(query, Sql.conector))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Global.editoraPk = reader["pk_id_editora"].ToString();
                        }
                    }
                }
                Sql.conector.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); Sql.conector.Close(); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); Sql.conector.Close(); }
 
            return Global.editoraPk;
        }

        public static string pegaIdioma()
        {

            try
            {
                Sql.conector.Close();
                Sql.conector.Open();
                string query = $"SELECT pk_id_idioma FROM Idioma WHERE nome_idioma = '{Global.UsarIdioma.ToUpper()}' ";
                using (SqlCommand cmd = new SqlCommand(query, Sql.conector))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Global.idiomaPk = reader["pk_id_idioma"].ToString();
                        }
                    }
                }

                Sql.conector.Close();

            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); Sql.conector.Close(); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); Sql.conector.Close(); }

            return Global.idiomaPk;
        }

        public static string pegaAutor()
        {
            try
            {
                Sql.conector.Close();
                Sql.conector.Open();
                string query = $"SELECT pk_id_autor FROM Autor WHERE nome_autor = '{Global.UsarAutor}' ";
                using (SqlCommand cmd = new SqlCommand(query, Sql.conector))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Global.autorPk = reader["pk_id_autor"].ToString();
                        }
                    }
                }

                Sql.conector.Close();

            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); Sql.conector.Close(); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); Sql.conector.Close(); }

            return Global.autorPk;
        }


        public static string pegaTipoPub()
        {
            try
            {
                Sql.conector.Close();
                Sql.conector.Open();
                string query = $"SELECT pk_id_tipo_publicacao FROM Tipo_publicacao WHERE nome_tipo_publicacao = '{Global.usarTipoPub}' ";
                using (SqlCommand cmd = new SqlCommand(query, Sql.conector))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Global.tipoPubPk = reader["pk_id_tipo_publicacao"].ToString();
                        }
                    }
                }

                Sql.conector.Close();

            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); Sql.conector.Close(); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); Sql.conector.Close(); }

            return Global.tipoPubPk;
        }


    }
}
