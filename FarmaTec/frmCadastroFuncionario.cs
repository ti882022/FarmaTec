using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TransferenciaDados;

namespace FarmaTec
{
    public partial class frmCadastroFuncionario : Form
    {
        TratamentoCampos tratamentoCampos = new TratamentoCampos();
        public frmCadastroFuncionario()
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
                cboclassefunc.DataSource = null;
                cboclassefunc.Items.Clear();

                //Popular o listbox
                //Definir o código do cargo, porém irá apresentar somente o nome do cargo
                cboclassefunc.ValueMember = "classeUsuario";
                cboclassefunc.DisplayMember = "descricao";
                cboclassefunc.DataSource = consultarcargo.CargosDataTable;
                //Trazer os dados para serem selecionados
                cboclassefunc.SelectedIndex = -1;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instanciar as classes
            SalvarFuncionario salvarFuncionario = new SalvarFuncionario();
            funcionariosDTO dados = new funcionariosDTO();

            mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (tratamentoCampos.Vazio(this) == true)
            {
                Regex mRegxExpression;
                if (txtEmailFuncionario.Text.Trim() != string.Empty)
                {
                    mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                    if (!mRegxExpression.IsMatch(txtEmailFuncionario.Text.Trim()))
                    {
                        MessageBox.Show("Formato de E-mail incorreto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmailFuncionario.Focus();
                    }
                    else
                    {
                        tratamentoCampos.Bloquear(this);
                        if (MessageBox.Show("Deseja Finalizar o Cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            dados.nome = txtNomeFuncionario.Text;
                            dados.usuario = txtUsuario.Text;
                            dados.cargo = Convert.ToInt32(codigoClasse);
                            dados.telefone = mskTelefone.Text;
                            dados.email = txtEmailFuncionario.Text;
                            dados.sexo = txtsexo.Text;


                            //Chamar o método para incluir dados

                            await salvarFuncionario.FuncionariosIncluir(dados);

                            if (dados.mensagens == null)
                            {

                                if (dados.codigo == 0)
                                {
                                    MessageBox.Show("Não foi possível realizar o cadastro " + dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                else
                                {
                                    txtCodigoFuncionario.Text = dados.codigo.ToString();
                                    MessageBox.Show("Cadastro Realizado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (MessageBox.Show("Deseja Realizar um novo Cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        tratamentoCampos.Limpar(this);
                                        tratamentoCampos.Desbloquear(this);
                                        txtsexo.SelectedIndex = -1;
                                        txtNomeFuncionario.Focus();
                                    }
                                    else
                                    {
                                        txtsexo.SelectedIndex = -1;
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tratamentoCampos.Limpar(this);
            txtUsuario.Focus();
        }

        private void frmNovoAcesso_Load(object sender, EventArgs e)
        {
            /*  using (MySqlConnection con = new MySqlConnection("datasource = localhost; database = bdfarmacia; port = 3306; username = root; password = "))
              {
                  con.Open();
                  MySqlCommand cmd = new MySqlCommand("SELECT *FROM tbclasseusuario", con);
                  MySqlDataReader dr = cmd.ExecuteReader();
                  List<string> list = new List<string>();
                  while (dr.Read())
                  {
                      list.Add(dr["descricao"].ToString());
                  }
                  dr.Close();
                  list = list.Distinct().ToList();
                  list.Sort();
                  txtclassefunc.DataSource = list;


              }
            */
            ListarCargos();
            this.Text = "Novo Funcionário - FarmaTec - Usuário: " + LoginSistema.nomeUsuario;
        }


        private void cboclassefunc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            codigoClasse = Convert.ToInt32(cboclassefunc.SelectedValue.ToString());
        }

        private void mskTelefone_MouseClick(object sender, MouseEventArgs e)
        {
            mskTelefone.Select(0, 0);
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
                    txtsexo.Items.Clear();
                    return true;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
