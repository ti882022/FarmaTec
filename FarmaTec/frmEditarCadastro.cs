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

            if (tratamentoCampos.Vazio(this) == true)
            {
                tratamentoCampos.Bloquear(this);
                if (MessageBox.Show("Deseja Editar o Cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Cadastro Atualizado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        tratamentoCampos.Limpar(this);
                        txtCodigoFuncionario.Enabled = true;

                    }
                }
            }
        }

        public async void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoFuncionario.Text != string.Empty)
                {
                    tratamentoCampos.Desbloquear(this);
                    txtCodigoFuncionario.Enabled = false;
                    txtCodigoFuncionario.BackColor = System.Drawing.Color.White;
                    txtNomeFuncionario.Focus();
                    //Instanciar as classes

                    ConsultarUsers consultarUsers = new ConsultarUsers();
                    ConsultarDTO dados = new ConsultarDTO();


                    //Popular classe
                    dados.usuario = txtCodigoFuncionario.Text;

                    //Chamar o método
                    await consultarUsers.MostrarUsuarios(dados);

                    for (int i = 0; i < consultarUsers.listusuarios.Count; i++)
                    {

                        //PAREI AQUI, BASEAR NO SAU FRMCONTATOS PARA CONTINUAR//

                        /*txtNomeUsuario.Text = consultarClientes.listClientes[i].codCliente.ToString(),
                                                consultarClientes.listClientes[i].nomeCliente.ToString(),
                                                consultarClientes.listClientes[i].endereco.ToString(),
                                                consultarClientes.listClientes[i].cep.ToString(),
                                                consultarClientes.listClientes[i].cidade.ToString(),
                                                consultarClientes.listClientes[i].bairro.ToString(),
                                                consultarClientes.listClientes[i].uf.ToString(),
                                                consultarClientes.listClientes[i].cpf.ToString(),
                                                consultarClientes.listClientes[i].foneCliente.ToString(),
                                                consultarClientes.listClientes[i].emailCliente.ToString());*/
                    }


                    if (dados.mensagens != null)
                    {
                        MessageBox.Show(dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha o código do cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    if ((txtCodigoFuncionario.Text != string.Empty) && (txtCodigoFuncionario.Enabled == true))
                    {
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

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoFuncionario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




