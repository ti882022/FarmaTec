using System;
using System.Windows.Forms;
using TransferenciaDados;



namespace FarmaTec
{
    public partial class cboEstoque : Form
    {
        public cboEstoque()
        {
            InitializeComponent();
        }

        AutoCompleteStringCollection autocomplete = new AutoCompleteStringCollection();

        public async void AutoCompletar()
        {


            try
            {
                //Instanciar as classes
                ConsultarEstoque consultarEstoque = new ConsultarEstoque();
                EstoqueDTO dados = new EstoqueDTO();

                //   txtnomeCliente.Text = "Ewerthon";

                //Popular classe
                dados.codigo = Convert.ToInt32(txtcodigo.Text);
                // dados.cpf = mskCpf.Text;

                //Chamar o método
                await consultarEstoque.MostrarEstoque(dados);

                if (dados.mensagens == null)
                {
                    if (consultarEstoque.listestoques.Count > 0)
                    {
                        //Percorrer a lista
                        for (int i = 0; i < consultarEstoque.listestoques.Count; i++)
                        {
                            autocomplete.Add(consultarEstoque.listestoques[i].codMvto.ToString());
                        }
                        //Definir as propriedades do autocomplete do textbox
                        txtcodigo.AutoCompleteMode = AutoCompleteMode.Suggest;
                        txtcodigo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        txtcodigo.AutoCompleteCustomSource = autocomplete;

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


        private void saida_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }










        private void cbocomprar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbocomprar.Text == "saida") { cbomotivo.Visible = true; }
            else { cbomotivo.Visible = false; }
        }

        private void codigoproduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Atualizar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                //Instanciar as classes
                ConsultarEstoque consultarestoque = new ConsultarEstoque();
                EstoqueDTO dados = new EstoqueDTO();

                //Popular classe
                dados.codigo = Convert.ToInt32(txtcodigo.Text);

                //Limpar fonte de dados e o DatagridView
                dtprodutos.DataSource = null;
                dtprodutos.Rows.Clear();

                //Chamar o método
                await consultarestoque.MostrarEstoque(dados);

                for (int i = 0; i < consultarestoque.listestoques.Count; i++)
                {
                    dtprodutos.Rows.Add(consultarestoque.listestoques[i].codMvto.ToString(),
                                            consultarestoque.listestoques[i].dataMvto.ToString(),
                                            consultarestoque.listestoques[i].codProduto.ToString(),
                                            consultarestoque.listestoques[i].qtdeMvto.ToString(),
                                            consultarestoque.listestoques[i].descricao.ToString());
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

        private void cboEstoque_Load(object sender, EventArgs e)
        {

        }
    }
}
