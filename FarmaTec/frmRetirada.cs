using System;
using System.Windows.Forms;

namespace FarmaTec
{
    public partial class frmRetirada : Form
    {
        public frmRetirada()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da Retirada de produtos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
