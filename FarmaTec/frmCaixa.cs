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
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
        }

        public int codigoPagamento;

        private void ListarPagamento()
        {
            try
            {
                ConsultarPagamento consultarpagamento = new ConsultarPagamento();
                PagamentoDTO dados = new PagamentoDTO();

                consultarpagamento.CarregarCombo(dados);

                //Limpar fonte de dados e limpar combo
                cboFormaPagamento.DataSource = null;
                cboFormaPagamento.Items.Clear();

                //Popular o listbox
                //Definir o código do cargo, porém irá apresentar somente o nome do cargo
                cboFormaPagamento.ValueMember = "formaPgto";
                cboFormaPagamento.DisplayMember = "descricao";
                cboFormaPagamento.DataSource = consultarpagamento.PagamentoDataTable;
                //Trazer os dados para serem selecionados
                cboFormaPagamento.SelectedIndex = -1;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }





        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            txtNomeFuncionario.Text = LoginSistema.nomeUsuario;
            ListarPagamento();
        }

        private void btnIncluir_Click_1(object sender, EventArgs e)
        {

            if (txtNomeCliente.Text == String.Empty && txtNomeProduto.Text == String.Empty)
            {
                MessageBox.Show("Favor inserir o nome do Cliente e do Produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCliente.BackColor = Color.Red;
                txtNomeProduto.BackColor = Color.Red;
                txtNomeCliente.Focus();
            }
            else if (txtNomeCliente.Text == String.Empty)
            {
                MessageBox.Show("Favor inserir o nome do Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtNomeCliente.BackColor = Color.Red;
               txtNomeProduto.BackColor = Color.Green;
               txtNomeCliente.Focus();
            }


            else if (txtNomeProduto.Text == String.Empty)
            {
                MessageBox.Show("Favor inserir o nome do Produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeProduto.BackColor = Color.Red;
                txtNomeCliente.BackColor = Color.Green;
                txtNomeProduto.Focus();
            }

            else {
                txtNomeCliente.BackColor = Color.White;
                txtNomeProduto.BackColor = Color.White;
                txtNomeCliente.Enabled = false;
                txtNomeProduto.Clear();
                txtCodProduto.Clear();
               
            }
         
        }

        private void grpProduto_Paint(object sender, PaintEventArgs e)
        {
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da compra?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void menuEditarCadastro_Click(object sender, EventArgs e)
        {

        }

        private void cbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

         

        }

        private void dtPedido_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void txtNomeFuncionario_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtCodFuncionario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

