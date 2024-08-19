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
    public partial class CadCidade : Form
    {                

        public CadCidade()
        {
            InitializeComponent();
            ArrayCbbEstado();


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizate_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPesqAutor_Click(object sender, EventArgs e)
        {
            if (txtCidade.Texts != null && txtCidade.Text != string.Empty && txtCidade.Texts != "") 
            {
                Global.cidade = txtCidade.Text;

                try
                {
                    Sql.conector.Open();
                    SqlCommand cmd = new SqlCommand("SELECT nome_cidade FROM Cidade WHERE nome_cidade = '"+Global.cidade+"' ", Sql.conector);
                    bool result = cmd.ExecuteReader().HasRows;

                    if (result == true)
                    {
                        MessageBox.Show("Já existe uma cidade com esse nome cadastrada.");
                        txtCidade.Texts = "";
                        Global.cidade = "";
                        Sql.conector.Close();
                    }
                    else 
                    {
                        SqlCommand insert = new SqlCommand("INSERT INTO Cidade (nome_cidade, pk_id_estado) ");
                    }

                } finally { Sql.conector.Close(); }

            }
        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void cbbEstado_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ArrayCbbEstado()
        {

            Global.andarCidade = 0;

            try
            {
                Sql.conector.Open();
                for (Global.andarCidade = 1; Global.andarCidade <= 27; Global.andarCidade++)
                {
                    SqlCommand verificar = new SqlCommand("SELECT nome_estado FROM Estado WHERE pk_id_estado = '" + Global.andarCidade + "'");
                    SqlDataReader ler = verificar.ExecuteReader();
                    if (ler.Read())
                    {
                        Global.cidade = "";
                    }

                }

            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }

        }


        private void txtCidade__TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
