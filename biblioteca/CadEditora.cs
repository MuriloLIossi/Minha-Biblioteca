using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace biblioteca
{
    public partial class CadEditora : Form
    {
        public CadEditora()
        {
            InitializeComponent();
            txtEditora.Texts = Global.editora ?? "";
            txtEditora.Enabled = false;
            txtCidade.Enabled = false;


        }

        private void txtEditora__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesqcidade_Click(object sender, EventArgs e)
        {
            Cidade ce = new Cidade();
            ce.ShowDialog();
            txtCidade.Texts = Global.mainCidade;
            Global.cidade_usared = txtCidade.Texts;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome_editora = txtEditora.Texts;
                bool continuar;
                int pk;
                Sql.conector.Open();
                string query = "SELECT nome_editora FROM Editora WHERE nome_editora = @editora";
                using (SqlCommand cmd = new SqlCommand(query, Sql.conector))
                {
                    cmd.Parameters.AddWithValue("@editora", nome_editora.ToUpper());
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            continuar = true;
                        }
                    }


                }

                string selectpk = "SELECT pk_id_cidade FROM Cidade where nome_cidade = @cidade";
                using (SqlCommand cmd = new SqlCommand(selectpk, Sql.conector))
                {
                    cmd.Parameters.AddWithValue("@cidade", Global.cidade_usared);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Global.pk_cidade = Convert.ToInt32(reader["pk_id_cidade"]);
                        }
                    }
                }

                string insert = $"INSERT INTO Editora(nome_editora, fk_id_cidade_editora) VALUES (@editora, @cidade)";
                using (SqlCommand cmd = new SqlCommand(insert, Sql.conector))
                {
                    cmd.Parameters.AddWithValue("@editora", nome_editora.ToUpper());
                    cmd.Parameters.AddWithValue("@cidade", Global.pk_cidade.ToString());
                    cmd.ExecuteNonQuery();
                    DialogResult d = MessageBox.Show("Sucesso!");
                    if (d == DialogResult.OK)
                    {

                        string selectED = $"SELECT nome_editora FROM editora WHERE nome_editora = @nomeEditora ";
                        using (SqlCommand cmdd = new SqlCommand(selectED, Sql.conector))
                        {
                            cmd.Parameters.AddWithValue("@nomeEditora", nome_editora);
                            using (SqlDataReader reader = cmdd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    Global.usarEditora = reader["nome_editora"].ToString();
                                }
                            }

                            Sql.conector.Close();
                            this.Close();

                        }

                    }

                    Sql.conector.Close();

                }
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); Sql.conector.Close(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); Sql.conector.Close(); }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
