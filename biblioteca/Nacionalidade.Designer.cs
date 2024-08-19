namespace biblioteca
{
    partial class Nacionalidade
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
            RJCodeAdvance.RJControls.RJButton btnSairn;
            RJCodeAdvance.RJControls.RJButton btnMinimizate;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNacionalidade = new System.Windows.Forms.DataGridView();
            this.lblNomeNacio = new System.Windows.Forms.Label();
            this.txtNacionalidade = new RJCodeAdvance.RJControls.RJTextBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnPesquisa = new RJCodeAdvance.RJControls.RJButton();
            this.btnAdc = new RJCodeAdvance.RJControls.RJButton();
            btnSairn = new RJCodeAdvance.RJControls.RJButton();
            btnMinimizate = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNacionalidade)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSairn
            // 
            btnSairn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            btnSairn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            btnSairn.BorderColor = System.Drawing.Color.White;
            btnSairn.BorderRadius = 0;
            btnSairn.BorderSize = 0;
            btnSairn.Dock = System.Windows.Forms.DockStyle.Right;
            btnSairn.FlatAppearance.BorderSize = 0;
            btnSairn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSairn.ForeColor = System.Drawing.Color.White;
            btnSairn.Location = new System.Drawing.Point(530, 0);
            btnSairn.Name = "btnSairn";
            btnSairn.Size = new System.Drawing.Size(63, 27);
            btnSairn.TabIndex = 3;
            btnSairn.Text = "X";
            btnSairn.TextColor = System.Drawing.Color.White;
            btnSairn.UseVisualStyleBackColor = false;
            btnSairn.Click += new System.EventHandler(this.btnSair_Click_1);
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
            btnMinimizate.Location = new System.Drawing.Point(467, 0);
            btnMinimizate.Name = "btnMinimizate";
            btnMinimizate.Size = new System.Drawing.Size(63, 27);
            btnMinimizate.TabIndex = 4;
            btnMinimizate.Text = "_";
            btnMinimizate.TextColor = System.Drawing.Color.White;
            btnMinimizate.UseVisualStyleBackColor = false;
            // 
            // dgvNacionalidade
            // 
            this.dgvNacionalidade.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNacionalidade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNacionalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNacionalidade.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNacionalidade.GridColor = System.Drawing.Color.White;
            this.dgvNacionalidade.Location = new System.Drawing.Point(26, 110);
            this.dgvNacionalidade.Name = "dgvNacionalidade";
            this.dgvNacionalidade.Size = new System.Drawing.Size(522, 224);
            this.dgvNacionalidade.TabIndex = 29;
            this.dgvNacionalidade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNacionalidade_CellContentClick_1);
            // 
            // lblNomeNacio
            // 
            this.lblNomeNacio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeNacio.AutoSize = true;
            this.lblNomeNacio.ForeColor = System.Drawing.Color.White;
            this.lblNomeNacio.Location = new System.Drawing.Point(18, 64);
            this.lblNomeNacio.Name = "lblNomeNacio";
            this.lblNomeNacio.Size = new System.Drawing.Size(110, 13);
            this.lblNomeNacio.TabIndex = 27;
            this.lblNomeNacio.Text = "Insira a nacionalidade";
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNacionalidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtNacionalidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtNacionalidade.BorderFocusColor = System.Drawing.Color.White;
            this.txtNacionalidade.BorderRadius = 0;
            this.txtNacionalidade.BorderSize = 2;
            this.txtNacionalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalidade.ForeColor = System.Drawing.Color.White;
            this.txtNacionalidade.Location = new System.Drawing.Point(147, 55);
            this.txtNacionalidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtNacionalidade.Multiline = false;
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNacionalidade.PasswordChar = false;
            this.txtNacionalidade.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNacionalidade.PlaceholderText = "";
            this.txtNacionalidade.Size = new System.Drawing.Size(355, 31);
            this.txtNacionalidade.TabIndex = 26;
            this.txtNacionalidade.Texts = "";
            this.txtNacionalidade.UnderlinedStyle = false;
            this.txtNacionalidade._TextChanged += new System.EventHandler(this.txtNacionalidade__TextChanged);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlMenu.Controls.Add(btnMinimizate);
            this.pnlMenu.Controls.Add(btnSairn);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(593, 27);
            this.pnlMenu.TabIndex = 25;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnPesquisa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnPesquisa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnPesquisa.BorderRadius = 10;
            this.btnPesquisa.BorderSize = 0;
            this.btnPesquisa.FlatAppearance.BorderSize = 0;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.ForeColor = System.Drawing.Color.White;
            this.btnPesquisa.Image = global::biblioteca.Properties.Resources.lupa;
            this.btnPesquisa.Location = new System.Drawing.Point(509, 55);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(45, 32);
            this.btnPesquisa.TabIndex = 31;
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisa.TextColor = System.Drawing.Color.White;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btnAdc
            // 
            this.btnAdc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnAdc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnAdc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnAdc.BorderRadius = 10;
            this.btnAdc.BorderSize = 0;
            this.btnAdc.FlatAppearance.BorderSize = 0;
            this.btnAdc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdc.ForeColor = System.Drawing.Color.White;
            this.btnAdc.Image = global::biblioteca.Properties.Resources.sobre1;
            this.btnAdc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdc.Location = new System.Drawing.Point(431, 350);
            this.btnAdc.Name = "btnAdc";
            this.btnAdc.Size = new System.Drawing.Size(123, 77);
            this.btnAdc.TabIndex = 32;
            this.btnAdc.Text = "Adicionar";
            this.btnAdc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdc.TextColor = System.Drawing.Color.White;
            this.btnAdc.UseVisualStyleBackColor = false;
            this.btnAdc.Visible = false;
            this.btnAdc.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // Nacionalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.btnAdc);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.dgvNacionalidade);
            this.Controls.Add(this.lblNomeNacio);
            this.Controls.Add(this.txtNacionalidade);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nacionalidade";
            this.Text = "Nacionalidade1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNacionalidade)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNacionalidade;
        private System.Windows.Forms.Label lblNomeNacio;
        private RJCodeAdvance.RJControls.RJTextBox txtNacionalidade;
        private System.Windows.Forms.Panel pnlMenu;
        private RJCodeAdvance.RJControls.RJButton btnPesquisa;
        private RJCodeAdvance.RJControls.RJButton btnAdc;
    }
}