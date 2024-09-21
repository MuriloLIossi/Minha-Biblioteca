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
    public partial class Editora : Form
    {

        SqlDataAdapter dados; //mostra os coidigos do sql
        DataTable datb;


        public Editora()
        {
            InitializeComponent();
            dgvEditora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEditora.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            string nomeColuna = "cidades";
            if (dgvEditora.Columns.Contains(nomeColuna))
            {
                dgvEditora.Columns["cidade"].ReadOnly = true;
            }

            Atualiza();
        }

        public void Atualiza()
        {
            Global.Cidade = txtEditora.Text;
            dados = new SqlDataAdapter("SELECT nome_editora as editora, nome_cidade AS cidade FROM Editora INNER JOIN Cidade ON Cidade.pk_id_cidade = Editora.fk_id_cidade_editora WHERE nome_editora LIKE '%" + txtEditora.Texts.ToUpper() + "%' ", Sql.conector);
            datb = new DataTable(); //preenche o datat table
            dados.Fill(datb);//mostra no data grid view

            dgvEditora.DataSource = datb;
            dgvEditora.Refresh();
        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }

        private void txtCity__TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCidade_Click_1(object sender, EventArgs e)
        {

        }

        private void txtCidades__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquidar_Click(object sender, EventArgs e)
        {
            if (txtEditora.Texts != "")
            {
                Global.editora = txtEditora.Texts;
                bool result;
                try
                {
                    Sql.conector.Open();
                    string query = "SELECT nome_editora FROM Editora WHERE nome_editora LIKE '%" + Global.editora + "%' ";
                    using (SqlCommand pesq = new SqlCommand(query, Sql.conector))
                    {
                        using (SqlDataReader reader = pesq.ExecuteReader())
                        {
                            result = reader.HasRows;
                            Sql.conector.Close();
                        }
                    }

                    if (result != true)
                    {
                        MessageBox.Show("Cidade não encontrada, clique em adicionar para cadastra-la.");
                        // Sql.conector.Close();
                    }
                    else
                    {
                        Atualiza();
                    }
                }
                catch (SqlException ex) { MessageBox.Show(ex.ToString()); Sql.conector.Close(); }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); Sql.conector.Close(); }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtEditora.Texts != "")
            {
                CadEditora ce = new CadEditora();
                ce.ShowDialog();
                txtEditora.Texts = Global.usarEditora;
                Atualiza();
            }
            else
            {
                MessageBox.Show("Preencha o campo antes de continuar");
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Global.mainEditora = dgvEditora.CurrentRow.Cells[0].Value.ToString();
            DialogResult ed = MessageBox.Show("Sucesso! clique em OK para prosseguir");

            if (ed == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizate_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgvEditora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nomeColuna = dgvEditora.Columns[e.ColumnIndex].Name;
            if (nomeColuna == "cidade")
            {
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;
                DataGridViewCell seletor = dgvEditora.Rows[rowIndex].Cells[columnIndex];
                DataGridViewCell seletor2 = dgvEditora.Rows[rowIndex].Cells[columnIndex-1];

                Global.seletor2 = seletor2.Value.ToString();
            }
        }
    }
}
