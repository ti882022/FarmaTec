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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }

        private void lblCodCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instanciar as classes
            SalvarContatos salvarContatos = new SalvarContatos();
            ContatosDTO dados = new ContatosDTO();



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
            if (txtNome.Text != string.Empty && txtEmail.Text == String.Empty)
            {
               

                if (mskCpf.Text == string.Empty)
                {
                    MessageBox.Show("Favor informar o CEP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    mskCpf.Focus();
                    finalizar = true;
                }
                else
                {
                    mskCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                }
            }

            //Apresentar msg para preencher o campo
            if (finalizar == true && mskCpf.Text != String.Empty)
            {
                MessageBox.Show("Favor preencher o campo" + textBox.Name.Substring(3, textBox.Name.Length - 3), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            if (finalizar == false)
            {

                

                //Popular a classe
                dados.nome = txtNome.Text;
                dados.cpf = mskCpf.Text;
                dados.email = txtEmail.Text;
                dados.endereco = string.Empty;
                dados.cep = string.Empty;
                dados.cidade = string.Empty;
                dados.bairro = string.Empty;
                dados.uf = string.Empty;
                dados.telefone = string.Empty;
                dados.bairro = string.Empty;



                //Chamar o método
                salvarContatos.ClientesIncluir(dados);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
        public void Desabilitar(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            mskCpf.Enabled = false;
            txtEmail.Enabled = false;
            txtCodigo.Enabled = false;
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = false;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCodigo.Clear();
            mskCpf.Clear();
            txtEmail.Clear();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
        }

        private void mskCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }
    }

    }

