namespace biblioteca
{
    partial class CadCidade
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblSoftware = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCity = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbbEstado = new RJCodeAdvance.RJControls.RJComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnConfirmar = new RJCodeAdvance.RJControls.RJButton();
            this.btnPesqAutor = new RJCodeAdvance.RJControls.RJButton();
            btnMinimizate = new RJCodeAdvance.RJControls.RJButton();
            btnSair = new RJCodeAdvance.RJControls.RJButton();
            this.pnlMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimizate
            // 
            btnMinimizate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            btnMinimizate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            btnMinimizate.BorderColor = System.Drawing.Color.White;
            btnMinimizate.BorderRadius = 0;
            btnMinimizate.BorderSize = 0;
            btnMinimizate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnMinimizate.Dock = System.Windows.Forms.DockStyle.Right;
            btnMinimizate.FlatAppearance.BorderSize = 0;
            btnMinimizate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMinimizate.ForeColor = System.Drawing.Color.White;
            btnMinimizate.Location = new System.Drawing.Point(674, 0);
            btnMinimizate.Name = "btnMinimizate";
            btnMinimizate.Size = new System.Drawing.Size(63, 27);
            btnMinimizate.TabIndex = 2;
            btnMinimizate.Text = "_";
            btnMinimizate.TextColor = System.Drawing.Color.White;
            btnMinimizate.UseVisualStyleBackColor = false;
            btnMinimizate.Click += new System.EventHandler(this.btnMinimizate_Click);
            // 
            // btnSair
            // 
            btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            btnSair.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            btnSair.BorderColor = System.Drawing.Color.White;
            btnSair.BorderRadius = 0;
            btnSair.BorderSize = 0;
            btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSair.ForeColor = System.Drawing.Color.White;
            btnSair.Location = new System.Drawing.Point(737, 0);
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
            this.pnlMenu.Size = new System.Drawing.Size(800, 27);
            this.pnlMenu.TabIndex = 18;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPesqAutor);
            this.panel3.Controls.Add(this.lblCidade);
            this.panel3.Controls.Add(this.txtCity);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 70);
            this.panel3.TabIndex = 23;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCidade.AutoSize = true;
            this.lblCidade.ForeColor = System.Drawing.Color.White;
            this.lblCidade.Location = new System.Drawing.Point(67, 29);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(85, 13);
            this.lblCidade.TabIndex = 17;
            this.lblCidade.Text = "Nome da cidade";
            // 
            // txtCity
            // 
            this.txtCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtCity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtCity.BorderFocusColor = System.Drawing.Color.White;
            this.txtCity.BorderRadius = 0;
            this.txtCity.BorderSize = 2;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.White;
            this.txtCity.Location = new System.Drawing.Point(159, 21);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Multiline = false;
            this.txtCity.Name = "txtCity";
            this.txtCity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCity.PasswordChar = false;
            this.txtCity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCity.PlaceholderText = "";
            this.txtCity.Size = new System.Drawing.Size(494, 31);
            this.txtCity.TabIndex = 16;
            this.txtCity.Texts = "";
            this.txtCity.UnderlinedStyle = false;
            this.txtCity._TextChanged += new System.EventHandler(this.txtCidade__TextChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbbEstado);
            this.panel5.Controls.Add(this.lblEstado);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 97);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 70);
            this.panel5.TabIndex = 38;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // cbbEstado
            // 
            this.cbbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.cbbEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbbEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.cbbEstado.BorderSize = 1;
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbEstado.ForeColor = System.Drawing.Color.White;
            this.cbbEstado.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.cbbEstado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.cbbEstado.ListTextColor = System.Drawing.Color.White;
            this.cbbEstado.Location = new System.Drawing.Point(159, 20);
            this.cbbEstado.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Padding = new System.Windows.Forms.Padding(1);
            this.cbbEstado.Size = new System.Drawing.Size(494, 30);
            this.cbbEstado.TabIndex = 39;
            this.cbbEstado.Texts = "";
            this.cbbEstado.OnSelectedIndexChanged += new System.EventHandler(this.cbbEstado_OnSelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(112, 29);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 20;
            this.lblEstado.Text = "Estado";
            this.lblEstado.Click += new System.EventHandler(this.lblTipo_Click);
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
            this.btnConfirmar.Location = new System.Drawing.Point(351, 204);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(102, 91);
            this.btnConfirmar.TabIndex = 37;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirmar.TextColor = System.Drawing.Color.White;
            this.btnConfirmar.UseCompatibleTextRendering = true;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnPesqAutor
            // 
            this.btnPesqAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnPesqAutor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnPesqAutor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnPesqAutor.BorderRadius = 10;
            this.btnPesqAutor.BorderSize = 0;
            this.btnPesqAutor.FlatAppearance.BorderSize = 0;
            this.btnPesqAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqAutor.ForeColor = System.Drawing.Color.White;
            this.btnPesqAutor.Image = global::biblioteca.Properties.Resources.lupa;
            this.btnPesqAutor.Location = new System.Drawing.Point(672, 20);
            this.btnPesqAutor.Name = "btnPesqAutor";
            this.btnPesqAutor.Size = new System.Drawing.Size(45, 32);
            this.btnPesqAutor.TabIndex = 18;
            this.btnPesqAutor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesqAutor.TextColor = System.Drawing.Color.White;
            this.btnPesqAutor.UseVisualStyleBackColor = false;
            this.btnPesqAutor.Click += new System.EventHandler(this.btnPesqAutor_Click);
            // 
            // CadCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadCidade";
            this.Text = "Cidade";
            this.Load += new System.EventHandler(this.CadCidade_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblSoftware;
        private System.Windows.Forms.Panel panel3;
        private RJCodeAdvance.RJControls.RJButton btnPesqAutor;
        private System.Windows.Forms.Label lblCidade;
        private RJCodeAdvance.RJControls.RJTextBox txtCity;
        private RJCodeAdvance.RJControls.RJButton btnConfirmar;
        private System.Windows.Forms.Panel panel5;
        private RJCodeAdvance.RJControls.RJComboBox cbbEstado;
        private System.Windows.Forms.Label lblEstado;
    }
}