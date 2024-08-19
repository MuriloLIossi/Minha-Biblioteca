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



    }
}
