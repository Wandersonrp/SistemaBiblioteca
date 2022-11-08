namespace SistemaBibliotecaWinForms.Forms.FrmLogin
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pcbSair = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pcbUsuario = new System.Windows.Forms.PictureBox();
            this.pcbSenha = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cbxMostraSenha = new System.Windows.Forms.CheckBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(197)))), ((int)(((byte)(165)))));
            this.pnlLogin.Controls.Add(this.pcbSair);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Location = new System.Drawing.Point(-1, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(386, 103);
            this.pnlLogin.TabIndex = 0;
            // 
            // pcbSair
            // 
            this.pcbSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(197)))), ((int)(((byte)(165)))));
            this.pcbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbSair.Image = ((System.Drawing.Image)(resources.GetObject("pcbSair.Image")));
            this.pcbSair.Location = new System.Drawing.Point(352, 3);
            this.pcbSair.Name = "pcbSair";
            this.pcbSair.Size = new System.Drawing.Size(32, 33);
            this.pcbSair.TabIndex = 9;
            this.pcbSair.TabStop = false;
            this.pcbSair.Click += new System.EventHandler(this.PcbSairClick);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(140, 24);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(104, 45);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbUsuario.Location = new System.Drawing.Point(47, 165);
            this.txbUsuario.MaxLength = 25;
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.PlaceholderText = "Usuário";
            this.txbUsuario.Size = new System.Drawing.Size(327, 33);
            this.txbUsuario.TabIndex = 1;
            // 
            // txbSenha
            // 
            this.txbSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSenha.Location = new System.Drawing.Point(47, 229);
            this.txbSenha.MaxLength = 25;
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.PlaceholderText = "Senha";
            this.txbSenha.Size = new System.Drawing.Size(327, 33);
            this.txbSenha.TabIndex = 2;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(12, 336);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(362, 40);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            // 
            // pcbUsuario
            // 
            this.pcbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(212)))));
            this.pcbUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pcbUsuario.Image")));
            this.pcbUsuario.Location = new System.Drawing.Point(11, 165);
            this.pcbUsuario.Name = "pcbUsuario";
            this.pcbUsuario.Size = new System.Drawing.Size(32, 33);
            this.pcbUsuario.TabIndex = 5;
            this.pcbUsuario.TabStop = false;
            // 
            // pcbSenha
            // 
            this.pcbSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(212)))));
            this.pcbSenha.Image = ((System.Drawing.Image)(resources.GetObject("pcbSenha.Image")));
            this.pcbSenha.Location = new System.Drawing.Point(11, 229);
            this.pcbSenha.Name = "pcbSenha";
            this.pcbSenha.Size = new System.Drawing.Size(32, 33);
            this.pcbSenha.TabIndex = 6;
            this.pcbSenha.TabStop = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(12, 389);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(362, 40);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // cbxMostraSenha
            // 
            this.cbxMostraSenha.AutoSize = true;
            this.cbxMostraSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxMostraSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxMostraSenha.Location = new System.Drawing.Point(47, 278);
            this.cbxMostraSenha.Name = "cbxMostraSenha";
            this.cbxMostraSenha.Size = new System.Drawing.Size(113, 21);
            this.cbxMostraSenha.TabIndex = 8;
            this.cbxMostraSenha.Text = "Mostrar Senha";
            this.cbxMostraSenha.UseVisualStyleBackColor = true;
            this.cbxMostraSenha.Click += new System.EventHandler(this.CbxMostraSenhaClick);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(385, 454);
            this.Controls.Add(this.cbxMostraSenha);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pcbSenha);
            this.Controls.Add(this.pcbUsuario);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlLogin;
        private Label lblLogin;
        private TextBox txbUsuario;
        private TextBox txbSenha;
        private Button btnEntrar;
        private PictureBox pcbUsuario;
        private PictureBox pcbSenha;
        private Button btnCadastrar;
        private CheckBox cbxMostraSenha;
        private PictureBox pcbSair;
    }
}