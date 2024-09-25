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
            dgvCidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCidades.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Atualiza();

        }

        private void dgvIdioma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIdioma__TextChanged(object sender, EventArgs e)
        {
            
        }

        public void Atualiza()
        {
            Global.Cidade = txtCidades.Text;
            dados = new SqlDataAdapter("select nome_cidade AS Cidade, sigla_estado AS Estado FROM Cidade Inner Join Estado ON pk_id_estado = Cidade.fk_id_estado Where nome_cidade LIKE '%" +txtCidades.Texts.ToUpper()+"%' ", Sql.conector);
            datb = new DataTable(); //preenche o datat table
            dados.Fill(datb);//mostra no data grid view

            dgvCidades.DataSource = datb;
            dgvCidades.Refresh();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            Global.mainCidade = dgvCidades.CurrentRow.Cells[0].Value.ToString();
            DialogResult d = MessageBox.Show("A cidade " + Global.mainCidade + " foi selecionada. Clique em ok para prosseguir.");
            switch (d)
            {
                case DialogResult.OK:
                    this.Close();
                    break;
            }


        }       
        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (txtCidades.Texts != "")
            {
                Global.Cidade = txtCidades.Texts;
                CadCidade cc = new CadCidade();
                cc.ShowDialog();
   
                txtCidades.Texts = Global.usarNomeCidade.ToUpper() ?? "";
                Atualiza();
            }
            else
            {
                MessageBox.Show("Insira o nome da cidade para continuar");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquidarIdi_Click_1(object sender, EventArgs e)
        {
            Global.Cidade = txtCidades.Texts;
            try
            {
                if (txtCidades.Texts != "" || txtCidades.Texts != null)
                {
                    Sql.conector.Close();
                    Sql.conector.Open();
                    string cidade = txtCidades.Texts;
                    string query = "SELECT nome_cidade FROM cidade WHERE nome_cidade LIKE '%'+@cidade+'%' ";
                    Atualiza();
                    bool result;
                    using (SqlCommand buscar = new SqlCommand(query, Sql.conector))
                    { 
                        buscar.Parameters.AddWithValue("@cidade", cidade);
                        using (SqlDataReader reader = buscar.ExecuteReader())
                        {
                           result = reader.HasRows;
                            Sql.conector.Close();
                        }
                    }

                    if(result == true)
                    {
                        //MessageBox.Show("Cidade ja cadastrada");

                    }
                    else
                    {
                        MessageBox.Show("Cidade não cadastrada, clique em adicionar para cadastra-la.");
                    }
                    Sql.conector.Close();
                }
                else
                {
                    MessageBox.Show("O campo do nome da cidade está em branco. Preencha-o.");
                    Sql.conector.Close();
                }
                      
            } catch (SqlException ex) 
            {
                MessageBox.Show(ex.Message);
                Sql.conector.Close();
            }
        }

        private void dgvCidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nomeColuna = dgvCidades.Columns[e.ColumnIndex].Name;
            if (nomeColuna == "Estado")
            {
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;
                DataGridViewCell seletor = dgvCidades.Rows[rowIndex].Cells[columnIndex];
                DataGridViewCell seletor2 = dgvCidades.Rows[rowIndex].Cells[columnIndex - 1];

                Global.seletor2 = seletor2.Value.ToString();
            }
        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }
    }
}


