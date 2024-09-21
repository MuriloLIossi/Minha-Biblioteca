namespace biblioteca
{
    partial class Cidade
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
            RJCodeAdvance.RJControls.RJButton btnMinimizate;
            RJCodeAdvance.RJControls.RJButton btnSair;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblSoftware = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidades = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnAdicionar = new RJCodeAdvance.RJControls.RJButton();
            this.btnConfirmar = new RJCodeAdvance.RJControls.RJButton();
            this.btnPesquidar = new RJCodeAdvance.RJControls.RJButton();
            this.dgvCidades = new System.Windows.Forms.DataGridView();
            btnMinimizate = new RJCodeAdvance.RJControls.RJButton();
            btnSair = new RJCodeAdvance.RJControls.RJButton();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).BeginInit();
            this.SuspendLayout();
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
            btnMinimizate.Location = new System.Drawing.Point(455, 0);
            btnMinimizate.Name = "btnMinimizate";
            btnMinimizate.Size = new System.Drawing.Size(63, 27);
            btnMinimizate.TabIndex = 2;
            btnMinimizate.Text = "_";
            btnMinimizate.TextColor = System.Drawing.Color.White;
            btnMinimizate.UseVisualStyleBackColor = false;
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
            btnSair.Location = new System.Drawing.Point(518, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new System.Drawing.Size(63, 27);
            btnSair.TabIndex = 0;
            btnSair.Text = "X";
            btnSair.TextColor = System.Drawing.Color.White;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlMenu.Controls.Add(this.lblSoftware);
            this.pnlMenu.Controls.Add(btnMinimizate);
            this.pnlMenu.Controls.Add(btnSair);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(581, 27);
            this.pnlMenu.TabIndex = 17;
            // 
            // lblSoftware
            // 
            this.lblSoftware.AutoSize = true;
            this.lblSoftware.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSoftware.Location = new System.Drawing.Point(12, 7);
            this.lblSoftware.Name = "lblSoftware";
            this.lblSoftware.Size = new System.Drawing.Size(0, 13);
            this.lblSoftware.TabIndex = 3;
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCidade.AutoSize = true;
            this.lblCidade.ForeColor = System.Drawing.Color.White;
            this.lblCidade.Location = new System.Drawing.Point(24, 45);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(120, 13);
            this.lblCidade.TabIndex = 27;
            this.lblCidade.Text = "Insira o nome da cidade";
            this.lblCidade.Click += new System.EventHandler(this.lblCidade_Click);
            // 
            // txtCidades
            // 
            this.txtCidades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtCidades.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtCidades.BorderFocusColor = System.Drawing.Color.White;
            this.txtCidades.BorderRadius = 0;
            this.txtCidades.BorderSize = 2;
            this.txtCidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidades.ForeColor = System.Drawing.Color.White;
            this.txtCidades.Location = new System.Drawing.Point(148, 34);
            this.txtCidades.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidades.Multiline = false;
            this.txtCidades.Name = "txtCidades";
            this.txtCidades.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCidades.PasswordChar = false;
            this.txtCidades.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCidades.PlaceholderText = "";
            this.txtCidades.Size = new System.Drawing.Size(355, 31);
            this.txtCidades.TabIndex = 26;
            this.txtCidades.Texts = "";
            this.txtCidades.UnderlinedStyle = false;
            this.txtCidades._TextChanged += new System.EventHandler(this.txtIdioma__TextChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnAdicionar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnAdicionar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnAdicionar.BorderRadius = 10;
            this.btnAdicionar.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Image = global::biblioteca.Properties.Resources.sobre1;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionar.Location = new System.Drawing.Point(436, 361);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(123, 77);
            this.btnAdicionar.TabIndex = 30;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionar.TextColor = System.Drawing.Color.White;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
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
            this.btnConfirmar.Image = global::biblioteca.Properties.Resources.confirmar1;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmar.Location = new System.Drawing.Point(288, 361);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(123, 77);
            this.btnConfirmar.TabIndex = 31;
            this.btnConfirmar.Text = "confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirmar.TextColor = System.Drawing.Color.White;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnPesquidar
            // 
            this.btnPesquidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnPesquidar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnPesquidar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnPesquidar.BorderRadius = 10;
            this.btnPesquidar.BorderSize = 0;
            this.btnPesquidar.FlatAppearance.BorderSize = 0;
            this.btnPesquidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquidar.ForeColor = System.Drawing.Color.White;
            this.btnPesquidar.Image = global::biblioteca.Properties.Resources.lupa;
            this.btnPesquidar.Location = new System.Drawing.Point(510, 33);
            this.btnPesquidar.Name = "btnPesquidar";
            this.btnPesquidar.Size = new System.Drawing.Size(45, 38);
            this.btnPesquidar.TabIndex = 32;
            this.btnPesquidar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquidar.TextColor = System.Drawing.Color.White;
            this.btnPesquidar.UseVisualStyleBackColor = false;
            this.btnPesquidar.Click += new System.EventHandler(this.btnPesquidarIdi_Click_1);
            // 
            // dgvCidades
            // 
            this.dgvCidades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCidades.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCidades.GridColor = System.Drawing.Color.White;
            this.dgvCidades.Location = new System.Drawing.Point(29, 113);
            this.dgvCidades.Name = "dgvCidades";
            this.dgvCidades.Size = new System.Drawing.Size(522, 224);
            this.dgvCidades.TabIndex = 33;
            this.dgvCidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCidades_CellContentClick);
            // 
            // Cidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.dgvCidades);
            this.Controls.Add(this.btnPesquidar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtCidades);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cidade";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblSoftware;
        private RJCodeAdvance.RJControls.RJButton btnAdicionar;
        private System.Windows.Forms.Label lblCidade;
        private RJCodeAdvance.RJControls.RJTextBox txtCidades;
        private RJCodeAdvance.RJControls.RJButton btnConfirmar;
        private RJCodeAdvance.RJControls.RJButton btnPesquidar;
        private System.Windows.Forms.DataGridView dgvCidades;
    }
}