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
    public partial class Nacionalidade : Form
    {

        SqlDataAdapter dados; //mostra os coidigos do sql
        DataTable datb;

        public Nacionalidade()
        {
            InitializeComponent();
            dgvNacionalidade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNacionalidade.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            CadAutor autor = new CadAutor();
            autor.ShowDialog();
        }

        private void btnMinimizate_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnPesquidarIdi_Click(object sender, EventArgs e)
        {
 
        }

        private void dgvNacionalidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNacionalidade.Text = dgvNacionalidade.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

           
        }

        public void Atualiza()
        {

            dados = new SqlDataAdapter("SELECT nome_nacionalidade AS Nacionalidade  FROM Nacionalidade WHERE nome_nacionalidade = '" + Global.nomeNacionalidade + "'", Sql.conector);
            datb = new DataTable(); //preenche o datat table
            dados.Fill(datb);//mostra no data grid view
            dgvNacionalidade.DataSource = datb;
            dgvNacionalidade.Refresh();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            #region Consulta_nome_do_autor

            Global.nomeNacionalidade = txtNacionalidade.Texts;

            try
            {

                Sql.conector.Open();
                SqlCommand procurar = new SqlCommand("SELECT nome_nacionalidade FROM Nacionalidade WHERE nome_nacionalidade = '" + Global.nomeNacionalidade + "'", Sql.conector);
                Global.resultNomeNacionalidade = procurar.ExecuteReader().HasRows;

                if (Global.resultNomeNacionalidade == true)
                {
                    Global.usarNomeNacionalidade = Global.nomeNacionalidade;
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
                MessageBox.Show("Nacionalidade não encontrada. Para adiciona-la, clique no botão adicionar após clicar em OK.", "ATENÇÃO!");
                btnAdc.Visible = true;
            } else
            {
                MessageBox.Show("Nacionalidade encontrada!");
                Global.usarNomeNacionalidade = Global.nomeNacionalidade;
            }

            #endregion
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            #region Adicionand_Nacionalidade
            try
            {
                Sql.conector.Open();
                SqlCommand adc = new SqlCommand("INSERT INTO Nacionalidade (nome_nacionalidade) VALUES ('" + Global.nomeNacionalidade.ToUpper() + "')", Sql.conector);
                adc.ExecuteNonQuery();

                SqlCommand certeza = new SqlCommand("SELECT nome_nacionalidade FROM Nacionalidade WHERE nome_nacionalidade = '" + Global.nomeNacionalidade + "' ", Sql.conector);
                bool result1 = certeza.ExecuteReader().HasRows;

                if (result1 == true)
                {
                    MessageBox.Show("Sucesso!");
                    Global.usarNomeNacionalidade = Global.nomeNacionalidade.ToUpper();
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

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(Global.usarNomeNacionalidade);
        }

        private void dgvNacionalidade_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNacionalidade__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
