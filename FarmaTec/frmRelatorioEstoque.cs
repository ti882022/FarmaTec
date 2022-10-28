using System;
using System.Windows.Forms;

namespace FarmaTec
{
    public partial class frmRelatorioEstoque : Form
    {
        public frmRelatorioEstoque()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void frmRelatorioEstoque_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do Relatório?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            switch (keyData)
            {
                case Keys.Escape:
                    btnSair.PerformClick();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
