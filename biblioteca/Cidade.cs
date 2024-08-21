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
    public partial class Cidade : Form
    {

        SqlDataAdapter dados; //mostra os coidigos do sql
        DataTable datb;



        public Cidade()
        {
            InitializeComponent();
        }

        private void dgvIdioma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIdioma__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquidarIdi_Click(object sender, EventArgs e)
        {

        }

        public void Atualiza()
        {
            dados = new SqlDataAdapter("SELECT nome_cidade FROM Cidade WHERE nome_cidade LIKE '%" + Global.cidade + "%' ", Sql.conector);

            dados.Fill(datb);//mostra no data grid view

            dgvCidade.DataSource = datb;
            dgvCidade.Refresh();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            DataGridViewCell seletor = dgvCidade.SelectedCells[0];
            string nome = seletor.Value.ToString();
            Global.usarCidade = nome.ToUpper();
            DialogResult d = MessageBox.Show("Sucesso! Clique em OK para o cadastro.", "ATENÇÃO!", MessageBoxButtons.OKCancel);

            switch (d)
            {
                case DialogResult.Cancel:
                    break;

                case DialogResult.OK:
                    this.Close();
                    break;
            }

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CadCidade cadCidade = new CadCidade();
            cadCidade.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquidarIdi_Click_1(object sender, EventArgs e)
        {
            if (txtCidade.Texts != "")
            {
                Sql.conector.Close();
                Global.cidade = "";
                Global.cidade = txtCidade.Text;

                try
                {
                    Sql.conector.Open();
                    SqlCommand procurar = new SqlCommand("SELECT nome_cidade FROM Cidade WHERE nome_cidade LIKE '%" + Global.cidade + "%' ", Sql.conector);
                    bool result = procurar.ExecuteReader().HasRows;

                    Atualiza();

                    if (result == false)
                    {
                        MessageBox.Show("Essa cidade não está cadastrada. Clique no botãao adicionar para cadastra-la.");
                        btnAdicionar.Visible = true;
                        Sql.conector.Close();
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    Sql.conector.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Sql.conector.Close();
                }

            }
        }
    }
}
