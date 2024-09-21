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
            //txtCity.Texts = "";
            InitializeComponent();
            txtCity.Texts = Global.Cidade ?? "";
            ArrayCbbEstado();
            cbbEstado.Texts = Global.Estado;
           // cbbEstado.Enabled = false;
            txtCity.Enabled = false;


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
            if (txtCity.Texts != null && txtCity.Text != string.Empty && txtCity.Texts != "") 
            {
                Global.Cidade = txtCity.Text;

                try
                {
                    Sql.conector.Open();
                    SqlCommand cmd = new SqlCommand("SELECT nome_cidade FROM Cidade WHERE nome_cidade = '"+Global.Cidade+"' ", Sql.conector);
                    bool result = cmd.ExecuteReader().HasRows;

                    if (result == true)
                    {
                        MessageBox.Show("Já existe uma cidade com esse nome cadastrada.");
                        txtCity.Texts = "";
                        Global.Cidade = "";
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
            Global.Estado = cbbEstado.SelectedItem.ToString();
        }

        public void ArrayCbbEstado()
        {

            Global.andarCidade = 0;

            try
            {

                for (Global.andarCidade = 3; Global.andarCidade <= 31; Global.andarCidade++)
                {
                    Sql.conector.Close();
                    Sql.conector.Open();
                   string query = "SELECT sigla_estado FROM Estado WHERE pk_id_estado = " + Global.andarCidade + " ";
                   using (SqlCommand cmd = new SqlCommand(query, Sql.conector))
                    {
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               Global.nomeEstado[Global.andarCidade - 1] = reader["sigla_estado"].ToString();
                            }

                            Sql.conector.Close();
                        }
                    }

                }

            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }

            cbbEstado.Items.Clear();

            for (int i = 0; i < Global.nomeEstado.Length; i++)
            {
                if (!string.IsNullOrEmpty(Global.nomeEstado[i])) // Verifica se o item não está vazio
                {
                    cbbEstado.Items.Add(Global.nomeEstado[i]);
                }

            }
        }


        private void txtCidade__TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Sql.conector.Open();

                string query = "SELECT pk_id_estado FROM Estado WHERE sigla_estado = '" + Global.Estado + "'";
                using (SqlCommand procurar = new SqlCommand(query, Sql.conector))
                {
                    using (SqlDataReader reader = procurar.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Global.pkEstado = Convert.ToInt32(reader["pk_id_estado"]);
                        }
                    }

                }
                Global.usarNomeCidade = txtCity.Texts;
                string insert = "INSERT INTO Cidade (nome_cidade, fk_id_estado) VALUES ('" + Global.usarNomeCidade.ToUpper() + "', '" + Global.pkEstado + "')";
                using (SqlCommand cmd = new SqlCommand(insert, Sql.conector))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucesso!");
                }

            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); Sql.conector.Close(); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); Sql.conector.Close(); }

            MessageBox.Show(Global.pkEstado.ToString());
            //MessageBox.Show();
        }

        private void CadCidade_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
