namespace biblioteca
{
    partial class CadAutor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RJCodeAdvance.RJControls.RJButton btnSair;
            RJCodeAdvance.RJControls.RJButton btnMinimizate;
            this.lblNomeAutor = new System.Windows.Forms.Label();
            this.lblNacionalidade = new System.Windows.Forms.Label();
            this.txtNomeNacio = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtAutor = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnConfirmar = new RJCodeAdvance.RJControls.RJButton();
            this.btnPesquidarIdi = new RJCodeAdvance.RJControls.RJButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
            btnSair = new RJCodeAdvance.RJControls.RJButton();
            btnMinimizate = new RJCodeAdvance.RJControls.RJButton();
            this.pnlMenu.SuspendLayout();
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
            btnSair.Location = new System.Drawing.Point(495, 0);
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
            btnMinimizate.Location = new System.Drawing.Point(432, 0);
            btnMinimizate.Name = "btnMinimizate";
            btnMinimizate.Size = new System.Drawing.Size(63, 27);
            btnMinimizate.TabIndex = 2;
            btnMinimizate.Text = "_";
            btnMinimizate.TextColor = System.Drawing.Color.White;
            btnMinimizate.UseVisualStyleBackColor = false;
            btnMinimizate.Click += new System.EventHandler(this.btnMinimizate_Click);
            // 
            // lblNomeAutor
            // 
            this.lblNomeAutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeAutor.AutoSize = true;
            this.lblNomeAutor.ForeColor = System.Drawing.Color.White;
            this.lblNomeAutor.Location = new System.Drawing.Point(52, 108);
            this.lblNomeAutor.Name = "lblNomeAutor";
            this.lblNomeAutor.Size = new System.Drawing.Size(77, 13);
            this.lblNomeAutor.TabIndex = 10;
            this.lblNomeAutor.Text = "Nome do autor";
            // 
            // lblNacionalidade
            // 
            this.lblNacionalidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNacionalidade.AutoSize = true;
            this.lblNacionalidade.ForeColor = System.Drawing.Color.White;
            this.lblNacionalidade.Location = new System.Drawing.Point(12, 178);
            this.lblNacionalidade.Name = "lblNacionalidade";
            this.lblNacionalidade.Size = new System.Drawing.Size(117, 13);
            this.lblNacionalidade.TabIndex = 12;
            this.lblNacionalidade.Text = "Nacionalidade do autor";
            // 
            // txtNomeNacio
            // 
            this.txtNomeNacio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeNacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtNomeNacio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtNomeNacio.BorderFocusColor = System.Drawing.Color.White;
            this.txtNomeNacio.BorderRadius = 0;
            this.txtNomeNacio.BorderSize = 2;
            this.txtNomeNacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeNacio.ForeColor = System.Drawing.Color.White;
            this.txtNomeNacio.Location = new System.Drawing.Point(140, 169);
            this.txtNomeNacio.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeNacio.Multiline = false;
            this.txtNomeNacio.Name = "txtNomeNacio";
            this.txtNomeNacio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNomeNacio.PasswordChar = false;
            this.txtNomeNacio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNomeNacio.PlaceholderText = "";
            this.txtNomeNacio.Size = new System.Drawing.Size(355, 31);
            this.txtNomeNacio.TabIndex = 11;
            this.txtNomeNacio.Texts = "";
            this.txtNomeNacio.UnderlinedStyle = false;
            this.txtNomeNacio._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // txtAutor
            // 
            this.txtAutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtAutor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtAutor.BorderFocusColor = System.Drawing.Color.White;
            this.txtAutor.BorderRadius = 0;
            this.txtAutor.BorderSize = 2;
            this.txtAutor.Enabled = false;
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.ForeColor = System.Drawing.Color.White;
            this.txtAutor.Location = new System.Drawing.Point(140, 100);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Multiline = false;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAutor.PasswordChar = false;
            this.txtAutor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAutor.PlaceholderText = "";
            this.txtAutor.Size = new System.Drawing.Size(355, 31);
            this.txtAutor.TabIndex = 34;
            this.txtAutor.Texts = "";
            this.txtAutor.UnderlinedStyle = false;
            this.txtAutor._TextChanged += new System.EventHandler(this.txtAutor__TextChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnConfirmar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnConfirmar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnConfirmar.BorderRadius = 10;
            this.btnConfirmar.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Image = global::biblioteca.Properties.Resources.confirmar;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmar.Location = new System.Drawing.Point(393, 304);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(102, 91);
            this.btnConfirmar.TabIndex = 33;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirmar.TextColor = System.Drawing.Color.White;
            this.btnConfirmar.UseCompatibleTextRendering = true;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnPesquidarIdi
            // 
            this.btnPesquidarIdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnPesquidarIdi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnPesquidarIdi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnPesquidarIdi.BorderRadius = 10;
            this.btnPesquidarIdi.BorderSize = 0;
            this.btnPesquidarIdi.FlatAppearance.BorderSize = 0;
            this.btnPesquidarIdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquidarIdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquidarIdi.ForeColor = System.Drawing.Color.White;
            this.btnPesquidarIdi.Image = global::biblioteca.Properties.Resources.lupa;
            this.btnPesquidarIdi.Location = new System.Drawing.Point(502, 162);
            this.btnPesquidarIdi.Name = "btnPesquidarIdi";
            this.btnPesquidarIdi.Size = new System.Drawing.Size(45, 38);
            this.btnPesquidarIdi.TabIndex = 17;
            this.btnPesquidarIdi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquidarIdi.TextColor = System.Drawing.Color.White;
            this.btnPesquidarIdi.UseVisualStyleBackColor = false;
            this.btnPesquidarIdi.Click += new System.EventHandler(this.btnPesquidarIdi_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlMenu.Controls.Add(btnMinimizate);
            this.pnlMenu.Controls.Add(btnSair);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(558, 27);
            this.pnlMenu.TabIndex = 8;
            // 
            // CadAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnPesquidarIdi);
            this.Controls.Add(this.lblNacionalidade);
            this.Controls.Add(this.txtNomeNacio);
            this.Controls.Add(this.lblNomeAutor);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autor2";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeAutor;
        private System.Windows.Forms.Label lblNacionalidade;
        private RJCodeAdvance.RJControls.RJTextBox txtNomeNacio;
        private RJCodeAdvance.RJControls.RJButton btnPesquidarIdi;
        private RJCodeAdvance.RJControls.RJButton btnConfirmar;
        private RJCodeAdvance.RJControls.RJTextBox txtAutor;
        private System.Windows.Forms.Panel pnlMenu;
    }
}