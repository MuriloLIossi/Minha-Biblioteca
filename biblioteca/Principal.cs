using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizate_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMov_Click(object sender, EventArgs e)
        {
            movimentacoes mv = new movimentacoes();
            this.Hide();
            mv.ShowDialog();
        }

        private void btnAcervo_Click(object sender, EventArgs e)
        {
            Acervo acervo = new Acervo();
            acervo.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click_1(object sender, EventArgs e)
        {
            pnlMovBar.Visible = true;
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {

        }

        private void btnAcervo_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMovimentacao_Click_1(object sender, EventArgs e)
        {
            movimentacoes mov = new movimentacoes();
            mov.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            pnlMais.Visible = true;
            pnlOutros.Visible = false;
        }

        private void btnOutros_Click(object sender, EventArgs e)
        {
            pnlOutros.Visible = true;
            pnlMais.Visible = false;
        }

        private void rjButton2_Click_2(object sender, EventArgs e)
        {
            Funcoes.CadLivro();
            Funcoes.zerador();
        }

        private void btnCadNacio_Click(object sender, EventArgs e)
        {
            Nacionalidade nc = new Nacionalidade();
            nc.ShowDialog();
        }

        private void btnCadIdioma_Click(object sender, EventArgs e)
        {
            idioma idi = new idioma();
            idi.ShowDialog();
        }

        private void rjButton10_Click(object sender, EventArgs e)
        {
            //CadEditora ed = new CadEditora();
            //ed.ShowDialog();    
        }

        private void btnCadCidade_Click(object sender, EventArgs e)
        {

        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            movimentacoes mov = new movimentacoes();
            mov.ShowDialog();
        }

        private void rjButton8_Click(object sender, EventArgs e)
        {

        }

        private void btnCadAutor_Click(object sender, EventArgs e)
        {
            CadAutor autor = new CadAutor();
            autor.ShowDialog();
        }
    }
}
