using SistemaBibliotecaWinForms.Servicos;

namespace SistemaBibliotecaWinForms.Forms.Cadastrar
{
    public partial class FrmCadastrar : Form
    {
        public FrmCadastrar()
        {
            InitializeComponent();
        }

        private void CbxMostraSenhaClick(object sender, EventArgs e)
        {
            MostraOcultaSenhaServico.OcultarMostrarSenha(txbSenha, cbxMostraSenha);
        }

        private void PcbSairClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
