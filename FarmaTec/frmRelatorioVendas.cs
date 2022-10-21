using System;
using System.Windows.Forms;

namespace FarmaTec
{
    public partial class frmRelatorioVendas : Form
    {
        public frmRelatorioVendas()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do Relatório?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
