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
    public partial class frmLogin : Form
    {

        //Declaração de variáveis
        public bool LoginSucesso = false;

        public frmLogin()
        {
            InitializeComponent();
        }


        private async void btnAcessar_Click(object sender, EventArgs e)
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
                try
                {
                    //Instanciar as classes
                    UsuarioAutenticar usuarioAutenticar = new UsuarioAutenticar();
                    UsuariosDTO dados = new UsuariosDTO();



                    //Popular classe
                    dados.usuario = txtusuario.Text;
                    dados.senha = mskSenha.Text;

                   



                

                    //Chamar o método
                    await usuarioAutenticar.ValidarUsuario(dados);

                    for (int i = 0; i < consultarProdutos.listProdutos.Count; i++)
                    {
                        dtProdutos.Rows.Add(consultarProdutos.listProdutos[i].codProduto.ToString(),
                                                consultarProdutos.listProdutos[i].descricao.ToString(),
                                                consultarProdutos.listProdutos[i].marca.ToString(),
                                                consultarProdutos.listProdutos[i].fornecedor.ToString(),
                                                consultarProdutos.listProdutos[i].categoria.ToString(),
                                                consultarProdutos.listProdutos[i].qtde.ToString(),
                                               Convert.ToDecimal(consultarProdutos.listProdutos[i].preco));

                    }
                    if (dados.mensagens != null)
                    {
                        MessageBox.Show("Contate o suporte \r\n" + dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
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
