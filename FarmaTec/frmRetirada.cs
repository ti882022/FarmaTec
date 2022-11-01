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
    public partial class frmRetirada : Form
    {
        public frmRetirada()
        {
            InitializeComponent();
        }
        public void AbrirForm(Form childForm)
        {
            childForm.StartPosition = FormStartPosition.CenterScreen;
            int x = (this.Width - childForm.Width) / 2;
            int y = (this.Height - childForm.Height) / 2;
            childForm.Show();
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




        private void menuConsultaClientes_Click(object sender, EventArgs e)
        {
            Form childForm = new frmConsultarClientes();
            AbrirForm(childForm);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da compra?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void frmRetirada_Load(object sender, EventArgs e)
        {
            ListarPagamento();
        }

        private async void btnReceber_Click(object sender, EventArgs e)
        {




            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            try
            {
                SalvarRetirada salvarRetirada = new SalvarRetirada();
                RetiradaDTO dados = new RetiradaDTO();

                mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                DataRowView drv = (DataRowView)cboFormaPagamento.Items[cboFormaPagamento.SelectedIndex];
                        string formaPagamento = drv["formaPgto"].ToString();


                        dados.nPedido = Convert.ToInt32(txtnumpedido.Text);
                        dados.cpf = mskCpf.Text;
                        dados.formaPgto = Convert.ToInt32(formaPagamento);
                       
                        await salvarRetirada.RetirarPedidos(dados);

                        if (dados.nPedido > 0)
                        {
                            MessageBox.Show("Compra Realizada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                           
                            txtValorTotal.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível realizar o cadastro " + dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        


            }
          
        }
    
}
