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


using System.Text.Json;
using System.Text.Json.Serialization;


//Namespace para APi rest
using System.Net.Http;
//using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


using TransferenciaDados;

namespace FarmaTec
{
    public partial class frmCaixa : Form
    {
        TratamentoCampos tratamentoCampos = new TratamentoCampos();
        public frmCaixa()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        public int codigoPagamento;


        //Coleção para o AutoComplete
        AutoCompleteStringCollection autocompleteCliente = new AutoCompleteStringCollection();
        AutoCompleteStringCollection autocompleteProduto = new AutoCompleteStringCollection();



        public async void AutoCompletarCliente()
        {

            try
            {
                //Instanciar as classes
                ConsultarClientes consultarClientes = new ConsultarClientes();
                ClientesDTO dados = new ClientesDTO();



                //Popular classe
                dados.nomeCliente = txtnomecliente.Text;
                // dados.cpf = mskCpf.Text;

                //Chamar o método
                await consultarClientes.MostrarCliente(dados);

                if (dados.mensagens == null)
                {
                    if (consultarClientes.listClientes.Count > 0)
                    {
                        //Percorrer a lista
                        for (int i = 0; i < consultarClientes.listClientes.Count; i++)
                        {
                            autocompleteCliente.Add(consultarClientes.listClientes[i].nomeCliente.ToString());
                        }
                        //Definir as propriedades do autocomplete do textbox
                        txtnomecliente.AutoCompleteMode = AutoCompleteMode.Suggest;
                        txtnomecliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        txtnomecliente.AutoCompleteCustomSource = autocompleteCliente;

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
                            autocompleteProduto.Add(consultarProdutos.listProdutos[i].descricao.ToString());
                        }
                        //Definir as propriedades do autocomplete do textbox
                        txtdescricao.AutoCompleteMode = AutoCompleteMode.Suggest;
                        txtdescricao.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        txtdescricao.AutoCompleteCustomSource = autocompleteProduto;

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

        private void frmCaixa_Load(object sender, EventArgs e)
        {

            txtNomeFuncionario.Text = LoginSistema.nomeUsuario;
            ListarPagamento();
            AutoCompletarCliente();
            AutoCompletarProdutosCaixa();

        }

        private async void btnIncluir_Click_1(object sender, EventArgs e)
        {
            //Realizar a pesquisa do produto no banco de dados.
            try
            {
                if (txtnomecliente.Text == String.Empty && txtdescricao.Text == String.Empty)
                {
                    MessageBox.Show("Favor inserir o nome do Cliente e do Produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnomecliente.Focus();
                }
                else if (txtnomecliente.Text == String.Empty)
                {
                    MessageBox.Show("Favor inserir o nome do Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnomecliente.Focus();
                }


                else if (txtdescricao.Text == String.Empty)
                {
                    MessageBox.Show("Favor inserir o nome do Produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdescricao.Focus();
                }
                else
                {
                    txtnomecliente.Enabled = false;


                    //Instanciar as classes
                    ConsultarProdutos consultarProdutos = new ConsultarProdutos();
                    ProdutosDTO dados = new ProdutosDTO();



                    //Popular classe
                    dados.descricao = txtdescricao.Text;


                    //Limpar fonte de dados e o DatagridView
                    //    dtvProduto.DataSource = null;



                    //Chamar o método
                    await consultarProdutos.MostrarProduto(dados);


                    //Popular o campo código
                    for (int i = 0; i < consultarProdutos.listProdutos.Count; i++)
                    {
                        txtCodProduto.Text = consultarProdutos.listProdutos[i].codProduto.ToString();
                        dtvProduto.Rows.Add(consultarProdutos.listProdutos[i].codProduto.ToString(),
                                                consultarProdutos.listProdutos[i].descricao.ToString(),
                                                Convert.ToDecimal(consultarProdutos.listProdutos[i].qtde.ToString()),
                                               Convert.ToDecimal(consultarProdutos.listProdutos[i].preco));



                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }



        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da compra?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }


        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            txtdescricao.Enabled = false;

            if (MessageBox.Show("Deseja finalizar a compra?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grpPagamento.Visible = true;
                dtvProduto.Enabled = false;
                txtnomecliente.Enabled = false;
                txtdescricao.Enabled = false;
            }
            else
            {
                btnCancelar.PerformClick();
            }
        }

        private void txtdesconto_TextChanged_1(object sender, EventArgs e)
        {
            /*  if (txtdesconto.Text != string.Empty)
              {
                  double number = int.Parse(txtValor.Text.ToString());
                  double porcentagem = number * Convert.ToDouble(txtdesconto.Text) / 100;
                  double porcentagemtotal = number - porcentagem;
                  txtValorTotal.Text = porcentagemtotal.ToString();
              }
              else
              {
                  MessageBox.Show("Favor inserir a porcentagem de desconto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  txtValorTotal.Text = txtValor.Text;
              }

              */
        }

        private void dtvProduto_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.ColumnIndex == 2)
                {
                    decimal preco = Convert.ToDecimal(dtvProduto.CurrentRow.Cells[3].Value);
                    decimal qtde = Convert.ToDecimal(dtvProduto.CurrentRow.Cells[2].Value);

                    if (preco.ToString() != "" && qtde.ToString() != "")
                    {
                        dtvProduto.CurrentRow.Cells[4].Value = preco * qtde;
                    }
                }

                decimal valorTotal = 0;
                string valor = "";
                if (dtvProduto.CurrentRow.Cells[4].Value != null)
                {
                    valor = dtvProduto.CurrentRow.Cells[4].Value.ToString();
                    if (!valor.Equals(""))
                    {
                        for (int i = 0; i <= dtvProduto.RowCount - 1; i++)
                        {
                            if (dtvProduto.Rows[i].Cells[4].Value != null)
                                valorTotal += Convert.ToDecimal(dtvProduto.Rows[i].Cells[4].Value);

                        }
                        if (valorTotal == 0)
                        {
                            MessageBox.Show("Nenhum registro encontrado");
                        }
                        txtValor.Text = valorTotal.ToString();


                        txtValorTotal.Text = txtValor.Text.ToString();
                    }

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private async void btnReceber_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja finalizar o pedido?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SalvarPedidos salvarPedidos = new SalvarPedidos();
                    PedidosDTO dados = new PedidosDTO();


                    //Percorrer o datagridview
                    if (dtvProduto.RowCount > 1)
                    {
                        bool salvar = false;
                        int qtderegistros = dtvProduto.RowCount;

                        List<ListarPedidos> listarPedidos = new List<ListarPedidos>();



                        for (int i = 0; i < dtvProduto.RowCount; i++)
                        {
                            if (dtvProduto.Rows[i].Cells[4].Value != null)
                            {
                                listarPedidos.Add(new ListarPedidos(Convert.ToInt32(dtvProduto.Rows[i].Cells[0].Value.ToString()),
                                     Convert.ToDecimal(dtvProduto.Rows[i].Cells[4].Value.ToString()),

                                     Convert.ToInt32(dtvProduto.Rows[i].Cells[2].Value.ToString())
                                    ));

                                salvar = true;

                            }
                        }


                        if (salvar == true)
                        {
                            DataRowView drv = (DataRowView)cboFormaPagamento.Items[cboFormaPagamento.SelectedIndex];
                            string formaPagamento = drv["formaPgto"].ToString();


                            dados.nomeCliente = txtnomecliente.Text.ToString();
                            dados.canalPgto = 12;
                            dados.formaPgto = Convert.ToInt32(formaPagamento);
                            dados.codFuncionario = LoginSistema.codFuncionario;
                            dados.dataPgto = DateTime.Now;
                            dados.dataEnvio = DateTime.Now;

                            //Serelizar Json
                            dados.produto = JsonSerializer.Serialize(listarPedidos);

                            await salvarPedidos.InserirPedidos(dados);

                            if (dados.nPedido > 0)
                            {
                                MessageBox.Show("Compra Realizada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                dtvProduto.Rows.Clear();
                                txtValorTotal.Clear();
                                txtValor.Clear();
                                grpPagamento.Visible = false;
                                btnCancelar.PerformClick();
                            }
                            else
                            {
                                MessageBox.Show("Não foi possível realizar o cadastro " + dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void AbrirForm(Form childForm)
        {
            childForm.StartPosition = FormStartPosition.CenterScreen;
            int x = (this.Width - childForm.Width) / 2;
            int y = (this.Height - childForm.Height) / 2;
            childForm.Location = new Point(x, y);
            childForm.Show();
        }

        private void menuConsultaProdutos_Click(object sender, EventArgs e)
        {
            Form childForm = new frmConsultarProdutos();
            AbrirForm(childForm);
        }

        private void menuConsultaClientes_Click(object sender, EventArgs e)
        {
            Form childForm = new frmConsultarClientes();
            AbrirForm(childForm);
        }

        private void menuCadastroClientes_Click(object sender, EventArgs e)
        {
            Form childForm = new frmCadastro();
            AbrirForm(childForm);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtnomecliente.Focus();
            txtdescricao.Clear();
            txtnomecliente.Clear();
            txtCodProduto.Clear();
            txtnomecliente.Enabled = true;
            txtdescricao.Enabled = true;
            dtvProduto.Rows.Clear();
            dtvProduto.Refresh();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            switch (keyData)
            {
                case Keys.Enter:
                    btnFinalizarCompra.PerformClick();
                    return true;

                case Keys.Escape:
                    btnSair.PerformClick();
                    return true;

                case Keys.F12:
                    btnCancelar.PerformClick();
                    txtnomecliente.Focus();
                    return true;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }

}

