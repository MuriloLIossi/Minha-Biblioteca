namespace biblioteca
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            RJCodeAdvance.RJControls.RJButton btnSair;
            RJCodeAdvance.RJControls.RJButton btnMinimizate;
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.txtLogin = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtSenha = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnLogin = new RJCodeAdvance.RJControls.RJButton();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblErrUm = new System.Windows.Forms.Label();
            this.lblErrDois = new System.Windows.Forms.Label();
            this.pnlMeio = new System.Windows.Forms.Panel();
            btnSair = new RJCodeAdvance.RJControls.RJButton();
            btnMinimizate = new RJCodeAdvance.RJControls.RJButton();
            this.pnlMenu.SuspendLayout();
            this.pnlMeio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            btnSair.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            btnSair.BorderColor = System.Drawing.Color.White;
            btnSair.BorderRadius = 0;
            btnSair.BorderSize = 0;
            btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSair.ForeColor = System.Drawing.Color.White;
            btnSair.Location = new System.Drawing.Point(904, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new System.Drawing.Size(63, 27);
            btnSair.TabIndex = 0;
            btnSair.Text = "X";
            btnSair.TextColor = System.Drawing.Color.White;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnMinimizate
            // 
            btnMinimizate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            btnMinimizate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            btnMinimizate.BorderColor = System.Drawing.Color.White;
            btnMinimizate.BorderRadius = 0;
            btnMinimizate.BorderSize = 0;
            btnMinimizate.Dock = System.Windows.Forms.DockStyle.Right;
            btnMinimizate.FlatAppearance.BorderSize = 0;
            btnMinimizate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMinimizate.ForeColor = System.Drawing.Color.White;
            btnMinimizate.Location = new System.Drawing.Point(841, 0);
            btnMinimizate.Name = "btnMinimizate";
            btnMinimizate.Size = new System.Drawing.Size(63, 27);
            btnMinimizate.TabIndex = 2;
            btnMinimizate.Text = "_";
            btnMinimizate.TextColor = System.Drawing.Color.White;
            btnMinimizate.UseVisualStyleBackColor = false;
            btnMinimizate.Click += new System.EventHandler(this.btnMinimizate_Click_1);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlMenu.Controls.Add(btnMinimizate);
            this.pnlMenu.Controls.Add(btnSair);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(967, 27);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.pnlLateral.BackgroundImage = global::biblioteca.Properties.Resources.panel3;
            this.pnlLateral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 27);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(226, 504);
            this.pnlLateral.TabIndex = 1;
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtLogin.BorderFocusColor = System.Drawing.Color.White;
            this.txtLogin.BorderRadius = 0;
            this.txtLogin.BorderSize = 2;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.White;
            this.txtLogin.Location = new System.Drawing.Point(228, 110);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Multiline = false;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLogin.PasswordChar = false;
            this.txtLogin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLogin.PlaceholderText = "Digite seu username";
            this.txtLogin.Size = new System.Drawing.Size(355, 31);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Texts = "";
            this.txtLogin.UnderlinedStyle = false;
            this.txtLogin._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtSenha.BorderFocusColor = System.Drawing.Color.White;
            this.txtSenha.BorderRadius = 0;
            this.txtSenha.BorderSize = 2;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(228, 245);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSenha.PasswordChar = true;
            this.txtSenha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSenha.PlaceholderText = "Digite sua senha";
            this.txtSenha.Size = new System.Drawing.Size(367, 31);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Texts = "";
            this.txtSenha.UnderlinedStyle = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(319, 361);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(164, 37);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(177, 115);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(44, 18);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(171, 251);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(50, 18);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(312, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(187, 39);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Faça Login";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblErrUm
            // 
            this.lblErrUm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrUm.AutoSize = true;
            this.lblErrUm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.lblErrUm.ForeColor = System.Drawing.Color.Red;
            this.lblErrUm.Location = new System.Drawing.Point(236, 145);
            this.lblErrUm.Name = "lblErrUm";
            this.lblErrUm.Size = new System.Drawing.Size(94, 13);
            this.lblErrUm.TabIndex = 6;
            this.lblErrUm.Text = "Campo Obrigatório";
            this.lblErrUm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrUm.Visible = false;
            // 
            // lblErrDois
            // 
            this.lblErrDois.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrDois.AutoSize = true;
            this.lblErrDois.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.lblErrDois.ForeColor = System.Drawing.Color.Red;
            this.lblErrDois.Location = new System.Drawing.Point(237, 280);
            this.lblErrDois.Name = "lblErrDois";
            this.lblErrDois.Size = new System.Drawing.Size(94, 13);
            this.lblErrDois.TabIndex = 7;
            this.lblErrDois.Text = "Campo Obrigatório";
            this.lblErrDois.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrDois.Visible = false;
            // 
            // pnlMeio
            // 
            this.pnlMeio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.pnlMeio.Controls.Add(this.lblErrDois);
            this.pnlMeio.Controls.Add(this.lblErrUm);
            this.pnlMeio.Controls.Add(this.lblTitulo);
            this.pnlMeio.Controls.Add(this.lblSenha);
            this.pnlMeio.Controls.Add(this.lblLogin);
            this.pnlMeio.Controls.Add(this.btnLogin);
            this.pnlMeio.Controls.Add(this.txtSenha);
            this.pnlMeio.Controls.Add(this.txtLogin);
            this.pnlMeio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMeio.Location = new System.Drawing.Point(226, 27);
            this.pnlMeio.Name = "pnlMeio";
            this.pnlMeio.Size = new System.Drawing.Size(741, 504);
            this.pnlMeio.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 531);
            this.Controls.Add(this.pnlMeio);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMeio.ResumeLayout(false);
            this.pnlMeio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLateral;
        private RJCodeAdvance.RJControls.RJTextBox txtLogin;
        private RJCodeAdvance.RJControls.RJTextBox txtSenha;
        private RJCodeAdvance.RJControls.RJButton btnLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblErrUm;
        private System.Windows.Forms.Label lblErrDois;
        private System.Windows.Forms.Panel pnlMeio;
    }
}

