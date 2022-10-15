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
        TratamentoCampos tratamentoCampos = new TratamentoCampos();

        public frmEditarCadastro()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do Editor de Cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (tratamentoCampos.Vazio(this) == true)
            {
                tratamentoCampos.Bloquear(this);
                if (MessageBox.Show("Deseja Editar o Cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Cadastro Atualizado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        tratamentoCampos.Limpar(this);
                        txtCodigoFuncionario.Enabled = true;
                        mskTelefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                    }
                }
            }
        }

        public void btnPesquisar_Click(object sender, EventArgs e)
        {
                    
                tratamentoCampos.Desbloquear(this);
                txtCodigoFuncionario.Enabled = false;
                txtCodigoFuncionario.BackColor = System.Drawing.Color.White;
                txtNomeFuncionario.Focus();

        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            switch (keyData)
            {
                case Keys.Enter:
                    if((txtCodigoFuncionario.Text != string.Empty) && (txtCodigoFuncionario.Enabled == true)){ 
                    btnPesquisar.PerformClick();
                    }
                    else
                    {
                    btnSalvar.PerformClick();
                    }
                    return true;

                case Keys.Escape:
                    btnSair.PerformClick();
                    return true;

                case Keys.F12:
                    btnSair.PerformClick();
                    return true;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


    }
}
