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
    public partial class idioma : Form
    {

        SqlDataAdapter dados; //mostra os coidigos do sql
        DataTable datb;

        public idioma()
        {
            InitializeComponent();
            dgvIdioma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIdioma.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizate_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           // Recarregar();
        }

        public void Recarregar()
        {
            this.Hide();
            Autor autor1 = new Autor();
            autor1.ShowDialog();

        }

        private void btnPesquidarIdi_Click(object sender, EventArgs e)
        {
                #region Consulta_nome_do_autor

                Global.idioma = txtIdioma.Texts;

                try
                {

                    Sql.conector.Open();
                    SqlCommand procurar = new SqlCommand("SELECT nome_idioma FROM Idioma WHERE nome_idioma = '" + Global.idioma.ToUpper() + "'", Sql.conector);
                    Global.resultNomeNacionalidade = procurar.ExecuteReader().HasRows;

                    if (Global.resultNomeNacionalidade == true)
                    {
                        Global.usarNomeIdioma = Global.idioma;
                        Global.UsarIdioma = Global.idioma;
                    }

                    Sql.conector.Close();

                }
                catch (SqlException ex)
                {
                    string err = ex.ToString();
                    Sql.conector.Close();
                }

                Atualiza();

                if (Global.resultNomeNacionalidade == false)
                {
                    MessageBox.Show("Idioma não encontrada. Para adiciona-lo, clique no botão adicionar após clicar em OK.", "ATENÇÃO!");
                    btnAdicionar.Visible = true;
                }
                else
                {
                    MessageBox.Show("Idioma encontrada!");
                    Global.usarNomeIdioma = Global.idioma.ToUpper();
                }

                #endregion
        }

        public void Atualiza()
        {
            if(Global.idioma != "" || Global.idioma != String.Empty)
            {
                dados = new SqlDataAdapter("SELECT nome_idioma AS Idioma FROM Idioma WHERE nome_idioma LIKE '%" + Global.idioma + "%'", Sql.conector);
                datb = new DataTable(); //preenche o datat table
                dados.Fill(datb);//mostra no data grid view
                dgvIdioma.DataSource = datb;
                dgvIdioma.Refresh();
            } else
            {
                MessageBox.Show("Insira um Idioma para começar.");
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

               #region Adicionand_Nacionalidade
            try
            {
                Global.idioma = txtIdioma.Texts;

                Sql.conector.Open();
                SqlCommand adc = new SqlCommand("INSERT INTO Idioma (nome_idioma) VALUES ('" + Global.idioma.ToUpper() + "')", Sql.conector);
                adc.ExecuteNonQuery();

                SqlCommand certeza = new SqlCommand("SELECT nome_idioma FROM Idioma WHERE nome_idioma = '" + Global.nomeNacionalidade + "' ", Sql.conector);
                bool result1 = certeza.ExecuteReader().HasRows;

                if (result1 == true)
                {
                    MessageBox.Show("Sucesso!");
                }
                Sql.conector.Close();
                Atualiza();

            }
            catch (SqlException ex)
            {
                string err = ex.ToString();
                Sql.conector.Close();
            }
            #endregion
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Global.nomeIdioma);
        }

        private void txtIdioma__TextChanged(object sender, EventArgs e)
        {
            Global.idioma = txtIdioma.Text;
        }

        private void dgvIdioma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.usarNomeIdioma = dgvIdioma.Rows[e.RowIndex].Cells[0].Value.ToString().ToUpper();
            Global.Idioma = dgvIdioma.Rows[e.RowIndex].Cells[0].Value.ToString().ToUpper();
            Global.UsarIdioma = Global.Idioma.ToUpper();
        }
    }
}
