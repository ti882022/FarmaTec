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
        public void AbrirForm(Form childForm)
        {
            childForm.StartPosition = FormStartPosition.CenterScreen;
            int x = (this.Width - childForm.Width) / 2;
            int y = (this.Height - childForm.Height) / 2;
            childForm.Show();
        }


        private void menuConsultaClientes_Click(object sender, EventArgs e)
        {
            Form childForm = new frmConsultarClientes();
            AbrirForm(childForm);
        }
    }
}
