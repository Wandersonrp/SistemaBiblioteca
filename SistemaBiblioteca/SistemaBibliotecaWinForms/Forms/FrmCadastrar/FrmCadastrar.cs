using SistemaBibliotecaWinForms.Servicos;
using SistemaBibliotecaWinForms.Forms.FrmLogin;

namespace SistemaBibliotecaWinForms.Forms.FrmCadastrar
{
    public partial class FrmCadastrar : Form
    {
        public FrmCadastrar()
        {
            InitializeComponent();
        }

        private void PcbSairClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CbxMostraSenhaClick(object sender, EventArgs e)
        {
            MostraOcultaSenhaServico.OcultarMostrarSenha(txbSenha, cbxMostraSenha);
        }
    }
}
