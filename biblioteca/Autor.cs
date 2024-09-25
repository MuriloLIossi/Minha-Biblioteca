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
using System.Windows.Shapes;

namespace biblioteca
{
    public partial class Autor : Form
    {

        SqlDataAdapter dados; //mostra os coidigos do sql
        DataTable datb;

        

        public Autor()
        {
            InitializeComponent();
            dgvAutor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAutor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Atualiza();
            btnAdicionar.Visible = true;
            btnConfirmar.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Fechar();
        }

        private void btnMinimizate_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnPesquidarIdi_Click(object sender, EventArgs e)
        {

            #region Consulta_nome_do_autor
            Global.usarNomeNacionalidade = "";
            Global.nomeAutor = txtNomeAutor.Texts;

            Atualiza();
            try
            {
                Sql.conector.Open();
                string query = "SELECT nome_autor FROM Autor WHERE nome_autor LIKE '%'+@nomeAutor+'%'";
                using (SqlCommand procurar = new SqlCommand(query, Sql.conector))
                {
                    procurar.Parameters.AddWithValue("@nomeAutor", Global.nomeAutor);
                    Global.resultNomeAutor = procurar.ExecuteReader().HasRows;
                }


                Sql.conector.Close();

            }
            catch (SqlException ex) 
            {
                string err = ex.Message;     
                Sql.conector.Close();
            }

            Atualiza();

            if(Global.resultNomeAutor == false)
            {
                MessageBox.Show("Autor não encontrado. Para adiciona-lo, clique no botão adicionar após clicar em OK.", "ATENÇÃO!");
                btnAdicionar.Visible = true;
            }
            else
            {
                DialogResult result = MessageBox.Show("Autor encontrado!", "Sucesso!", MessageBoxButtons.OK);
                if(result == DialogResult.OK)
                {
                    btnConfirmar.Visible = true;
                }
                
            }

            #endregion
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtNomeAutor.Text = dgvAutor.SelectedRows[0].Cells[1].Value.ToString();

        }

        public void Atualiza()
        {   
            dgvAutor.DataSource = null;
            //MessageBox.Show("select nome_autor AS nome from Autor Where nome_autor LIKE '%" + Global.nomeAutor + "%' ");
            dados = new SqlDataAdapter($"select nome_autor AS nome from Autor Where nome_autor LIKE '%{Global.nomeAutor}' ", Sql.conector);
            datb = new DataTable(); //preenche o datat table
            dados.Fill(datb);//mostra no data grid view

            dgvAutor.DataSource = datb;
            dgvAutor.Refresh();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            #region Adicionando_autor

            CadAutor autor2 = new CadAutor();
            autor2.ShowDialog();
            if(Global.refresh != 0)
            {
                txtNomeAutor.Texts = Global.usarNomeAutor.ToUpper();
            }
            #endregion
        }

        private void txtNomeAutor__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Recarregar();
        }
    
        public void Recarregar()
        {
            this.Hide();
            Autor autor1 = new Autor();
            autor1.ShowDialog();

        }

        public void Fechar()
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DataGridViewCell seletor = dgvAutor.SelectedCells[0];
            string nome = seletor.Value.ToString();
            Global.usarNomeAutor = nome.ToUpper();
            Global.UsarAutor = nome.ToUpper();
            DialogResult d = MessageBox.Show("Sucesso! Clique em OK para o cadastro.", "ATENÇÃO!", MessageBoxButtons.OKCancel);

            switch (d)
            {
                case DialogResult.Cancel:
                    break;

                case DialogResult.OK:
                    this.Close();
                    Global.usarNomeAutor = nome.ToUpper();
                    break;
            }
        }
    }
}
