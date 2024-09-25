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

        SqlDataAdapter dados; //mostra os coidigos do sql
        DataTable datb;

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
            separar.Enabled = false;
            dgvEditora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEditora.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            HScroll();
            VScroll();
            Atualiza();
            TremComArray();

            #endregion

        }

        public void HScroll()
        {
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = dgvEditora.RowCount - 1; // Máximo baseado no número de linhas
            hScrollBar1.SmallChange = 1;
            hScrollBar1.LargeChange = 10;
        }

        public void VScroll()
        {
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = dgvEditora.RowCount - 1; // Máximo baseado no número de linhas
            vScrollBar1.SmallChange = 1;
            vScrollBar1.LargeChange = 10;
        }

        public void Atualiza()
        {

            string dadosprocura = "select nome_tipo_publicacao AS tipo, titulo_livro AS titulo, cdd_livro AS CDD, pha_livro AS PHA, tombo_livro AS 'cód de publicação', nome_autor As autor from Livro INNER JOIN dbo.Autor A on A.pk_id_autor = Livro.fk_id_autor_livro INNER JOIN dbo.Tipo_publicacao Tp on Tp.pk_id_tipo_publicacao = Livro.fk_id_tipo_livro";
            dados = new SqlDataAdapter(dadosprocura, Sql.conector);
            datb = new DataTable(); //preenche o datat table
            dados.Fill(datb);//mostra no data grid view

            dgvEditora.DataSource = datb;
            dgvEditora.Refresh();
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
                    string query = "SELECT tombo_livro FROM Livro WHERE tombo_livro = @resultado";

                    using(SqlCommand verificar = new SqlCommand(query, Sql.conector))
                    {
                        verificar.Parameters.AddWithValue("@resultado", Global.resultado);
                        Global.verificado = verificar.ExecuteReader().HasRows;
                    }

                }
                catch (SqlException ex)
                {

                    string msg = ex.Message;

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
                    string query = "SELECT nome_tipo_publicacao FROM Tipo_publicacao WHERE pk_id_tipo_publicacao = @andarPk";
                    using(SqlCommand procurar = new SqlCommand(query, Sql.conector))
                    {
                        procurar.Parameters.AddWithValue("@andarPk", Global.andarPk);
                        SqlDataReader ler = procurar.ExecuteReader();
                        if (ler.Read())
                        {
                            Global.nomeTipoPub[Global.andarPk - 1] = ler["nome_tipo_publicacao"].ToString();

                        }
                    }

                    Sql.conector.Close();
                }

            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }

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

                    string query = $"INSERT INTO Livro (titulo_livro, pha_livro, cdd_livro, registro_livro, pags_livro, edicao_livro, volume_livro, ano_livro, tombo_livro, fk_id_autor_livro, fk_id_editora_livro, fk_id_idioma_livro, fk_id_tipo_livro) VALUES ('{titulo}', {pha}, '{cdd}', '{isbn}', {pags}, {edicao}, {volume}, {ano}, {tombo}, {autor}, {editora}, {idioma}, {tipoPub})";
                    using (SqlCommand cmd = new SqlCommand(query, Sql.conector))
                    {
                        MessageBox.Show(query);
                        cmd.ExecuteNonQuery();
                        Sql.conector.Close();
                    }

                    Sql.conector.Open();
                    string verificar = $"SELECT titulo_livro, fk_id_autor_livro FROM Livro WHERE titulo_livro = '{titulo}' AND fk_id_autor_livro = {autor}";
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

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            dgvEditora.FirstDisplayedScrollingRowIndex = hScrollBar1.Value;

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            dgvEditora.FirstDisplayedScrollingRowIndex = vScrollBar1.Value;
        }
    }
}
