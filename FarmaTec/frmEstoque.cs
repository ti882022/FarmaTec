﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TransferenciaDados;


namespace FarmaTec
{
    public partial class cboEstoque : Form
    {
        TratamentoCampos tratamentoCampos = new TratamentoCampos();
        public cboEstoque()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }
        public int codigostatus;
        private void ListarStatus()
        {
            try
            {
                Consultarstatus consultarstatus = new Consultarstatus();
                statussDTO dados = new statussDTO();



                consultarstatus.CarregarComboo(dados);



                //Limpar fonte de dados e limpar combo
                cbocomprar.DataSource = null;
                cbocomprar.Items.Clear();



                //Popular o listbox
                //Definir o código do cargo, porém irá apresentar somente o nome do cargo
                cbocomprar.ValueMember = "statusMvto";
                cbocomprar.DisplayMember = "descricao";
                cbocomprar.DataSource = consultarstatus.statusDataTable;
                //Trazer os dados para serem selecionados
                cbocomprar.SelectedIndex = -1;
            }



            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
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
                dados.codProduto = Convert.ToInt32(txtcodigo.Text);


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
                            autocomplete.Add(consultarEstoque.listestoques[i].codProduto.ToString());
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






       

       

       

        private void codigoproduto_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Atualizar_Click(object sender, EventArgs e)
        {
            SalvarMovimento salvarMovimento = new SalvarMovimento();
            MovimentacaoDTO dados = new MovimentacaoDTO();

            if (tratamentoCampos.Vazio(this) == true)
            {
                tratamentoCampos.Bloquear(this);
                if (MessageBox.Show("Deseja Finalizar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    dados.qtdeMvto = Convert.ToInt32(txtQuantidade.Text);
                    dados.codProduto = Convert.ToInt32(txtcodigo.Text);
                    if (codigostatus == 1) { dados.descricao = "Compra".ToString();}
                    else { dados.descricao = "Quebra".ToString();}
                    dados.txtstatus = Convert.ToInt32(codigostatus); 
                   



                    //Chamar o método para incluir dados

                    await salvarMovimento.Produtosmovimentar(dados);

                        if (dados.mensagens == null)
                        {

                            if (dados.qtdeMvto == 0)
                            {
                                MessageBox.Show("Não foi possível realizar o cadastro " + dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            else
                            {
                                txtQuantidade.Text = dados.qtdeMvto.ToString();
                                MessageBox.Show("Cadastro Realizado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tratamentoCampos.Limpar(this);
                                tratamentoCampos.Desbloquear(this);
                            }

                        }

                        else
                        {
                            MessageBox.Show(dados.mensagens, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                
            
            }
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
                dados.codProduto = Convert.ToInt32(txtcodigo.Text);
                

                //Limpar fonte de dados e o DatagridView
                dtprodutos.DataSource = null;
                dtprodutos.Rows.Clear();

                //Chamar o método
                await consultarestoque.MostrarEstoque(dados);

                for (int i = 0; i < consultarestoque.listestoques.Count; i++)
                {
                    dtprodutos.Rows.Add(consultarestoque.listestoques[i].codProduto.ToString(), consultarestoque.listestoques[i].descricao.ToString());                       
                                            
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
            ListarStatus();
        }

        private void cbocomprar_Click(object sender, EventArgs e)
        {
            //dtprodutos.Rows.Add
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Adicione um valor");
            }

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbocomprar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            codigostatus = Convert.ToInt32(cbocomprar.SelectedValue.ToString());
        }

        private void cbomotivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
