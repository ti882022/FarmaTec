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

namespace FarmaTec
{
    public partial class frmCadastroFornecedor : Form
    {
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
            txtNomeFornecedor.Clear();
            txtCodigo.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            mskCep.Clear();
            mskCnpj.Clear();
            mskTelefone.Clear();
            txtUf.Clear();
            txtEmailFornecedor.Clear();
            txtCidade.Clear();
            

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

            //Remover a máscara do CEP - formatação
            //Verificar se os campos uf e telefone estão vazios
            if (txtUf.Text != string.Empty && mskTelefone.Text == String.Empty)
            {
               

                if (mskCep.Text == string.Empty)
                {
                    MessageBox.Show("Favor informar o CEP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mskCep.Focus();
                    finalizar = true;
                }
                else
                {
                    mskCep.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                }
            }
            mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;


            //Apresentar msg para preencher o campo
            if (finalizar == true && mskCnpj.Text != String.Empty)
            {
                MessageBox.Show("Favor preencher o campo" + textBox.Name.Substring(3, textBox.Name.Length - 3), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            if (finalizar == false)
            {

                //Popular a classe
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


                //Chamar o método
                salvarContatos.FornecedoresIncluir(dados);
                //Verificar o resultado
                if (dados.codigo != 0)
                {
                    //Popular o campo código
                    txtCodigo.Text = dados.codigo.ToString();
                    MessageBox.Show("Cadastro realizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Desabilitar(null, null);

                }
                else
                {
                    MessageBox.Show("Não foi possível realizar o cadastro " + dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void Desabilitar(object sender, EventArgs e)
        {
            txtNomeFornecedor.Enabled = false;
            mskCnpj.Enabled = false;
            mskCep.Enabled = false;
            txtEmailFornecedor.Enabled = false;
            txtCodigo.Enabled = false;
            txtUf.Enabled = false;
            txtCidade.Enabled = false;
            txtBairro.Enabled = false;
            txtNumero.Enabled = false;
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = false;
            txtEndereco.Enabled = false;
            mskTelefone.Enabled = false;
        }


        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigoFornecedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
