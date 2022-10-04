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


            //Popular a classe
            dados.nome = txtNomeFuncionario.Text;
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
            txtCodigoFuncionario.Clear();
            mskTelefone.Clear();
            txtNomeFuncionario.Clear();
            txtEmailFuncionario.Clear();
            txtusuario.Clear();
        }

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            MySqlConnection conn = new MySqlConnection("datasource=localhost; database=bdfarmacia;port=3306; username = root; password=");
            string query = "SELECT descricao FROM tbclasseusuario";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            conn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "tbclasseusuario");
            cmbCargo.DisplayMember = "descricao";
            conn.Close();


        }

        private void frmNovoAcesso_Load(object sender, EventArgs e)
        {

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
    }
}
