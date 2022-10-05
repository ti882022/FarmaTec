using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransferenciaDados;
using System.Text.RegularExpressions;

namespace FarmaTec
{
    public partial class frmCadastroFornecedor : Form
    {
        TratamentoCampos tratamentoCampos = new TratamentoCampos();

        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tratamentoCampos.Limpar(this);
            txtNomeFornecedor.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instanciar as classes
            SalvarContatos salvarContatos = new SalvarContatos();
            ForncedoresDTO dados = new ForncedoresDTO();
            //validar se os campos estão preenchidos
            //Definir vaiável para receber o nome do textbox
            TextBox textBox = new TextBox();
            //Variável para indicar o textbox que irá receber o focus/msg
            bool finalizar = false;

            //Criar uma consulta LINQ
            var controle = from crtl in this.Controls.OfType<TextBox>()
                           where crtl.Name != "txtCodigo"
                           orderby crtl.TabIndex
                           select crtl;

            //Percorrer a consulta e verificar quais os campos não foram preenchidos

            foreach (var crtlTxt in controle)
            {
                if (crtlTxt.Text == string.Empty)
                {
                    finalizar = true;
                    textBox.Name = crtlTxt.Name;
                    crtlTxt.Focus();
                    break;
                }
            }

            mskCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (tratamentoCampos.Vazio(this) == true)
            {
                Regex mRegxExpression;
                if (txtEmailFornecedor.Text.Trim() != string.Empty)
                {
                    mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                    if (!mRegxExpression.IsMatch(txtEmailFornecedor.Text.Trim()))
                    {
                        MessageBox.Show("Formato de E-mail incorreto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmailFornecedor.Focus();
                    }
                    else
                    {
                        tratamentoCampos.Bloquear(this);
                        if (MessageBox.Show("Deseja Finalizar o Cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            dados.nome = txtNomeFornecedor.Text;
                            dados.endereco = txtEndereco.Text;
                            dados.numero = Convert.ToInt32(txtNumero.Text);
                            dados.bairro = txtBairro.Text;
                            dados.cidade = txtCidade.Text;
                            dados.uf = txtUf.Text;
                            dados.cep = mskCep.Text;
                            dados.cnpj = mskCnpj.Text;
                            dados.telefone = mskTelefone.Text;
                            dados.email = txtEmailFornecedor.Text;

                            salvarContatos.FornecedoresIncluir(dados);

                            if (dados.codigo != 0)
                            {
                                //Popular o campo código
                                txtCodigo.Text = dados.codigo.ToString();
                                MessageBox.Show("Cadastro Realizado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tratamentoCampos.Limpar(this);
                                tratamentoCampos.Desbloquear(this);
                            }
                            else
                            {
                                MessageBox.Show("Não foi possível realizar o cadastro " + dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }   
        }

        private void mskCnpj_MouseClick(object sender, MouseEventArgs e)
        {
            mskCnpj.Select(0, 0);
        }

        private void mskCep_MouseClick(object sender, MouseEventArgs e)
        {
            mskCep.Select(0, 0);
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            switch (keyData)
            {
                case Keys.Enter:
                    btnSalvar.PerformClick();
                    return true;

                case Keys.Escape:
                    btnSair.PerformClick();
                    return true;

                case Keys.F12:
                    btnLimpar.PerformClick();
                    return true;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void mskTelefone_MouseClick(object sender, MouseEventArgs e)
        {
            mskTelefone.Select(0, 0);
        }
    }
}
