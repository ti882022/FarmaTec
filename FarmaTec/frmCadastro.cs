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
    public partial class frmCadastro : Form
    {
        TratamentoCampos tratamentoCampos = new TratamentoCampos();

        public frmCadastro()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instanciar as classes
            SalvarCliente salvarCliente = new SalvarCliente();
            ContatosDTO dados = new ContatosDTO();


            //validar se os campos estão preenchidos
            //Definir vaiável para receber o nome do textbox
            TextBox textBox = new TextBox();
            //Variável para indicar o textbox que irá receber o focus/msg

            //Criar uma consulta LINQ
            var controle = from crtl in this.Controls.OfType<TextBox>()
                           where crtl.Name != "txtCodigo"
                           orderby crtl.TabIndex
                           select crtl;

            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (tratamentoCampos.Vazio(this) == true)
            {
                Regex mRegxExpression;
                if (txtEmail.Text.Trim() != string.Empty)
                {
                    mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                    if (!mRegxExpression.IsMatch(txtEmail.Text.Trim()))
                    {
                        MessageBox.Show("Formato de E-mail incorreto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Focus();
                    }
                    else
                    {
                        tratamentoCampos.Bloquear(this);
                        if (MessageBox.Show("Deseja Finalizar o Cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            dados.nome = txtNome.Text;
                            dados.cpf = mskCpf.Text;
                            dados.email = txtEmail.Text;
                            dados.usuario = mskCpf.Text;
                            dados.senha = mskCpf.Text;
                            dados.logado = 3;
                            dados.endereco = string.Empty;
                            dados.cep = string.Empty;
                            dados.cidade = string.Empty;
                            dados.bairro = string.Empty;
                            dados.uf = string.Empty;
                            dados.telefone = string.Empty;
                            dados.bairro = string.Empty;

                            await salvarCliente.ClientesIncluir(dados);

                            if (dados.mensagens == null)
                            {


                                if (dados.codigo == 0)
                                {
                                    MessageBox.Show("Não foi possível realizar o Cadastro." + dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                else
                                {
                                    txtCodigo.Text = dados.codigo.ToString();
                                    MessageBox.Show("Cadastro Realizado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (MessageBox.Show("Deseja Realizar um novo Cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        tratamentoCampos.Limpar(this);
                                        tratamentoCampos.Desbloquear(this);
                                        txtNome.Focus();
                                    }
                                    else
                                    {
                                        Close();
                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("Não foi possível realizar o cadastro " + dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtNome.Focus();
        }

        private void mskCpf_MouseClick(object sender, MouseEventArgs e)
        {
            mskCpf.Select(0, 0);
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

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            this.Text = "Cadastro de Cliente - FarmaTec - Usuário: " + LoginSistema.nomeUsuario;
        }
    }

}

