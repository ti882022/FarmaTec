
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
            this.lblFornecedor.Location = new System.Drawing.Point(90, 206);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(112, 25);
            this.lblFornecedor.TabIndex = 125;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // txtfornecedor
            // 
            this.txtfornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfornecedor.Location = new System.Drawing.Point(229, 201);
            this.txtfornecedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtfornecedor.MaxLength = 100;
            this.txtfornecedor.Name = "txtfornecedor";
            this.txtfornecedor.Size = new System.Drawing.Size(747, 30);
            this.txtfornecedor.TabIndex = 4;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(90, 242);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(97, 25);
            this.lblCategoria.TabIndex = 121;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(90, 166);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(67, 25);
            this.lblMarca.TabIndex = 120;
            this.lblMarca.Text = "Marca";
            // 
            // txtmarca
            // 
            this.txtmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmarca.Location = new System.Drawing.Point(229, 162);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmarca.MaxLength = 100;
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(747, 30);
            this.txtmarca.TabIndex = 3;
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.Location = new System.Drawing.Point(681, 242);
            this.lblUnidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(85, 25);
            this.lblUnidade.TabIndex = 118;
            this.lblUnidade.Text = "Unidade";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(652, 436);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 34);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(500, 436);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 34);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(337, 436);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 34);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblTituloProdutos
            // 
            this.lblTituloProdutos.AutoSize = true;
            this.lblTituloProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProdutos.Location = new System.Drawing.Point(284, 9);
            this.lblTituloProdutos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloProdutos.Name = "lblTituloProdutos";
            this.lblTituloProdutos.Size = new System.Drawing.Size(429, 46);
            this.lblTituloProdutos.TabIndex = 117;
            this.lblTituloProdutos.Text = "Cadastro de Produtos";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(90, 127);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(99, 25);
            this.lblDescricao.TabIndex = 115;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(229, 124);
            this.txtdescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdescricao.MaxLength = 100;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(747, 30);
            this.txtdescricao.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(229, 87);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(88, 30);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtcodProduto
            // 
            this.txtcodProduto.AutoSize = true;
            this.txtcodProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtcodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodProduto.Location = new System.Drawing.Point(90, 90);
            this.txtcodProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtcodProduto.Name = "txtcodProduto";
            this.txtcodProduto.Size = new System.Drawing.Size(122, 25);
            this.txtcodProduto.TabIndex = 113;
            this.txtcodProduto.Text = "Cod Produto";
            // 
            // txtUnidade
            // 
            this.txtUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidade.Location = new System.Drawing.Point(774, 239);
            this.txtUnidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUnidade.MaxLength = 2;
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(201, 30);
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
            this.lblestoque.Location = new System.Drawing.Point(90, 284);
            this.lblestoque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblestoque.Name = "lblestoque";
            this.lblestoque.Size = new System.Drawing.Size(120, 25);
            this.lblestoque.TabIndex = 133;
            this.lblestoque.Text = "Estoque min";
            // 
            // txtEstoqueMin
            // 
            this.txtEstoqueMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueMin.Location = new System.Drawing.Point(229, 281);
            this.txtEstoqueMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEstoqueMin.MaxLength = 100;
            this.txtEstoqueMin.Name = "txtEstoqueMin";
            this.txtEstoqueMin.Size = new System.Drawing.Size(236, 30);
            this.txtEstoqueMin.TabIndex = 7;
            // 
            // cboCategoria
            // 
            this.cboCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(229, 238);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(391, 33);
            this.cboCategoria.TabIndex = 5;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(495, 286);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(63, 25);
            this.lblPreco.TabIndex = 135;
            this.lblPreco.Text = "Preço";
            // 
            // txtpreco
            // 
            this.txtpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreco.Location = new System.Drawing.Point(566, 284);
            this.txtpreco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpreco.MaxLength = 100;
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(236, 30);
            this.txtpreco.TabIndex = 8;
            // 
            // frmCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCadastroProdutos";
            this.Text = "frmCadastroProdutos";
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