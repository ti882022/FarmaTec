using System;
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
    public partial class frmCadastroProdutos : Form
    {
        TratamentoCampos tratamentoCampos = new TratamentoCampos();
        public frmCadastroProdutos()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }


        public int codigoCategoria;

        private void ListarCategoria()
        {
            try
            {
                ConsultarCategoria consultarcategoria = new ConsultarCategoria();
                CategoriasDTO dados = new CategoriasDTO();

                consultarcategoria.ListarCombo(dados);

                //Limpar fonte de dados e limpar combo
                cboCategoria.DataSource = null;
                cboCategoria.Items.Clear();

                //Popular o listbox
                //Definir o código do cargo, porém irá apresentar somente o nome do cargo
                cboCategoria.ValueMember = "catProduto";
                cboCategoria.DisplayMember = "categoria";
                cboCategoria.DataSource = consultarcategoria.CategoriasDataTable;
                //Trazer os dados para serem selecionados
                cboCategoria.SelectedIndex = -1;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }



        private void frmCadastroProdutos_Load(object sender, EventArgs e)
        {
            //Iniciar método para consultar as categorias
            this.Text = "Cadastro de Produto - FarmaTec - Usuário: " + LoginSistema.nomeUsuario;
            ListarCategoria();
        }

        private void InserirImagem_FileOk(object sender, CancelEventArgs e)
        {

        }

        /* private void btnInserirImagem_Click(object sender, EventArgs e)
         {
             //define as propriedades do controle 
             //OpenFileDialog
             this.InserirImagem.Multiselect = true;
             this.InserirImagem.Title = "Selecionar Imagem do Produto";
             InserirImagem.InitialDirectory = @"C:\";
             //filtra para exibir somente arquivos de imagens
             InserirImagem.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
             InserirImagem.CheckFileExists = true;
             InserirImagem.CheckPathExists = true;
             InserirImagem.FilterIndex = 2;
             InserirImagem.RestoreDirectory = true;
             InserirImagem.ReadOnlyChecked = true;
             InserirImagem.ShowReadOnly = true;

             DialogResult dr = this.InserirImagem.ShowDialog();

             if (dr == System.Windows.Forms.DialogResult.OK)
             {
                 // Le os arquivos selecionados 
                 foreach (String arquivo in InserirImagem.FileNames)
                 {
                     flowLayoutPanel1.Text += arquivo;
                     // cria um PictureBox
                     try
                     {

                         PictureBox pb = new PictureBox();
                         Image Imagem = Image.FromFile(arquivo);
                         pb.SizeMode = PictureBoxSizeMode.StretchImage;
                         //para exibir as imagens em tamanho natural 
                         //descomente as linhas abaixo e comente as duas seguintes
                         //pb.Height = loadedImage.Height;
                         //pb.Width = loadedImage.Width;
                         pb.Height = 100;
                         pb.Width = 100;
                         //atribui a imagem ao PictureBox - pb
                         pb.Image = Imagem;
                         //inclui a imagem no containter flowLayoutPanel
                         flowLayoutPanel1.Controls.Add(pb);
                     }
                     catch (SecurityException ex)
                     {
                         // O usuário  não possui permissão para ler arquivos
                         MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                     "Mensagem : " + ex.Message + "\n\n" +
                                                     "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                     }
                     catch (Exception ex)
                     {
                         // Não pode carregar a imagem (problemas de permissão)
                         MessageBox.Show("Não é possível exibir a imagem : "
                                                    + ". Você pode não ter permissão para ler o arquivo , ou " +
                                                    " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                     }
                 }
             }
         }*/

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
            SalvarProduto salvarProduto = new SalvarProduto();
            ProdutosDTO dados = new ProdutosDTO();

            if (tratamentoCampos.Vazio(this) == true)
            {
                tratamentoCampos.Bloquear(this);
                if (MessageBox.Show("Deseja Finalizar o Cadastro do Produto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    //Popular a classe
                    dados.descricao = txtdescricao.Text;
                    dados.marca = txtmarca.Text;
                    dados.fornecedor = txtfornecedor.Text;
                    dados.catProduto = Convert.ToInt32(codigoCategoria);
                    dados.unidade = txtUnidade.Text;
                    dados.estoqueMinimo = Convert.ToInt32(txtEstoqueMin.Text);
                    dados.preco = Convert.ToInt32(txtpreco.Text);
                    //dados.imgproduto = string.Empty;



                    //Chamar o método para incluir dados

                    await salvarProduto.ProdutosIncluir(dados);

                    if (dados.mensagens == null)
                    {

                        if (dados.codigo == 0)
                        {
                            MessageBox.Show("Não foi possível realizar o cadastro " + dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else
                        {
                            txtCodigo.Text = dados.codigo.ToString();
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tratamentoCampos.Limpar(this);
            txtdescricao.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            switch (keyData)
            {
                case Keys.Enter:
                    btnSalvar.PerformClick();
                    return true;

                case Keys.Escape:
                    btnSair.PerformClick();
                    return true;

                case Keys.F12:
                    btnLimpar.PerformClick();
                    return true;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoCategoria = Convert.ToInt32(cboCategoria.SelectedValue);
        }

    }
}

