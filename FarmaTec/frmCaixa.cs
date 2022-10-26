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


        //Coleção para o AutoComplete
        AutoCompleteStringCollection autocomplete = new AutoCompleteStringCollection();

     

        public async void AutoCompletar()
        {


            try
            {
                //Instanciar as classes
                ConsultarClientes consultarClientes = new ConsultarClientes();
                ClientesDTO dados = new ClientesDTO();

           

                //Popular classe
                dados.nome = txtnomecliente.Text;
               

                //Chamar o método
                await consultarClientes.MostrarCliente(dados);

                if (dados.mensagens == null)
                {
                    if (consultarClientes.listClientes.Count > 0)
                    {
                        //Percorrer a lista
                        for (int i = 0; i < consultarClientes.listClientes.Count; i++)
                        {
                            autocomplete.Add(consultarClientes.listClientes[i].nomeCliente.ToString());
                        }
                        //Definir as propriedades do autocomplete do textbox
                        txtnomecliente.AutoCompleteMode = AutoCompleteMode.Suggest;
                        txtnomecliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        txtnomecliente.AutoCompleteCustomSource = autocomplete;

                    }
                }
                else
                {
                    MessageBox.Show(dados.mensagens);
                }

            }


            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

        }


       public async void AutoCompletarProdutosCaixa()
        {


            try
            {
                //Instanciar as classes
                ConsultarProdutos consultarProdutos = new ConsultarProdutos();
                ProdutosDTO dados = new ProdutosDTO();

                //Popular classe
                dados.descricao = txtdescricao.Text;
                // dados.cpf = mskCpf.Text;

                //Chamar o método
                await consultarProdutos.MostrarProduto(dados);

                if (dados.mensagens == null)
                {
                    if (consultarProdutos.listProdutos.Count > 0)
                    {
                        //Percorrer a lista
                        for (int i = 0; i < consultarProdutos.listProdutos.Count; i++)
                        {
                            autocomplete.Add(consultarProdutos.listProdutos[i].descricao.ToString());
                        }
                        //Definir as propriedades do autocomplete do textbox
                        txtdescricao.AutoCompleteMode = AutoCompleteMode.Suggest;
                        txtdescricao.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        txtdescricao.AutoCompleteCustomSource = autocomplete;

                    }
                }
                else
                {
                    MessageBox.Show(dados.mensagens);
                }

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

        }

      


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
            AutoCompletar();
            AutoCompletarProdutosCaixa();
        }

        private async void btnIncluir_Click_1(object sender, EventArgs e)
        {
           
            if (txtnomecliente.Text == String.Empty && txtdescricao.Text == String.Empty)
            {
                MessageBox.Show("Favor inserir o nome do Cliente e do Produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnomecliente.BackColor = Color.Red;
                txtdescricao.BackColor = Color.Red;
                txtnomecliente.Focus();
            }
            else if (txtnomecliente.Text == String.Empty)
            {
                MessageBox.Show("Favor inserir o nome do Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtnomecliente.BackColor = Color.Red;
               txtdescricao.BackColor = Color.Green;
               txtnomecliente.Focus();
            }


            else if (txtdescricao.Text == String.Empty)
            {
                MessageBox.Show("Favor inserir o nome do Produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdescricao.BackColor = Color.Red;
                txtnomecliente.BackColor = Color.Green;
                txtdescricao.Focus();
            }

            else {
                txtnomecliente.BackColor = Color.White;
                txtdescricao.BackColor = Color.White;
                txtnomecliente.Enabled = false;
                txtdescricao.Clear();
                txtCodProduto.Clear();
               
            }



                    //Realizar a pesquisa do produto no banco de dados.
            try
            {
                //Instanciar as classes
                ConsultarProdutos consultarProdutos = new ConsultarProdutos();
                ProdutosDTO dados = new ProdutosDTO();



                //Popular classe
                dados.descricao = txtdescricao.Text;


                //Chamar o método
                await consultarProdutos.MostrarProduto(dados);


                //Popular o campo código
                for (int i = 0; i < consultarProdutos.listProdutos.Count; i++)
                {
                    txtCodProduto.Text =   consultarProdutos.listProdutos[i].codProduto.ToString();
                  
                    
                  
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)

        {
            
           
           
        }

        private void mskDesconto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void txtdesconto_TextChanged_1(object sender, EventArgs e)
        {
            if (txtdesconto.Text != string.Empty)
            {
                double number = int.Parse(txtValor.Text);
                double porcentagem = number * Convert.ToDouble(txtdesconto.Text) / 100;
                double porcentagemtotal = number - porcentagem;
                txtValorTotal.Text = porcentagemtotal.ToString();
            }
            else
            {
                MessageBox.Show("Favor inserir a porcentagem de desconto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorTotal.Text = txtValor.Text;
            }
        }
    }

    }

