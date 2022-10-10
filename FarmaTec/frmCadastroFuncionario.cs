using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TransferenciaDados;

namespace FarmaTec
{
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
        {
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

            catch(Exception e) 
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
            //Popular a classe
            dados.nome = txtusuario.Text;
            dados.usuario = txtusuario.Text;
            dados.cargo = codigoClasse;
            dados.telefone = mskTelefone.Text;
            dados.email = txtEmailFuncionario.Text;
            dados.sexo = txtsexo.Text;


            //Chamar o método para incluir dados

            await salvarFuncionario.FuncionariosIncluir(dados);
            
            if (dados.mensagens == "0")
            {
                MessageBox.Show("Não foi possível efetuar o cadastro!!");

            }
            else if (dados.mensagens == "1")
            {
                MessageBox.Show("Dados cadastrado com sucesso!!");
            }

            else 
            {
                MessageBox.Show(dados.mensagens);
            }


            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           


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

        }

        private void mskTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtsexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtsexo_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void txtCodigoFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboclassefunc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            codigoClasse = Convert.ToInt32(cboclassefunc.SelectedValue.ToString());
        }
    }
}
