using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTec
{
    public partial class frmEditarCadastro : Form
    {
        public frmEditarCadastro()
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

        private void frmEditarCadastro_Load(object sender, EventArgs e)
        {

        }

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
