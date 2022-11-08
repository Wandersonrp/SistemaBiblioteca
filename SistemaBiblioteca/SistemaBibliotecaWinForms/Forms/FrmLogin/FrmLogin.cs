using SistemaBibliotecaWinForms.Servicos;

namespace SistemaBibliotecaWinForms.Forms.FrmLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
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
