using System;
using System.Windows.Forms;

namespace FarmaTec
{
    public partial class frmRelatorioFinanceiro : Form
    {
        public frmRelatorioFinanceiro()
        {
            InitializeComponent();
        }

        private void frmRelatorioFinanceiro_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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
