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
    public partial class frmAlterarSenha : Form
    {
        TratamentoCampos tratamentoCampos = new TratamentoCampos();

        public frmAlterarSenha()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void frmAlterarSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (mskNovaSenha.Text == mskConfirmarSenha.Text)
            {
                if (tratamentoCampos.Vazio(this) == true)
                {
                    tratamentoCampos.Bloquear(this);
                    if (MessageBox.Show("Deseja Finalizar o Cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (MessageBox.Show("Cadastro Realizado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                        {
                            tratamentoCampos.Limpar(this);
                            tratamentoCampos.Desbloquear(this);
                            Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Senhas digitadas estão diferentes.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tratamentoCampos.Limpar(this);
                mskNovaSenha.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tratamentoCampos.Limpar(this);
            mskNovaSenha.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            switch (keyData)
            {
                case Keys.Enter:
                    btnSalvar.PerformClick();
                    return true;

                case Keys.F12:
                    btnLimpar.PerformClick();
                    return true;
                case Keys.Escape:
                    if (MessageBox.Show("Deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Close();
                    }
                    return true;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
