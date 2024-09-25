using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace biblioteca
{
    public class Sql
    {

        public static SqlConnection conector = new SqlConnection(@"Data Source=MURILOIOSSI\IOSSI; Initial Catalog = BIBLIOTECAPROJETO; Integrated Security = true");


        public static bool LoginVerificador(string user, string senha)
        {
            

            if(user != "" && senha != "")
            {
                try
                {
                    Sql.conector.Open();
                    string query = "SELECT username_operador FROM Operador WHERE username_operador = @user";
                    using (SqlCommand verificar = new SqlCommand(query, Sql.conector))
                    {
                        verificar.Parameters.AddWithValue("@user", user);
                        Cookies.continuar = verificar.ExecuteReader().HasRows;
                        Sql.conector.Close();
                        if (Cookies.continuar)
                        {
                            Sql.conector.Open();
                            string query2 = "SELECT senha_operador FROM Operador WHERE username_operador = @usernameOp";
                            using (SqlCommand verificar2 = new SqlCommand(query2, Sql.conector))
                            {
                                verificar2.Parameters.AddWithValue("@usernameOp", user);
                                using (SqlDataReader readerSenha = verificar2.ExecuteReader())
                                {
                                    if (readerSenha.Read())
                                    {
                                        Cookies.senhaResult = readerSenha["senha_operador"].ToString();
                                    }

                                }
                            }

                            Sql.conector.Close();
                        }
                        else
                        {
                            Cookies.verificar = false;
                        }

                        Sql.conector.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    Sql.conector.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Sql.conector.Close();
                }
                finally
                {
                    Sql.conector.Close();
                }
            }

            Cookies.verificar = BCrypt.Net.BCrypt.Verify(senha, Cookies.senhaResult);
            
            if(Cookies.continuar && Cookies.verificar)
            {
                Cookies.resultado = true;
            }
 
            return Cookies.resultado;
        }

    }
}
