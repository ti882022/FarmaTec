
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
            this.saida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbocomprar = new System.Windows.Forms.ComboBox();
            this.cboQuantidade = new System.Windows.Forms.TextBox();
            this.Quantidadedoproduto = new System.Windows.Forms.Label();
            this.cbocodigoproduto = new System.Windows.Forms.TextBox();
            this.Codigodoproduto = new System.Windows.Forms.Label();
            this.Pesquisa = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            this.Produtos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbomotivo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // saida
            // 
            this.saida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saida.Location = new System.Drawing.Point(647, 308);
            this.saida.Name = "saida";
            this.saida.Size = new System.Drawing.Size(91, 41);
            this.saida.TabIndex = 31;
            this.saida.Text = "Saida";
            this.saida.UseVisualStyleBackColor = true;
            this.saida.Click += new System.EventHandler(this.saida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(284, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Status";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(505, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // cbocomprar
            // 
            this.cbocomprar.FormattingEnabled = true;
            this.cbocomprar.Items.AddRange(new object[] {
            "entrada ",
            "saida"});
            this.cbocomprar.Location = new System.Drawing.Point(263, 328);
            this.cbocomprar.Name = "cbocomprar";
            this.cbocomprar.Size = new System.Drawing.Size(117, 21);
            this.cbocomprar.TabIndex = 25;
            this.cbocomprar.SelectedIndexChanged += new System.EventHandler(this.cbocomprar_SelectedIndexChanged);
            // 
            // cboQuantidade
            // 
            this.cboQuantidade.Location = new System.Drawing.Point(72, 305);
            this.cboQuantidade.Multiline = true;
            this.cboQuantidade.Name = "cboQuantidade";
            this.cboQuantidade.Size = new System.Drawing.Size(99, 39);
            this.cboQuantidade.TabIndex = 24;
            // 
            // Quantidadedoproduto
            // 
            this.Quantidadedoproduto.AutoSize = true;
            this.Quantidadedoproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Quantidadedoproduto.Location = new System.Drawing.Point(68, 285);
            this.Quantidadedoproduto.Name = "Quantidadedoproduto";
            this.Quantidadedoproduto.Size = new System.Drawing.Size(92, 20);
            this.Quantidadedoproduto.TabIndex = 23;
            this.Quantidadedoproduto.Text = "Quantidade";
            // 
            // cbocodigoproduto
            // 
            this.cbocodigoproduto.Location = new System.Drawing.Point(133, 66);
            this.cbocodigoproduto.Multiline = true;
            this.cbocodigoproduto.Name = "cbocodigoproduto";
            this.cbocodigoproduto.Size = new System.Drawing.Size(87, 39);
            this.cbocodigoproduto.TabIndex = 22;
            this.cbocodigoproduto.TextChanged += new System.EventHandler(this.codigoproduto_TextChanged);
            // 
            // Codigodoproduto
            // 
            this.Codigodoproduto.AutoSize = true;
            this.Codigodoproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Codigodoproduto.Location = new System.Drawing.Point(129, 31);
            this.Codigodoproduto.Name = "Codigodoproduto";
            this.Codigodoproduto.Size = new System.Drawing.Size(140, 20);
            this.Codigodoproduto.TabIndex = 21;
            this.Codigodoproduto.Text = "Codigo do produto";
            // 
            // Pesquisa
            // 
            this.Pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Pesquisa.Location = new System.Drawing.Point(236, 65);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(91, 40);
            this.Pesquisa.TabIndex = 20;
            this.Pesquisa.Text = "Pesquisar";
            this.Pesquisa.UseVisualStyleBackColor = true;
            this.Pesquisa.Click += new System.EventHandler(this.Pesquisa_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Atualizar.Location = new System.Drawing.Point(529, 308);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(91, 41);
            this.Atualizar.TabIndex = 19;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // Produtos
            // 
            this.Produtos.AutoSize = true;
            this.Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Produtos.Location = new System.Drawing.Point(37, 149);
            this.Produtos.Name = "Produtos";
            this.Produtos.Size = new System.Drawing.Size(110, 29);
            this.Produtos.TabIndex = 18;
            this.Produtos.Text = "Produtos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Quantidade,
            this.Descrição,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(42, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(672, 45);
            this.dataGridView1.TabIndex = 17;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo ";
            this.Codigo.Name = "Codigo";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 70;
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.Width = 300;
            // 
            // Status
            // 
            this.Status.FillWeight = 150F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 158;
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
            // menos
            // 
            this.menos.Image = global::FarmaTec.Properties.Resources.Botão_em_png_queroiamgem_Ceiça_Crispim;
            this.menos.Location = new System.Drawing.Point(42, 318);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(24, 23);
            this.menos.TabIndex = 27;
            this.menos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::FarmaTec.Properties.Resources.botao_mais;
            this.button1.Location = new System.Drawing.Point(177, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbomotivo
            // 
            this.cbomotivo.FormattingEnabled = true;
            this.cbomotivo.Items.AddRange(new object[] {
            "Quebra",
            "vencimento "});
            this.cbomotivo.Location = new System.Drawing.Point(395, 305);
            this.cbomotivo.Name = "cbomotivo";
            this.cbomotivo.Size = new System.Drawing.Size(121, 21);
            this.cbomotivo.TabIndex = 32;
            this.cbomotivo.Visible = false;
            // 
            // cboEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(747, 366);
            this.Controls.Add(this.cbomotivo);
            this.Controls.Add(this.saida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbocomprar);
            this.Controls.Add(this.cboQuantidade);
            this.Controls.Add(this.Quantidadedoproduto);
            this.Controls.Add(this.cbocodigoproduto);
            this.Controls.Add(this.Codigodoproduto);
            this.Controls.Add(this.Pesquisa);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.Produtos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "cboEstoque";
            this.Text = "frmEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button menos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbocomprar;
        private System.Windows.Forms.TextBox cboQuantidade;
        private System.Windows.Forms.Label Quantidadedoproduto;
        private System.Windows.Forms.TextBox cbocodigoproduto;
        private System.Windows.Forms.Label Codigodoproduto;
        private System.Windows.Forms.Button Pesquisa;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Label Produtos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewLinkColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ComboBox cbomotivo;
    }
}