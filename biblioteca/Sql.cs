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
                    SqlCommand verificar = new SqlCommand("SELECT * FROM Operador WHERE username_operador = '" + user + "' AND senha_operador = '" + senha + "' ", Sql.conector);
                    Cookies.resultado = verificar.ExecuteReader().HasRows;
                    Sql.conector.Close();
                }
                catch (SqlException ex) 
                {
                    MessageBox.Show(ex.ToString());
                    Sql.conector.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Sql.conector.Close();
                }
                finally
                {
                    Sql.conector.Close();
                }
            }

            return Cookies.resultado;
        }

    }
}
