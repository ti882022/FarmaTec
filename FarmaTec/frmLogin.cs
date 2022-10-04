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
    public partial class frmLogin : Form
    {

        //Declaração de variáveis
        public bool LoginSucesso = false;

        public frmLogin()
        {
            InitializeComponent();
        }


        private void FecharTodos()
        {
            try
            {
                foreach (Form childForm in Application.OpenForms)
                {
                    if (childForm.Name != this.Name)
                    {
                        childForm.Close();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == String.Empty)
            {
                MessageBox.Show("Favor informar o usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
            }
            else if (mskSenha.Text == String.Empty)
            {
                MessageBox.Show("Favor digitar a senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskSenha.Focus();
            }
            else
            {
                FecharTodos();
                Form childForm = new frmPrincipal();
                childForm.Show();
            }
           

        }
 

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
