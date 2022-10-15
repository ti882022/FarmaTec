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
    public partial class frmConsultarProdutos : Form
    {
        public frmConsultarProdutos()
        {
            InitializeComponent();
        }

        private void pctProdutos_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da Consulta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }




        private async void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                //Instanciar as classes
                ConsultarProdutos consultarProdutos = new ConsultarProdutos();
                ProdutosDTO dados = new ProdutosDTO();

        

                //Popular classe
                dados.descricao = txtdescricao.Text;
                dados.codigo = Convert.ToInt32(txtcodproduto.Text);

                //Limpar fonte de dados e o DatagridView
                dtProdutos.DataSource = null;
                dtProdutos.Rows.Clear();

                //Chamar o método
                await consultarProdutos.MostrarProduto(dados);

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

        private void dtProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmConsultarProdutos_Load(object sender, EventArgs e)
        {
           

        }
    }
}
