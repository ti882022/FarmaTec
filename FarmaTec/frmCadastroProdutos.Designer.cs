
namespace FarmaTec
{
    partial class frmCadastroProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtfornecedor = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblTituloProdutos = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtcodProduto = new System.Windows.Forms.Label();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.InserirImagem = new System.Windows.Forms.OpenFileDialog();
            this.lblestoque = new System.Windows.Forms.Label();
            this.txtEstoqueMin = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(66, 223);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(91, 20);
            this.lblFornecedor.TabIndex = 125;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // txtfornecedor
            // 
            this.txtfornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfornecedor.Location = new System.Drawing.Point(170, 219);
            this.txtfornecedor.MaxLength = 100;
            this.txtfornecedor.Name = "txtfornecedor";
            this.txtfornecedor.Size = new System.Drawing.Size(561, 26);
            this.txtfornecedor.TabIndex = 4;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(66, 253);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(78, 20);
            this.lblCategoria.TabIndex = 121;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(66, 191);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 20);
            this.lblMarca.TabIndex = 120;
            this.lblMarca.Text = "Marca";
            // 
            // txtmarca
            // 
            this.txtmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmarca.Location = new System.Drawing.Point(170, 188);
            this.txtmarca.MaxLength = 100;
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(561, 26);
            this.txtmarca.TabIndex = 3;
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.Location = new System.Drawing.Point(509, 253);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(69, 20);
            this.lblUnidade.TabIndex = 118;
            this.lblUnidade.Text = "Unidade";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(474, 385);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 28);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(360, 385);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 28);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(238, 385);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 28);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblTituloProdutos
            // 
            this.lblTituloProdutos.AutoSize = true;
            this.lblTituloProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProdutos.Location = new System.Drawing.Point(218, 32);
            this.lblTituloProdutos.Name = "lblTituloProdutos";
            this.lblTituloProdutos.Size = new System.Drawing.Size(350, 37);
            this.lblTituloProdutos.TabIndex = 117;
            this.lblTituloProdutos.Text = "Cadastro de Produtos";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(66, 159);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 115;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(170, 157);
            this.txtdescricao.MaxLength = 100;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(561, 26);
            this.txtdescricao.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(170, 127);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(67, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtcodProduto
            // 
            this.txtcodProduto.AutoSize = true;
            this.txtcodProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtcodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodProduto.Location = new System.Drawing.Point(66, 129);
            this.txtcodProduto.Name = "txtcodProduto";
            this.txtcodProduto.Size = new System.Drawing.Size(98, 20);
            this.txtcodProduto.TabIndex = 113;
            this.txtcodProduto.Text = "Cod Produto";
            // 
            // txtUnidade
            // 
            this.txtUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidade.Location = new System.Drawing.Point(578, 250);
            this.txtUnidade.MaxLength = 2;
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(152, 26);
            this.txtUnidade.TabIndex = 6;
            // 
            // InserirImagem
            // 
            this.InserirImagem.DefaultExt = "jpg";
            this.InserirImagem.FileName = "inserirImagem";
            this.InserirImagem.InitialDirectory = "C:\\";
            this.InserirImagem.Title = "Localizar Imagem";
            this.InserirImagem.FileOk += new System.ComponentModel.CancelEventHandler(this.InserirImagem_FileOk);
            // 
            // lblestoque
            // 
            this.lblestoque.AutoSize = true;
            this.lblestoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestoque.Location = new System.Drawing.Point(66, 287);
            this.lblestoque.Name = "lblestoque";
            this.lblestoque.Size = new System.Drawing.Size(98, 20);
            this.lblestoque.TabIndex = 133;
            this.lblestoque.Text = "Estoque min";
            // 
            // txtEstoqueMin
            // 
            this.txtEstoqueMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueMin.Location = new System.Drawing.Point(170, 284);
            this.txtEstoqueMin.MaxLength = 100;
            this.txtEstoqueMin.Name = "txtEstoqueMin";
            this.txtEstoqueMin.Size = new System.Drawing.Size(178, 26);
            this.txtEstoqueMin.TabIndex = 7;
            this.txtEstoqueMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoqueMin_KeyPress);
            // 
            // cboCategoria
            // 
            this.cboCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(170, 249);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(294, 28);
            this.cboCategoria.TabIndex = 5;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(369, 288);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(50, 20);
            this.lblPreco.TabIndex = 135;
            this.lblPreco.Text = "Preço";
            // 
            // txtpreco
            // 
            this.txtpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreco.Location = new System.Drawing.Point(422, 287);
            this.txtpreco.MaxLength = 100;
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(178, 26);
            this.txtpreco.TabIndex = 8;
            this.txtpreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreco_KeyPress);
            // 
            // frmCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.lblestoque);
            this.Controls.Add(this.txtEstoqueMin);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txtfornecedor);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblTituloProdutos);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtcodProduto);
            this.Name = "frmCadastroProdutos";
            this.Text = "Cadastro de Produto - FarmaTec - Usuário: ";
            this.Load += new System.EventHandler(this.frmCadastroProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtfornecedor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblTituloProdutos;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label txtcodProduto;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.OpenFileDialog InserirImagem;
        private System.Windows.Forms.Label lblestoque;
        private System.Windows.Forms.TextBox txtEstoqueMin;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtpreco;
    }
}