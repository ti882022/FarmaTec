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
        public frmCadastroProdutos()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
        }

        private void frmCadastroProdutos_Load(object sender, EventArgs e)
        {

        }

        private void InserirImagem_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnInserirImagem_Click(object sender, EventArgs e)
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
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do cadastrO?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instanciar as classes
            SalvarProduto salvarProduto = new SalvarProduto();
            ProdutosDTO dados = new ProdutosDTO();


            //Popular a classe
            dados.descricao = txtdescricao.Text;
            dados.marca = txtmarca.Text;
            dados.fornecedor = txtfornecedor.Text;
            dados.catProduto = Convert.ToInt32(txtcategoria.Text);
            dados.unidade = txtUnidade.Text;
            dados.estoqueMinimo = Convert.ToInt32(txtEstoqueMin.Text);
            dados.imgproduto = string.Empty;
            dados.preco = txtpreco.Text;


            //Chamar o método para incluir dados

            await salvarProduto.ProdutosIncluir(dados);

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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
