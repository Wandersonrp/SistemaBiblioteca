using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBibliotecaWinForms.Forms.CadastrarLivros
{
    public partial class FrmCadLivro : Form
    {
        public FrmCadLivro()
        {
            InitializeComponent();
        }

        private void PcbSairClick(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
