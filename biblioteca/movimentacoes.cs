﻿using System;
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
    public partial class movimentacoes : Form
    {



        public movimentacoes()
        {
            InitializeComponent();
            DateTime maxdateemp = DateTime.Now;
            DateTime mindateemp = DateTime.Now;
            DateTime mindatedev = DateTime.Now.AddDays(7);

            dtpEmp.MaxDate = maxdateemp;
            dtpEmp.MinDate = mindateemp;
            dtpDev.MinDate = mindatedev;
            dtpEmp.Enabled = false;

             //MessageBox.Show(Global.Pk_operador.ToString());

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizate_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodAux_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void rjButton1_Click(object sender, EventArgs e)
        {
            if (txtCod.Text != "")
            {

                if (Global.rbCodUserv == true)
                {

                    ChecarUser();

                } else
                {
                    ChecarAux();
                }

                if(Global.rbCodAuxv == true)
                {
                    ChecarAux();
                }
                else
                {
                    ChecarUser();
                }

            } else
            {
                MessageBox.Show("Insira um código de usuário ou código auxiliar para começar.", "Atenção!");
            }
        }

        public void rjButton2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void rjDatePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtNomeUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rbCodUser.Checked = false;
            Global.rbCodAuxv =  rbCodAux.Checked;
            
        }

        private void rbCodUser_CheckedChanged(object sender, EventArgs e)
        {
            rbCodAux.Checked = false;
            Global.rbCodUserv = rbCodUser.Checked;

        }

        public void ChecarUser()
        {

            try
            {
                Sql.conector.Open();
                string cod = txtCod.Text;
                bool resultado;
                string userbuscado;
                string query = "SELECT nome_usuario FROM Usuario WHERE pk_id_usuario = @cod";
                using(SqlCommand buscarUser = new SqlCommand(query, Sql.conector))
                {
                    buscarUser.Parameters.AddWithValue("@cod", cod);
                    resultado = buscarUser.ExecuteReader().HasRows;
                    if (resultado == true)
                    {
                        using (SqlDataReader reader = buscarUser.ExecuteReader())
                        {
                            userbuscado = buscarUser.ToString();
                        }

                        txtNomeUser.Text = userbuscado;
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado");
                    }
                }

                Sql.conector.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); Sql.conector.Close(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); Sql.conector.Close(); }

        }

        public void ChecarAux()
        {

            try
            {
                Sql.conector.Open();
                string cod = txtCod.Text;
                string query = "SELECT cod_aux_exemplar FROM Exemplar WHERE fk_id_livro = @cod ";
                string codBuscado;
                using(SqlCommand buscarAux = new SqlCommand(query, Sql.conector))
                {
                    buscarAux.Parameters.AddWithValue("@cod", cod);
                    bool resultado = buscarAux.ExecuteReader().HasRows;
                    if (resultado == true)
                    {
                      using(SqlDataReader reader = buscarAux.ExecuteReader())
                        {
                            codBuscado = reader["cod_aux_exemplar"].ToString();
                        }
                        txtCod.Text = codBuscado;
                    }
                }
                Sql.conector.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); Sql.conector.Close(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); Sql.conector.Close(); }

        }

    }
}
