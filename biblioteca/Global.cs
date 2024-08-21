using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace biblioteca
{


    public class Global
    {

        SqlConnection conector = new SqlConnection(@"Data Source=MURILOIOSSI\IOSSI; Initial Catalog = BIBLIOTECAPROJETO; Integrated Security = true");
        
        

        public static int Pk_operador;
        public static bool rbCodAuxv;
        public static bool rbCodUserv;
        public static bool verificado;
        public static int resultado;
        public static string nomeAutor;
        public static string usarNomeAutor;
        public static bool resultNomeAutor;
        public static string nomeNacionalidade;
        public static bool resultNomeNacionalidade;
        public static string usarNomeNacionalidade;
        public static string pkBuscada;
        public static int refresh;
        public static string nomeIdioma;
        public static string usarNomeIdioma;
        public static string idioma;
        public static bool resultIdioma;
        public static string TipoPub;
        public static int andarPk;
        public static string usarTipoPub;
        public static string[] nomeTipoPub = new string[6];
        public static string cidade;
        public static string usarCidade;
        public static string[] nomeEstado = new string[27];
        public static int forLegal;
        public static int forLegal2;
        public static int andarCidade;
        public static string UsarAutor;
        public static string UsarIdioma;
        public static string Idioma;
    }

    

}
