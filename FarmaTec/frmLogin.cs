using System;
using System.Drawing;
using System.Windows.Forms;
using TransferenciaDados;

namespace FarmaTec
{
    public partial class frmLogin : Form
    {
        TratamentoCampos tratamentoCampos = new TratamentoCampos();

        //Declaração de variáveis
        public bool LoginSucesso = false;

        public frmLogin()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }


        private async void btnAcessar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtusuario.Text == String.Empty)
                {
                    MessageBox.Show("Favor informar o usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtusuario.Focus();
                }
                else if (mskSenha.Text == String.Empty)
                {
                    MessageBox.Show("Favor digitar a senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mskSenha.Focus();
                }
                else
                {

                    //Instanciar as classes
                    UsuarioAutenticar usuarioAutenticar = new UsuarioAutenticar();
                    UsuariosDTO dados = new UsuariosDTO();



                    //Popular classe
                    dados.usuario = txtusuario.Text;
                    dados.senha = mskSenha.Text;




                    //Chamar o método
                    await usuarioAutenticar.ValidarUsuario(dados);
                   

                    if (dados.mensagens == null)
                    {
                        MessageBox.Show("Usuário ou senha inválidas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tratamentoCampos.Limpar(this);
                        txtusuario.Focus();
                    }
                    else
                    {
                        switch (dados.logado)
                        {
                            case 0:
                                MessageBox.Show("Usuário ou senha incorretos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                //Limpar os campos e posicionar o cursor no nome do usuário
                                txtusuario.Clear();
                                mskSenha.Clear();

                                txtusuario.Focus();

                                LoginSucesso = false;
                                break;

                            case 1:
                                LoginSucesso = true;
                                MessageBox.Show("Bem-vindo ao Sistema " + LoginSistema.nomeUsuario, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //Limpar os campos
                                txtusuario.Clear();
                                mskSenha.Clear();

                                if (LoginSucesso == true)
                                {
                                    Close();
                                }
                                break;

                            case 2:
                                MessageBox.Show("Usuário já Conectado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Limpar os campos e posicionar o cursor no nome do usuário
                                txtusuario.Clear();
                                mskSenha.Clear();

                                txtusuario.Focus();

                                LoginSucesso = false;

                                break;


                            case 3:
                                MessageBox.Show("Seu primeiro acesso" + " Será necessário alterar a senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                pnlMudarSenha.Location = new Point(50, 30);
                                mskSenhaAtual.Focus();
                                txtusuario.Enabled = false;
                                mskSenha.Enabled = false;
                                LoginSucesso = false;
                                break;




                            case 4:
                                MessageBox.Show(" Verifique o ocorrido" + " Junto ao Administrador do Sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Size = new Size(647, 471);
            this.Location = new Point(0, 0);
        }


        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mskSenhaAtual.Text == String.Empty)
                {
                    MessageBox.Show("Favor informar a senha atual", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mskSenhaAtual.Focus();
                }
                else if (mskNovaSenha.Text == String.Empty)
                {
                    MessageBox.Show("Favor digitar a nova senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mskNovaSenha.Focus();
                }
                else if (mskConfirmarSenha.Text == String.Empty)
                {
                    MessageBox.Show("Favor confirmar a nova senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mskConfirmarSenha.Focus();
                }
                else
                {
                    if (mskNovaSenha.Text == mskConfirmarSenha.Text)
                    {

                        //Instanciar as classes
                        UsuarioAutenticar usuarioAutenticar = new UsuarioAutenticar();
                        UsuariosDTO dados = new UsuariosDTO();




                        //Popular classe

                        dados.nome = LoginSistema.nomeUsuario;
                        dados.email = LoginSistema.emailUsuario;
                        dados.senha = mskSenhaAtual.Text;
                        dados.senhaNova = mskNovaSenha.Text;




                        //Chamar o método
                        await usuarioAutenticar.AlterarSenha(dados);


                        if (dados.mensagens != null)
                        {
                            MessageBox.Show("Contate o suporte \r\n" + dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Senha alterada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            pnlMudarSenha.Location = new Point(650, 0);
                            mskSenha.Clear();
                            txtusuario.Enabled = true;
                            mskSenha.Enabled = true;
                            LoginSucesso = false;
                        }
                        mskSenha.Focus();
                    }

                    else
                    {
                        MessageBox.Show("As novas senhas digitadas estão divergentes.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        mskNovaSenha.Focus();
                        mskNovaSenha.Clear();
                        mskConfirmarSenha.Clear();
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            switch (keyData)
            {
                case Keys.Enter:
                    if (txtusuario.Enabled == true)
                    {
                        btnAcessar.PerformClick();
                    }
                    else
                    {
                        btnSalvar.PerformClick();
                    }
                    return true;

                case Keys.Escape:
                    this.Close();
                    return true;

                case Keys.F12:
                    btnLimpar.PerformClick();
                    return true;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskSenhaAtual.Clear();
            mskNovaSenha.Clear();
            mskConfirmarSenha.Clear();
            mskSenhaAtual.Focus();
        }
    }
}
