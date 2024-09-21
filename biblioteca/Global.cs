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

        //autor
        public static string nomeAutor; //variavel que iguala txt no form autor
        public static string usarNomeAutor; //variavel final do nome do autor
        public static bool resultNomeAutor; //booleana de hasrows


        public static int Pk_operador;
        public static bool rbCodAuxv;
        public static bool rbCodUserv;
        public static bool verificado;
        public static int resultado;

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
        //public static string cidade;
        //public static string usarCidade;
        public static string[] nomeEstado = new string[31];
        public static int forLegal;
        public static int forLegal2;
        public static int andarCidade;
        public static string UsarAutor;
        public static string UsarIdioma;
        public static string Idioma;
        public static string Estado;
        public static string Cidade;
        //public static string usarNomeCidade;
        public static int pkEstado;
        public static string usarNomeCidade;
        public static string mainCidade;
        //public static string cidade2;
        public static string editora;
        public static string usarEditora;
        public static string mainEditora;
        public static string seletor2;
        public static string cidade_usared;
        public static int pk_cidade;


        //insert de livros
        public static string editoraPk;
        public static string idiomaPk;
        public static string autorPk;
        public static string tipoPubPk;

    }

    

}
