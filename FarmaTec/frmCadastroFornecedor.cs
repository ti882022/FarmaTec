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
            this.KeyPreview = true;
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

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instanciar as classes
            SalvarFornecedores salvarFornecedores = new SalvarFornecedores();
            FornecedoresDTO dados = new FornecedoresDTO();
            //validar se os campos estão preenchidos
            //Definir vaiável para receber o nome do textbox
            TextBox textBox = new TextBox();
            //Variável para indicar o textbox que irá receber o focus/msg
         

            //Criar uma consulta LINQ
            var controle = from crtl in this.Controls.OfType<TextBox>()
                           where crtl.Name != "txtCodigo"
                           orderby crtl.TabIndex
                           select crtl;

            //Percorrer a consulta e verificar quais os campos não foram preenchidos

          
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

                          await salvarFornecedores.FornecedoresIncluir(dados);

                            if (dados.mensagens == null)
                            {
                                if (dados.codigo == 0)
                                {
                                    MessageBox.Show("Não foi possível realizar o cadastro." + dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    txtCodigo.Text = dados.codigo.ToString();
                                    MessageBox.Show("Cadastro Realizado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (MessageBox.Show("Deseja Realizar um novo Cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        tratamentoCampos.Limpar(this);
                                        tratamentoCampos.Desbloquear(this);
                                        txtNomeFornecedor.Focus();
                                    }
                                    else
                                    {
                                        Close();
                                    }
                                }

                            }
                        }
                        else
                        {
                            tratamentoCampos.Desbloquear(this);
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

        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            this.Text = "Cadastro de Fornecedor - FarmaTec - Usuário: " + LoginSistema.nomeUsuario;

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
