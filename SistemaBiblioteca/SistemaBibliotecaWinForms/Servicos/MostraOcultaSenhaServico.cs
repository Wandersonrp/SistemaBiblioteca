namespace SistemaBibliotecaWinForms.Servicos
{
    public class MostraOcultaSenhaServico
    {
        public static void OcultarMostrarSenha(TextBox txbSenha, CheckBox cbxSenha)
        {
            if (cbxSenha.Checked)
            {
                txbSenha.PasswordChar = '\u0000';
            }
            else
            {
                txbSenha.PasswordChar = '*';
            }
        }
    }
}
