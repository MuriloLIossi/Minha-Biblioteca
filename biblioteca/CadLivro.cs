using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            txtTitulo.Select();


            #region configs
            if (Global.refresh == 0)
            {
                Global.nomeAutor = String.Empty;
            }
            txtAutor.Texts = Global.usarNomeAutor;
            txtIdioma.Texts = Global.usarNomeIdioma;
            txtAutor.Enabled = false;
            txtIdioma.Enabled = false;
            txtEditoras.Enabled = false;
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
            InsertLivro();
            MessageBox.Show("Clicado");

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
                lblGerar.Visible = false;
            }
            #endregion
        }

        private void btnPesqAutor_Click(object sender, EventArgs e)
        {
            #region Autor

            Autor autor1 = new Autor();
            autor1.ShowDialog();
            //txtAutor.Text = Global.usarNomeAutor.ToUpper() ?? "";
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

        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {


        }

        private void btnPesquidarIdi_Click(object sender, EventArgs e)
        {
            Global.nomeIdioma = String.Empty;
            idioma idioma = new idioma();
            idioma.ShowDialog();
            if (Global.UsarIdioma != String.Empty)
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
                    Sql.conector.Close();
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
            Editora ed = new Editora();
            ed.ShowDialog();
            txtEditoras.Texts = Global.mainEditora;

        }

        private void txtEditora__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTombo__TextChanged(object sender, EventArgs e)
        {

        }

        private void InsertLivro()
        {
            if (txtTitulo.Texts != "" && txtPags.Texts != "" && txtpha.Texts != "" && txtCdd.Texts != "" && txtEditoras.Texts != "" && txtIdioma.Texts != "" && txtAutor.Texts != "" && cbbTipo.Texts != "" && txtTombo.Texts != "")
            {
                #region variaveis
                string titulo = txtTitulo.Texts.ToUpper();
                string pags = txtPags.Texts;
                string pha = txtpha.Texts;
                string cdd = txtCdd.Texts;
                string edicao = txtEdicao.Texts;
                if (edicao.Trim() == "")
                {
                    edicao = "NULL";
                }
                string volume = txtVolume.Texts;
                if (volume.Trim() == "")
                {
                    volume = "NULL";
                }
                string ano = txtAno.Texts;
                if (ano.Trim() == "")
                {
                    ano = "NULL";
                }
                string isbn = txtReg.Texts;
                if(isbn.Trim() == "")
                {
                    isbn = "NULL";
                }
                string tombo = txtTombo.Texts;
                string autor = Funcoes.pegaAutor();
                string editora = Funcoes.PegaEditora();
                string idioma = Funcoes.pegaIdioma();
                string tipoPub = Funcoes.pegaTipoPub();
                #endregion

                try
                {
                    Sql.conector.Open();

                    string query = $"INSERT INTO Livro (titulo_livro, pha_livro, cdd_livro, registro_livro, pags_livro, edicao_livro, volume_livro, ano_livro, tombo_livro, fk_id_autor_livro, fk_id_editora_livro, fk_id_idioma_livro, fk_id_tipo_livro) VALUES ('{titulo}', '{pha}', '{cdd}', '{isbn}', {pags}, {edicao}, {volume}, {ano}, {tombo}, {autor}, {editora}, {idioma}, {tipoPub})";
                    using (SqlCommand cmd = new SqlCommand(query, Sql.conector))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    string verificar = $"SELECT * FROM Livro WHERE titulo_livro = '{titulo}' AND fk_id_autor_livro = {autor}";
                    using (SqlCommand cmd = new SqlCommand(verificar, Sql.conector))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Livro cadastrado com sucesso!");
                            }
                            else
                            {
                                MessageBox.Show("Erro ao cadastrar livro!");
                            }
                        }
                    }

                    Sql.conector.Close();
                }
                catch (SqlException ex) { MessageBox.Show(ex.ToString()); Sql.conector.Close(); }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); Sql.conector.Close(); }

            }
        }


    }
}
