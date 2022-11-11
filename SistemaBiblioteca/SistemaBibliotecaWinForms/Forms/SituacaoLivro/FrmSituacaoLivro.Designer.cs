namespace SistemaBibliotecaWinForms.Forms.SituacaoLivro
{
    partial class FrmSituacaoLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSituacaoLivro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbSair = new System.Windows.Forms.PictureBox();
            this.lblStatusLivroFixo = new System.Windows.Forms.Label();
            this.lblStatusdoLivro = new System.Windows.Forms.Label();
            this.lblTempoDevolucaoFixo = new System.Windows.Forms.Label();
            this.lblTempodeDevolucao = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pcbUsuario = new System.Windows.Forms.PictureBox();
            this.lblLeitor = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.lblTituloLivroFixo = new System.Windows.Forms.Label();
            this.lblTitulodoLivro = new System.Windows.Forms.Label();
            this.lblDataEmprestimo = new System.Windows.Forms.Label();
            this.lblDataDevolucao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(185, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "SITUAÇÃO DO LIVRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Leitor(a)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data do Empréstimo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(396, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data de Devolução:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(197)))), ((int)(((byte)(165)))));
            this.panel1.Controls.Add(this.pcbSair);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 106);
            this.panel1.TabIndex = 13;
            // 
            // pcbSair
            // 
            this.pcbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbSair.Image = ((System.Drawing.Image)(resources.GetObject("pcbSair.Image")));
            this.pcbSair.Location = new System.Drawing.Point(533, 12);
            this.pcbSair.Name = "pcbSair";
            this.pcbSair.Size = new System.Drawing.Size(31, 32);
            this.pcbSair.TabIndex = 28;
            this.pcbSair.TabStop = false;
            this.pcbSair.Click += new System.EventHandler(this.PcbSairClick);
            // 
            // lblStatusLivroFixo
            // 
            this.lblStatusLivroFixo.AutoSize = true;
            this.lblStatusLivroFixo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatusLivroFixo.Location = new System.Drawing.Point(51, 167);
            this.lblStatusLivroFixo.Name = "lblStatusLivroFixo";
            this.lblStatusLivroFixo.Size = new System.Drawing.Size(118, 20);
            this.lblStatusLivroFixo.TabIndex = 14;
            this.lblStatusLivroFixo.Text = "Status do Livro:";
            // 
            // lblStatusdoLivro
            // 
            this.lblStatusdoLivro.AutoSize = true;
            this.lblStatusdoLivro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatusdoLivro.ForeColor = System.Drawing.Color.Red;
            this.lblStatusdoLivro.Location = new System.Drawing.Point(167, 167);
            this.lblStatusdoLivro.Name = "lblStatusdoLivro";
            this.lblStatusdoLivro.Size = new System.Drawing.Size(107, 20);
            this.lblStatusdoLivro.TabIndex = 15;
            this.lblStatusdoLivro.Text = "EMPRESTADO";
            // 
            // lblTempoDevolucaoFixo
            // 
            this.lblTempoDevolucaoFixo.AutoSize = true;
            this.lblTempoDevolucaoFixo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTempoDevolucaoFixo.Location = new System.Drawing.Point(51, 196);
            this.lblTempoDevolucaoFixo.Name = "lblTempoDevolucaoFixo";
            this.lblTempoDevolucaoFixo.Size = new System.Drawing.Size(173, 20);
            this.lblTempoDevolucaoFixo.TabIndex = 16;
            this.lblTempoDevolucaoFixo.Text = "Tempo para Devolução:";
            // 
            // lblTempodeDevolucao
            // 
            this.lblTempodeDevolucao.AutoSize = true;
            this.lblTempodeDevolucao.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTempodeDevolucao.Location = new System.Drawing.Point(220, 196);
            this.lblTempodeDevolucao.Name = "lblTempodeDevolucao";
            this.lblTempodeDevolucao.Size = new System.Drawing.Size(50, 20);
            this.lblTempodeDevolucao.TabIndex = 17;
            this.lblTempodeDevolucao.Text = "5 Dias";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(396, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Contato";
            // 
            // pcbUsuario
            // 
            this.pcbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(212)))));
            this.pcbUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pcbUsuario.Image")));
            this.pcbUsuario.Location = new System.Drawing.Point(13, 287);
            this.pcbUsuario.Name = "pcbUsuario";
            this.pcbUsuario.Size = new System.Drawing.Size(32, 33);
            this.pcbUsuario.TabIndex = 20;
            this.pcbUsuario.TabStop = false;
            this.pcbUsuario.Click += new System.EventHandler(this.PcbUsuarioClick);
            // 
            // lblLeitor
            // 
            this.lblLeitor.AutoSize = true;
            this.lblLeitor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLeitor.Location = new System.Drawing.Point(53, 289);
            this.lblLeitor.Name = "lblLeitor";
            this.lblLeitor.Size = new System.Drawing.Size(256, 28);
            this.lblLeitor.TabIndex = 21;
            this.lblLeitor.Text = "Gabriel Carvalho de Oliveira";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContato.Location = new System.Drawing.Point(396, 290);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(145, 28);
            this.lblContato.TabIndex = 22;
            this.lblContato.Text = "(33)999999999";
            // 
            // lblTituloLivroFixo
            // 
            this.lblTituloLivroFixo.AutoSize = true;
            this.lblTituloLivroFixo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloLivroFixo.Location = new System.Drawing.Point(53, 138);
            this.lblTituloLivroFixo.Name = "lblTituloLivroFixo";
            this.lblTituloLivroFixo.Size = new System.Drawing.Size(115, 20);
            this.lblTituloLivroFixo.TabIndex = 23;
            this.lblTituloLivroFixo.Text = "Título do Livro:";
            // 
            // lblTitulodoLivro
            // 
            this.lblTitulodoLivro.AutoSize = true;
            this.lblTitulodoLivro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulodoLivro.Location = new System.Drawing.Point(165, 138);
            this.lblTitulodoLivro.Name = "lblTitulodoLivro";
            this.lblTitulodoLivro.Size = new System.Drawing.Size(123, 20);
            this.lblTitulodoLivro.TabIndex = 24;
            this.lblTitulodoLivro.Text = "Senhor dos Anéis";
            // 
            // lblDataEmprestimo
            // 
            this.lblDataEmprestimo.AutoSize = true;
            this.lblDataEmprestimo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataEmprestimo.Location = new System.Drawing.Point(51, 370);
            this.lblDataEmprestimo.Name = "lblDataEmprestimo";
            this.lblDataEmprestimo.Size = new System.Drawing.Size(116, 28);
            this.lblDataEmprestimo.TabIndex = 25;
            this.lblDataEmprestimo.Text = "12/12/2022";
            // 
            // lblDataDevolucao
            // 
            this.lblDataDevolucao.AutoSize = true;
            this.lblDataDevolucao.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataDevolucao.Location = new System.Drawing.Point(396, 370);
            this.lblDataDevolucao.Name = "lblDataDevolucao";
            this.lblDataDevolucao.Size = new System.Drawing.Size(116, 28);
            this.lblDataDevolucao.TabIndex = 26;
            this.lblDataDevolucao.Text = "01/12/2023";
            // 
            // FrmSituacaoLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(576, 458);
            this.Controls.Add(this.lblDataDevolucao);
            this.Controls.Add(this.lblDataEmprestimo);
            this.Controls.Add(this.lblTitulodoLivro);
            this.Controls.Add(this.lblTituloLivroFixo);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.lblLeitor);
            this.Controls.Add(this.pcbUsuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTempodeDevolucao);
            this.Controls.Add(this.lblTempoDevolucaoFixo);
            this.Controls.Add(this.lblStatusdoLivro);
            this.Controls.Add(this.lblStatusLivroFixo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSituacaoLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSituacaoLivro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private PictureBox pcbSair;
        private Label lblStatusLivroFixo;
        private Label lblStatusdoLivro;
        private Label lblTempoDevolucaoFixo;
        private Label lblTempodeDevolucao;
        private Label label9;
        private PictureBox pcbUsuario;
        private Label lblLeitor;
        private Label lblContato;
        private Label lblTituloLivroFixo;
        private Label lblTitulodoLivro;
        private Label lblDataEmprestimo;
        private Label lblDataDevolucao;
    }
}