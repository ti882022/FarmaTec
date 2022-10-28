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
        public int codigoClasse;

        private void ListarCargos()
        {
            try
            {
                ConsultarCargo consultarcargo = new ConsultarCargo();
                CargosDTO dados = new CargosDTO();

                consultarcargo.CarregarCombo(dados);

                //Limpar fonte de dados e limpar combo
                cmbCargo.DataSource = null;
                cmbCargo.Items.Clear();

                //Popular o listbox
                //Definir o código do cargo, porém irá apresentar somente o nome do cargo
                cmbCargo.ValueMember = "classeUsuario";
                cmbCargo.DisplayMember = "descricao";
                cmbCargo.DataSource = consultarcargo.CargosDataTable;
                //Trazer os dados para serem selecionados
                cmbCargo.SelectedIndex = -1;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do Editor de Cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tratamentoCampos.Vazio(this) == true)
                {
                    tratamentoCampos.Bloquear(this);
                    if (MessageBox.Show("Deseja Editar o Cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ConsultarUsers consultarUsers = new ConsultarUsers();
                        UsuariosDTO dados = new UsuariosDTO();

                        dados.usuario = txtCodigoFuncionario.Text;
                        dados.nome = txtNomeFuncionario.Text;
                        dados.email = txtEmailFuncionario.Text;

                        DataRowView drv = (DataRowView)cmbCargo.Items[cmbCargo.SelectedIndex];
                        string cargoFunc = drv["classeUsuario"].ToString();

                        dados.classeUsuario = Convert.ToInt32(cargoFunc);

                        if (radAtivo.Checked == true) dados.logado = 1;
                        if (radDesativado.Checked == true) dados.logado = 4;
                        if (radReset.Checked == true) dados.logado = 3;

                        await consultarUsers.EditarCadastro(dados);
                        if (dados.mensagens == null)
                        {

                            if (dados.logado == 0)
                            {
                                MessageBox.Show("Não foi possível alterar o cadastro " + dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            else
                            {
                                MessageBox.Show("Cadastro Atualizado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Close();
                            }

                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show(e.ToString());
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


                    if (dados.mensagens != null)
                    {
                        MessageBox.Show(dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tratamentoCampos.Bloquear(this);
                        txtCodigoFuncionario.Enabled = true;
                        txtCodigoFuncionario.BackColor = System.Drawing.Color.White;
                        txtCodigoFuncionario.Focus();
                    }
                    else
                    {
                        for (int i = 0; i < consultarUsers.listusuarios.Count; i++)
                        {
                            txtNomeFuncionario.Text = consultarUsers.listusuarios[i].nomeFunc.ToString();
                            txtEmailFuncionario.Text = consultarUsers.listusuarios[i].emailFunc.ToString();
                            switch (consultarUsers.listusuarios[i].statusFunc.ToString())
                            {
                                case "1":
                                    this.radAtivo.Checked = true;
                                    break;
                                case "2":
                                    this.radAtivo.Checked = true;
                                    break;
                                case "3":
                                    this.radReset.Checked = true;
                                    break;
                                case "4":
                                    this.radDesativado.Checked = true;
                                    break;
                            }
                            for (int j = 0; j < cmbCargo.Items.Count; j++)
                            {
                                DataRowView drv = (DataRowView)cmbCargo.Items[j];
                                string cargoFunc = drv["classeUsuario"].ToString();

                                cmbCargo.SelectedIndex = -1;
                                if (consultarUsers.listusuarios[i].cargoFunc.ToString() == cargoFunc)
                                {
                                    cmbCargo.SelectedIndex = j;
                                    j = cmbCargo.Items.Count;
                                    cmbCargo.Enabled = true;
                                }
                            }
                        }
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

        public void frmEditarCadastro_Load(object sender, EventArgs e)
        {
            ListarCargos();
            this.Text = "Editar Cadastro de Funcionários - FarmaTec - Usuário: " + LoginSistema.nomeUsuario;
           
        }

        private void cmbCargo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            codigoClasse = Convert.ToInt32(cmbCargo.SelectedValue.ToString());
        }
    }
}




