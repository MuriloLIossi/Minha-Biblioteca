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
    public partial class CadLivro : Form
    {

        public CadLivro()
        {
            InitializeComponent();


            #region configs
            if (Global.refresh == 0)
            {
                Global.nomeAutor = String.Empty;
            }
            txtAutor.Texts = Global.usarNomeAutor;
            txtIdioma.Texts = Global.usarNomeIdioma;
            txtAutor.Enabled = false;
            txtIdioma.Enabled = false;
            txtEditora.Enabled = false;
            txtTombo.Enabled = false;
            cbbTipo.Texts = Global.usarTipoPub;
            TremComArray();
            Global.UsarIdioma = "";


            #endregion

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void btnMinimizate_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizate_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void lblEditora_Click(object sender, EventArgs e)
        {

        }

        private void txtTitulo__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Funcoes.zerador();

        }

        private void btnGerarT_Click(object sender, EventArgs e)
        {
            #region gerador_tombo

            do
            {
                Global.resultado = Funcoes.GerarTombo1();
                try
                {
                    Sql.conector.Open();

                    SqlCommand verificar = new SqlCommand("SELECT tombo_livro FROM Livro WHERE tombo_livro = '" + Global.resultado + "'", Sql.conector);
                    Global.verificado = verificar.ExecuteReader().HasRows;

                }
                catch (SqlException ex)
                {

                    string msg = ex.ToString();

                }

            }
            while (Global.verificado == true);

            if (Global.verificado == false)
            {
                txtTombo.Texts = Global.resultado.ToString();
                btnGerarT.Visible = false;
            }
            #endregion
        }

        private void btnPesqAutor_Click(object sender, EventArgs e)
        {
            #region Autor

            Autor autor1 = new Autor();
            autor1.ShowDialog();
            if(Global.refresh != 0)
            txtAutor.Text = Global.usarNomeAutor.ToUpper();
            #endregion
            Global.nomeAutor = String.Empty;
            txtAutor.Texts = Global.UsarAutor;



        }

        private void txtAutor__TextChanged(object sender, EventArgs e)
        {
            txtAutor.Text = Global.usarNomeAutor.ToUpper();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Recarregar();
        }

        public void Recarregar()
        {
            this.Hide();
            CadLivro frm = new CadLivro();
            frm.ShowDialog();
            Global.refresh = Global.refresh + 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Funcoes.zerador();
        }

        private void btnPesquidarIdi_Click(object sender, EventArgs e)
        {
            Global.nomeIdioma = String.Empty;
            idioma idioma = new idioma();
            idioma.ShowDialog();
            if(Global.UsarIdioma != String.Empty)
            {
                txtIdioma.Texts = Global.UsarIdioma.ToUpper();
            }
        }

        private void txtIdioma__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void TremComArray()
        {
            Global.andarPk = 1;


            try
            {
                for (Global.andarPk = 1; Global.andarPk <= 6; Global.andarPk++)
                {
                    Sql.conector.Open();
                    SqlCommand procurar = new SqlCommand("SELECT nome_tipo_publicacao FROM Tipo_publicacao WHERE pk_id_tipo_publicacao = " + Global.andarPk + " ", Sql.conector);
                    SqlDataReader ler = procurar.ExecuteReader();
                    if (ler.Read())
                    {
                        Global.nomeTipoPub[Global.andarPk - 1] = ler["nome_tipo_publicacao"].ToString();

                    }
                    Sql.conector.Close();
                }

            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }

            cbbTipo.Items.Clear();

            for (int i = 0; i < Global.nomeTipoPub.Length; i++)
            {
                if (!string.IsNullOrEmpty(Global.nomeTipoPub[i])) // Verifica se o item não está vazio
                {
                    cbbTipo.Items.Add(Global.nomeTipoPub[i]);
                }

            }


        }

        private void rjComboBox1_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cbbTipo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
           Global.usarTipoPub = cbbTipo.SelectedItem.ToString();
        }

        private void btnPesquisarEd_Click(object sender, EventArgs e)
        {
            //Editora ed = new Editora();
            //ed.ShowDialog();
        }

        private void txtEditora__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
