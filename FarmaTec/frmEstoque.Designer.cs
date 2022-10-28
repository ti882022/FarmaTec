
namespace FarmaTec
{
    partial class cboEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cboEstoque));
            this.btnsaida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbocomprar = new System.Windows.Forms.ComboBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.Codigodoproduto = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.Quantidadedoproduto = new System.Windows.Forms.Label();
            this.Produtos = new System.Windows.Forms.Label();
            this.dtprodutos = new System.Windows.Forms.DataGridView();
            this.codProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtprodutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsaida
            // 
            this.btnsaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnsaida.Location = new System.Drawing.Point(664, 310);
            this.btnsaida.Name = "btnsaida";
            this.btnsaida.Size = new System.Drawing.Size(80, 28);
            this.btnsaida.TabIndex = 6;
            this.btnsaida.Text = "Sair";
            this.btnsaida.UseVisualStyleBackColor = true;
            this.btnsaida.Click += new System.EventHandler(this.saida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(660, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Status";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(469, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 22);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // cbocomprar
            // 
            this.cbocomprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocomprar.FormattingEnabled = true;
            this.cbocomprar.ItemHeight = 20;
            this.cbocomprar.Location = new System.Drawing.Point(638, 190);
            this.cbocomprar.Name = "cbocomprar";
            this.cbocomprar.Size = new System.Drawing.Size(106, 28);
            this.cbocomprar.TabIndex = 4;
            this.cbocomprar.SelectionChangeCommitted += new System.EventHandler(this.cbocomprar_SelectionChangeCommitted);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(133, 72);
            this.txtcodigo.Multiline = true;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(70, 26);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // Codigodoproduto
            // 
            this.Codigodoproduto.AutoSize = true;
            this.Codigodoproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigodoproduto.Location = new System.Drawing.Point(129, 31);
            this.Codigodoproduto.Name = "Codigodoproduto";
            this.Codigodoproduto.Size = new System.Drawing.Size(185, 24);
            this.Codigodoproduto.TabIndex = 21;
            this.Codigodoproduto.Text = "Codigo do produto";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPesquisa.Location = new System.Drawing.Point(222, 70);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(85, 28);
            this.btnPesquisa.TabIndex = 2;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAtualizar.Location = new System.Drawing.Point(508, 310);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(91, 28);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::FarmaTec.Properties.Resources.FarmaTec_removebg_preview2_removebg_preview;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(508, 192);
            this.txtQuantidade.Multiline = true;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(88, 26);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // Quantidadedoproduto
            // 
            this.Quantidadedoproduto.AutoSize = true;
            this.Quantidadedoproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Quantidadedoproduto.Location = new System.Drawing.Point(504, 166);
            this.Quantidadedoproduto.Name = "Quantidadedoproduto";
            this.Quantidadedoproduto.Size = new System.Drawing.Size(92, 20);
            this.Quantidadedoproduto.TabIndex = 23;
            this.Quantidadedoproduto.Text = "Quantidade";
            // 
            // Produtos
            // 
            this.Produtos.AutoSize = true;
            this.Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produtos.Location = new System.Drawing.Point(37, 124);
            this.Produtos.Name = "Produtos";
            this.Produtos.Size = new System.Drawing.Size(118, 29);
            this.Produtos.TabIndex = 18;
            this.Produtos.Text = "Produtos";
            // 
            // dtprodutos
            // 
            this.dtprodutos.AllowUserToAddRows = false;
            this.dtprodutos.AllowUserToDeleteRows = false;
            this.dtprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtprodutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProduto,
            this.descricao});
            this.dtprodutos.Location = new System.Drawing.Point(12, 156);
            this.dtprodutos.Name = "dtprodutos";
            this.dtprodutos.ReadOnly = true;
            this.dtprodutos.Size = new System.Drawing.Size(443, 196);
            this.dtprodutos.TabIndex = 17;
            this.dtprodutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // codProduto
            // 
            this.codProduto.HeaderText = "Codigo";
            this.codProduto.Name = "codProduto";
            this.codProduto.ReadOnly = true;
            this.codProduto.ToolTipText = "Entrada";
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 300;
            // 
            // cboEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(762, 369);
            this.Controls.Add(this.btnsaida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbocomprar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.Quantidadedoproduto);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.Codigodoproduto);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.Produtos);
            this.Controls.Add(this.dtprodutos);
            this.Name = "cboEstoque";
            this.Text = "Estoque - FarmaTec - Usuário: ";
            this.Load += new System.EventHandler(this.cboEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtprodutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbocomprar;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label Codigodoproduto;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label Quantidadedoproduto;
        private System.Windows.Forms.Label Produtos;
        private System.Windows.Forms.DataGridView dtprodutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProduto;
        private System.Windows.Forms.DataGridViewLinkColumn descricao;
    }
}