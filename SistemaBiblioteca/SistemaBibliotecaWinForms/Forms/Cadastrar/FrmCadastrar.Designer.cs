namespace SistemaBibliotecaWinForms.Forms.Cadastrar
{
    partial class FrmCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrar));
            this.pnlCadastrar = new System.Windows.Forms.Panel();
            this.pcbSair = new System.Windows.Forms.PictureBox();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.pcbUsuario = new System.Windows.Forms.PictureBox();
            this.pcbNomeUsuario = new System.Windows.Forms.PictureBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.pcbEmail = new System.Windows.Forms.PictureBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.pcbCPF = new System.Windows.Forms.PictureBox();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.pcbSenha = new System.Windows.Forms.PictureBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.pcbTelefone = new System.Windows.Forms.PictureBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cbxMostraSenha = new System.Windows.Forms.CheckBox();
            this.pnlCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNomeUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTelefone)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadastrar
            // 
            this.pnlCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(197)))), ((int)(((byte)(165)))));
            this.pnlCadastrar.Controls.Add(this.pcbSair);
            this.pnlCadastrar.Controls.Add(this.lblCadastrar);
            this.pnlCadastrar.Location = new System.Drawing.Point(-1, 0);
            this.pnlCadastrar.Name = "pnlCadastrar";
            this.pnlCadastrar.Size = new System.Drawing.Size(386, 103);
            this.pnlCadastrar.TabIndex = 1;
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
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastrar.ForeColor = System.Drawing.Color.White;
            this.lblCadastrar.Location = new System.Drawing.Point(102, 33);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(178, 37);
            this.lblCadastrar.TabIndex = 0;
            this.lblCadastrar.Text = "CADASTRAR";
            // 
            // pcbUsuario
            // 
            this.pcbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(212)))));
            this.pcbUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pcbUsuario.Image")));
            this.pcbUsuario.Location = new System.Drawing.Point(11, 167);
            this.pcbUsuario.Name = "pcbUsuario";
            this.pcbUsuario.Size = new System.Drawing.Size(32, 33);
            this.pcbUsuario.TabIndex = 10;
            this.pcbUsuario.TabStop = false;
            // 
            // pcbNomeUsuario
            // 
            this.pcbNomeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(212)))));
            this.pcbNomeUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pcbNomeUsuario.Image")));
            this.pcbNomeUsuario.Location = new System.Drawing.Point(11, 122);
            this.pcbNomeUsuario.Name = "pcbNomeUsuario";
            this.pcbNomeUsuario.Size = new System.Drawing.Size(32, 33);
            this.pcbNomeUsuario.TabIndex = 9;
            this.pcbNomeUsuario.TabStop = false;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbUsuario.Location = new System.Drawing.Point(47, 167);
            this.txbUsuario.MaxLength = 30;
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.PlaceholderText = "Usuário";
            this.txbUsuario.Size = new System.Drawing.Size(327, 33);
            this.txbUsuario.TabIndex = 8;
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNome.Location = new System.Drawing.Point(47, 122);
            this.txbNome.MaxLength = 30;
            this.txbNome.Name = "txbNome";
            this.txbNome.PlaceholderText = "Nome";
            this.txbNome.Size = new System.Drawing.Size(327, 33);
            this.txbNome.TabIndex = 7;
            // 
            // pcbEmail
            // 
            this.pcbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(212)))));
            this.pcbEmail.Image = ((System.Drawing.Image)(resources.GetObject("pcbEmail.Image")));
            this.pcbEmail.Location = new System.Drawing.Point(11, 211);
            this.pcbEmail.Name = "pcbEmail";
            this.pcbEmail.Size = new System.Drawing.Size(32, 33);
            this.pcbEmail.TabIndex = 12;
            this.pcbEmail.TabStop = false;
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbEmail.Location = new System.Drawing.Point(47, 211);
            this.txbEmail.MaxLength = 40;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PlaceholderText = "E-mail";
            this.txbEmail.Size = new System.Drawing.Size(327, 33);
            this.txbEmail.TabIndex = 11;
            // 
            // pcbCPF
            // 
            this.pcbCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(212)))));
            this.pcbCPF.Image = ((System.Drawing.Image)(resources.GetObject("pcbCPF.Image")));
            this.pcbCPF.Location = new System.Drawing.Point(10, 254);
            this.pcbCPF.Name = "pcbCPF";
            this.pcbCPF.Size = new System.Drawing.Size(32, 33);
            this.pcbCPF.TabIndex = 14;
            this.pcbCPF.TabStop = false;
            // 
            // txbCPF
            // 
            this.txbCPF.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCPF.Location = new System.Drawing.Point(46, 254);
            this.txbCPF.MaxLength = 25;
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.PlaceholderText = "CPF";
            this.txbCPF.Size = new System.Drawing.Size(327, 33);
            this.txbCPF.TabIndex = 13;
            // 
            // pcbSenha
            // 
            this.pcbSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(212)))));
            this.pcbSenha.Image = ((System.Drawing.Image)(resources.GetObject("pcbSenha.Image")));
            this.pcbSenha.Location = new System.Drawing.Point(9, 340);
            this.pcbSenha.Name = "pcbSenha";
            this.pcbSenha.Size = new System.Drawing.Size(32, 33);
            this.pcbSenha.TabIndex = 18;
            this.pcbSenha.TabStop = false;
            // 
            // txbSenha
            // 
            this.txbSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSenha.Location = new System.Drawing.Point(45, 340);
            this.txbSenha.MaxLength = 25;
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.PlaceholderText = "Senha";
            this.txbSenha.Size = new System.Drawing.Size(327, 33);
            this.txbSenha.TabIndex = 17;
            // 
            // pcbTelefone
            // 
            this.pcbTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(212)))));
            this.pcbTelefone.Image = ((System.Drawing.Image)(resources.GetObject("pcbTelefone.Image")));
            this.pcbTelefone.Location = new System.Drawing.Point(10, 297);
            this.pcbTelefone.Name = "pcbTelefone";
            this.pcbTelefone.Size = new System.Drawing.Size(32, 33);
            this.pcbTelefone.TabIndex = 16;
            this.pcbTelefone.TabStop = false;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbTelefone.Location = new System.Drawing.Point(46, 297);
            this.txbTelefone.MaxLength = 25;
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.PlaceholderText = "Telefone";
            this.txbTelefone.Size = new System.Drawing.Size(327, 33);
            this.txbTelefone.TabIndex = 15;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(11, 491);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(362, 40);
            this.btnEntrar.TabIndex = 20;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(11, 438);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(362, 40);
            this.btnCadastrar.TabIndex = 19;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // cbxMostraSenha
            // 
            this.cbxMostraSenha.AutoSize = true;
            this.cbxMostraSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxMostraSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxMostraSenha.Location = new System.Drawing.Point(45, 387);
            this.cbxMostraSenha.Name = "cbxMostraSenha";
            this.cbxMostraSenha.Size = new System.Drawing.Size(113, 21);
            this.cbxMostraSenha.TabIndex = 21;
            this.cbxMostraSenha.Text = "Mostrar Senha";
            this.cbxMostraSenha.UseVisualStyleBackColor = true;
            this.cbxMostraSenha.Click += new System.EventHandler(this.CbxMostraSenhaClick);
            // 
            // FrmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(385, 545);
            this.Controls.Add(this.cbxMostraSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pcbSenha);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.pcbTelefone);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.pcbCPF);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.pcbEmail);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.pcbUsuario);
            this.Controls.Add(this.pcbNomeUsuario);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.pnlCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastrar";
            this.pnlCadastrar.ResumeLayout(false);
            this.pnlCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNomeUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTelefone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlCadastrar;
        private PictureBox pcbSair;
        private Label lblCadastrar;
        private PictureBox pcbUsuario;
        private PictureBox pcbNomeUsuario;
        private TextBox txbUsuario;
        private TextBox txbNome;
        private PictureBox pcbEmail;
        private TextBox txbEmail;
        private PictureBox pcbCPF;
        private TextBox txbCPF;
        private PictureBox pcbSenha;
        private TextBox txbSenha;
        private PictureBox pcbTelefone;
        private TextBox txbTelefone;
        private Button btnEntrar;
        private Button btnCadastrar;
        private CheckBox cbxMostraSenha;
    }
}