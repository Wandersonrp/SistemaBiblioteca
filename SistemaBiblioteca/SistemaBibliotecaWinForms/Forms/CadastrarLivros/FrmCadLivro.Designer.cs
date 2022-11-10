namespace SistemaBibliotecaWinForms.Forms.CadastrarLivros
{
    partial class FrmCadLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadLivro));
            this.pcbLivro = new System.Windows.Forms.PictureBox();
            this.lblCadastroLivros = new System.Windows.Forms.Label();
            this.lblCodigoLivro = new System.Windows.Forms.Label();
            this.lblPrateleira = new System.Windows.Forms.Label();
            this.lblTituloLivro = new System.Windows.Forms.Label();
            this.lblEstante = new System.Windows.Forms.Label();
            this.lblAnoLivro = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.lblClassificação = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.txbCodigoLivro = new System.Windows.Forms.TextBox();
            this.txbPrateleira = new System.Windows.Forms.TextBox();
            this.txbEstante = new System.Windows.Forms.TextBox();
            this.txbTituloLivro = new System.Windows.Forms.TextBox();
            this.txbAnoLivro = new System.Windows.Forms.TextBox();
            this.txbAutor = new System.Windows.Forms.TextBox();
            this.txbEditora = new System.Windows.Forms.TextBox();
            this.txbClassificacao = new System.Windows.Forms.TextBox();
            this.rtbObservacoes = new System.Windows.Forms.RichTextBox();
            this.mcdDataCadastroLivro = new System.Windows.Forms.MonthCalendar();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pcbSair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbLivro
            // 
            this.pcbLivro.Image = ((System.Drawing.Image)(resources.GetObject("pcbLivro.Image")));
            this.pcbLivro.Location = new System.Drawing.Point(31, 24);
            this.pcbLivro.Name = "pcbLivro";
            this.pcbLivro.Size = new System.Drawing.Size(62, 66);
            this.pcbLivro.TabIndex = 0;
            this.pcbLivro.TabStop = false;
            // 
            // lblCadastroLivros
            // 
            this.lblCadastroLivros.AutoSize = true;
            this.lblCadastroLivros.Font = new System.Drawing.Font("Arial Narrow", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroLivros.Location = new System.Drawing.Point(99, 39);
            this.lblCadastroLivros.Name = "lblCadastroLivros";
            this.lblCadastroLivros.Size = new System.Drawing.Size(302, 36);
            this.lblCadastroLivros.TabIndex = 1;
            this.lblCadastroLivros.Text = "CADASTRO DE LIVROS";
            // 
            // lblCodigoLivro
            // 
            this.lblCodigoLivro.AutoSize = true;
            this.lblCodigoLivro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoLivro.Location = new System.Drawing.Point(31, 121);
            this.lblCodigoLivro.Name = "lblCodigoLivro";
            this.lblCodigoLivro.Size = new System.Drawing.Size(138, 21);
            this.lblCodigoLivro.TabIndex = 2;
            this.lblCodigoLivro.Text = "*Código do Livro";
            // 
            // lblPrateleira
            // 
            this.lblPrateleira.AutoSize = true;
            this.lblPrateleira.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrateleira.Location = new System.Drawing.Point(355, 121);
            this.lblPrateleira.Name = "lblPrateleira";
            this.lblPrateleira.Size = new System.Drawing.Size(91, 21);
            this.lblPrateleira.TabIndex = 3;
            this.lblPrateleira.Text = "*Prateleira";
            // 
            // lblTituloLivro
            // 
            this.lblTituloLivro.AutoSize = true;
            this.lblTituloLivro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloLivro.Location = new System.Drawing.Point(31, 192);
            this.lblTituloLivro.Name = "lblTituloLivro";
            this.lblTituloLivro.Size = new System.Drawing.Size(125, 21);
            this.lblTituloLivro.TabIndex = 4;
            this.lblTituloLivro.Text = "*Título do livro";
            // 
            // lblEstante
            // 
            this.lblEstante.AutoSize = true;
            this.lblEstante.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstante.Location = new System.Drawing.Point(608, 121);
            this.lblEstante.Name = "lblEstante";
            this.lblEstante.Size = new System.Drawing.Size(73, 21);
            this.lblEstante.TabIndex = 5;
            this.lblEstante.Text = "*Estante";
            // 
            // lblAnoLivro
            // 
            this.lblAnoLivro.AutoSize = true;
            this.lblAnoLivro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnoLivro.Location = new System.Drawing.Point(608, 264);
            this.lblAnoLivro.Name = "lblAnoLivro";
            this.lblAnoLivro.Size = new System.Drawing.Size(47, 21);
            this.lblAnoLivro.TabIndex = 6;
            this.lblAnoLivro.Text = "*Ano";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAutor.Location = new System.Drawing.Point(608, 192);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(59, 21);
            this.lblAutor.TabIndex = 7;
            this.lblAutor.Text = "*Autor";
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblObservacoes.Location = new System.Drawing.Point(30, 406);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(107, 21);
            this.lblObservacoes.TabIndex = 8;
            this.lblObservacoes.Text = "Observações";
            // 
            // lblClassificação
            // 
            this.lblClassificação.AutoSize = true;
            this.lblClassificação.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClassificação.Location = new System.Drawing.Point(30, 337);
            this.lblClassificação.Name = "lblClassificação";
            this.lblClassificação.Size = new System.Drawing.Size(115, 21);
            this.lblClassificação.TabIndex = 9;
            this.lblClassificação.Text = "*Classificação";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEditora.Location = new System.Drawing.Point(31, 264);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(72, 21);
            this.lblEditora.TabIndex = 10;
            this.lblEditora.Text = "*Editora";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataCadastro.Location = new System.Drawing.Point(608, 337);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(147, 21);
            this.lblDataCadastro.TabIndex = 11;
            this.lblDataCadastro.Text = "*Data de Cadastro";
            // 
            // txbCodigoLivro
            // 
            this.txbCodigoLivro.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCodigoLivro.Location = new System.Drawing.Point(31, 145);
            this.txbCodigoLivro.Name = "txbCodigoLivro";
            this.txbCodigoLivro.Size = new System.Drawing.Size(254, 32);
            this.txbCodigoLivro.TabIndex = 12;
            // 
            // txbPrateleira
            // 
            this.txbPrateleira.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPrateleira.Location = new System.Drawing.Point(355, 145);
            this.txbPrateleira.Name = "txbPrateleira";
            this.txbPrateleira.Size = new System.Drawing.Size(186, 32);
            this.txbPrateleira.TabIndex = 13;
            // 
            // txbEstante
            // 
            this.txbEstante.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbEstante.Location = new System.Drawing.Point(608, 145);
            this.txbEstante.Name = "txbEstante";
            this.txbEstante.Size = new System.Drawing.Size(232, 32);
            this.txbEstante.TabIndex = 14;
            // 
            // txbTituloLivro
            // 
            this.txbTituloLivro.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbTituloLivro.Location = new System.Drawing.Point(31, 216);
            this.txbTituloLivro.Name = "txbTituloLivro";
            this.txbTituloLivro.Size = new System.Drawing.Size(510, 32);
            this.txbTituloLivro.TabIndex = 15;
            // 
            // txbAnoLivro
            // 
            this.txbAnoLivro.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbAnoLivro.Location = new System.Drawing.Point(608, 288);
            this.txbAnoLivro.MaxLength = 4;
            this.txbAnoLivro.Name = "txbAnoLivro";
            this.txbAnoLivro.Size = new System.Drawing.Size(232, 32);
            this.txbAnoLivro.TabIndex = 16;
            // 
            // txbAutor
            // 
            this.txbAutor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbAutor.Location = new System.Drawing.Point(608, 216);
            this.txbAutor.Name = "txbAutor";
            this.txbAutor.Size = new System.Drawing.Size(232, 32);
            this.txbAutor.TabIndex = 17;
            // 
            // txbEditora
            // 
            this.txbEditora.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbEditora.Location = new System.Drawing.Point(31, 288);
            this.txbEditora.Name = "txbEditora";
            this.txbEditora.Size = new System.Drawing.Size(510, 32);
            this.txbEditora.TabIndex = 18;
            // 
            // txbClassificacao
            // 
            this.txbClassificacao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbClassificacao.Location = new System.Drawing.Point(31, 361);
            this.txbClassificacao.Name = "txbClassificacao";
            this.txbClassificacao.Size = new System.Drawing.Size(510, 32);
            this.txbClassificacao.TabIndex = 19;
            // 
            // rtbObservacoes
            // 
            this.rtbObservacoes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbObservacoes.Location = new System.Drawing.Point(30, 432);
            this.rtbObservacoes.MaxLength = 500;
            this.rtbObservacoes.Name = "rtbObservacoes";
            this.rtbObservacoes.Size = new System.Drawing.Size(510, 91);
            this.rtbObservacoes.TabIndex = 22;
            this.rtbObservacoes.Text = "";
            // 
            // mcdDataCadastroLivro
            // 
            this.mcdDataCadastroLivro.Location = new System.Drawing.Point(608, 361);
            this.mcdDataCadastroLivro.Name = "mcdDataCadastroLivro";
            this.mcdDataCadastroLivro.TabIndex = 23;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(726, 544);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(109, 37);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(608, 544);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 37);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(493, 544);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(109, 37);
            this.btnCadastrar.TabIndex = 26;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // pcbSair
            // 
            this.pcbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbSair.Image = ((System.Drawing.Image)(resources.GetObject("pcbSair.Image")));
            this.pcbSair.Location = new System.Drawing.Point(851, 24);
            this.pcbSair.Name = "pcbSair";
            this.pcbSair.Size = new System.Drawing.Size(31, 32);
            this.pcbSair.TabIndex = 27;
            this.pcbSair.TabStop = false;
            this.pcbSair.Click += new System.EventHandler(this.PcbSairClick);
            // 
            // FrmCadLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(197)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(894, 594);
            this.Controls.Add(this.pcbSair);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.mcdDataCadastroLivro);
            this.Controls.Add(this.rtbObservacoes);
            this.Controls.Add(this.txbClassificacao);
            this.Controls.Add(this.txbEditora);
            this.Controls.Add(this.txbAutor);
            this.Controls.Add(this.txbAnoLivro);
            this.Controls.Add(this.txbTituloLivro);
            this.Controls.Add(this.txbEstante);
            this.Controls.Add(this.txbPrateleira);
            this.Controls.Add(this.txbCodigoLivro);
            this.Controls.Add(this.lblDataCadastro);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.lblClassificação);
            this.Controls.Add(this.lblObservacoes);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblAnoLivro);
            this.Controls.Add(this.lblEstante);
            this.Controls.Add(this.lblTituloLivro);
            this.Controls.Add(this.lblPrateleira);
            this.Controls.Add(this.lblCodigoLivro);
            this.Controls.Add(this.lblCadastroLivros);
            this.Controls.Add(this.pcbLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadLivro";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pcbLivro;
        private Label lblCadastroLivros;
        private Label lblCodigoLivro;
        private Label lblPrateleira;
        private Label lblTituloLivro;
        private Label lblEstante;
        private Label lblAnoLivro;
        private Label lblAutor;
        private Label lblObservacoes;
        private Label lblClassificação;
        private Label lblEditora;
        private Label lblDataCadastro;
        private TextBox txbCodigoLivro;
        private TextBox txbPrateleira;
        private TextBox txbEstante;
        private TextBox txbTituloLivro;
        private TextBox txbAnoLivro;
        private TextBox txbAutor;
        private TextBox txbEditora;
        private TextBox txbClassificacao;
        private RichTextBox rtbObservacoes;
        private MonthCalendar mcdDataCadastroLivro;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnCadastrar;
        private PictureBox pcbSair;
    }
}