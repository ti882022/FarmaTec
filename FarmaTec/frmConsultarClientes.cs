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
    public partial class frmConsultarClientes : Form
    {
        public frmConsultarClientes()
        {
            InitializeComponent();
        }


        //Coleção para o AutoComplete
        AutoCompleteStringCollection autocomplete = new AutoCompleteStringCollection();

        public async void AutoCompletar()
        {


            try
            {
                //Instanciar as classes
                ConsultarClientes consultarClientes = new ConsultarClientes();
                ClientesDTO dados = new ClientesDTO();

                //   txtnomeCliente.Text = "Ewerthon";

                //Popular classe
                dados.nome = txtnomeCliente.Text;
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
                            autocomplete.Add(consultarClientes.listClientes[i].nomeCliente.ToString());
                        }
                        //Definir as propriedades do autocomplete do textbox
                        txtnomeCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
                        txtnomeCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        txtnomeCliente.AutoCompleteCustomSource = autocomplete;

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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                ConsultarClientes consultarClientes = new ConsultarClientes();
                ClientesDTO dados = new ClientesDTO();

                mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                //Popular classe
                dados.nome = txtnomeCliente.Text;
                dados.cpf = mskCpf.Text;

                //Limpar fonte de dados e o DatagridView
                dtClientes.DataSource = null;
                dtClientes.Rows.Clear();

                //Chamar o método
                await consultarClientes.MostrarCliente(dados);

                for (int i = 0; i < consultarClientes.listClientes.Count; i++)
                {
                    dtClientes.Rows.Add(consultarClientes.listClientes[i].codCliente.ToString(),
                                            consultarClientes.listClientes[i].nomeCliente.ToString(),
                                            consultarClientes.listClientes[i].endereco.ToString(),
                                            consultarClientes.listClientes[i].cep.ToString(),
                                            consultarClientes.listClientes[i].cidade.ToString(),
                                            consultarClientes.listClientes[i].bairro.ToString(),
                                            consultarClientes.listClientes[i].uf.ToString(),
                                            consultarClientes.listClientes[i].cpf.ToString(),
                                            consultarClientes.listClientes[i].foneCliente.ToString(),
                                            consultarClientes.listClientes[i].emailCliente.ToString());
                }
                if (dados.mensagens != null)
                {
                    MessageBox.Show("Contate o suporte \r\n" + dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                mskCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmConsultarClientes_Load(object sender, EventArgs e)
        {
            AutoCompletar();
        }
    }
}
