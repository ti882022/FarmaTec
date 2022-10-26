
namespace FarmaTec
{
    partial class frmConsultarProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarProdutos));
            this.lblProdutosRegistrados = new System.Windows.Forms.Label();
            this.dtProdutos = new System.Windows.Forms.DataGridView();
            this.codProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlConsulta = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodproduto = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.pctProdutos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtProdutos)).BeginInit();
            this.pnlConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdutosRegistrados
            // 
            this.lblProdutosRegistrados.AutoSize = true;
            this.lblProdutosRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutosRegistrados.Location = new System.Drawing.Point(221, 242);
            this.lblProdutosRegistrados.Name = "lblProdutosRegistrados";
            this.lblProdutosRegistrados.Size = new System.Drawing.Size(219, 25);
            this.lblProdutosRegistrados.TabIndex = 26;
            this.lblProdutosRegistrados.Text = "Produtos Registrados";
            // 
            // dtProdutos
            // 
            this.dtProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProduto,
            this.descricao,
            this.marca,
            this.fornecedor,
            this.categoria,
            this.qtde,
            this.preco});
            this.dtProdutos.Location = new System.Drawing.Point(142, 274);
            this.dtProdutos.Name = "dtProdutos";
            this.dtProdutos.ReadOnly = true;
            this.dtProdutos.Size = new System.Drawing.Size(1183, 388);
            this.dtProdutos.TabIndex = 24;
            this.dtProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtProdutos_CellContentClick);
            // 
            // codProduto
            // 
            this.codProduto.HeaderText = "Código";
            this.codProduto.MaxInputLength = 1000;
            this.codProduto.Name = "codProduto";
            this.codProduto.ReadOnly = true;
            this.codProduto.Width = 80;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.MaxInputLength = 50;
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 200;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.MaxInputLength = 50;
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Width = 200;
            // 
            // fornecedor
            // 
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.MaxInputLength = 8;
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            this.fornecedor.Width = 200;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.MaxInputLength = 50;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 130;
            // 
            // qtde
            // 
            this.qtde.HeaderText = "Quantidade Estoque";
            this.qtde.MaxInputLength = 50;
            this.qtde.Name = "qtde";
            this.qtde.ReadOnly = true;
            this.qtde.Width = 200;
            // 
            // preco
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.preco.DefaultCellStyle = dataGridViewCellStyle1;
            this.preco.HeaderText = "Valor Unitário";
            this.preco.MaxInputLength = 13;
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            this.preco.Width = 130;
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlConsulta.Controls.Add(this.lblBuscar);
            this.pnlConsulta.Controls.Add(this.btnBuscar);
            this.pnlConsulta.Controls.Add(this.lblNomeProduto);
            this.pnlConsulta.Controls.Add(this.lblcodigo);
            this.pnlConsulta.Controls.Add(this.txtcodproduto);
            this.pnlConsulta.Controls.Add(this.txtdescricao);
            this.pnlConsulta.Location = new System.Drawing.Point(77, 66);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(974, 121);
            this.pnlConsulta.TabIndex = 23;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(6, 8);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(90, 20);
            this.lblBuscar.TabIndex = 13;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(825, 73);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(132, 40);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(119, 42);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(133, 20);
            this.lblNomeProduto.TabIndex = 11;
            this.lblNomeProduto.Text = "Nome do Produto";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(18, 42);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(59, 20);
            this.lblcodigo.TabIndex = 8;
            this.lblcodigo.Text = "Código";
            // 
            // txtcodproduto
            // 
            this.txtcodproduto.AllowDrop = true;
            this.txtcodproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodproduto.Location = new System.Drawing.Point(12, 65);
            this.txtcodproduto.Name = "txtcodproduto";
            this.txtcodproduto.Size = new System.Drawing.Size(80, 29);
            this.txtcodproduto.TabIndex = 1;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtdescricao.Location = new System.Drawing.Point(118, 65);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(226, 29);
            this.txtdescricao.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSair.FlatAppearance.BorderSize = 20;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(1107, 66);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 107);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pctProdutos
            // 
            this.pctProdutos.Image = ((System.Drawing.Image)(resources.GetObject("pctProdutos.Image")));
            this.pctProdutos.Location = new System.Drawing.Point(142, 212);
            this.pctProdutos.Name = "pctProdutos";
            this.pctProdutos.Size = new System.Drawing.Size(76, 69);
            this.pctProdutos.TabIndex = 27;
            this.pctProdutos.TabStop = false;
            this.pctProdutos.Click += new System.EventHandler(this.pctProdutos_Click);
            // 
            // frmConsultarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1352, 729);
            this.Controls.Add(this.lblProdutosRegistrados);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dtProdutos);
            this.Controls.Add(this.pnlConsulta);
            this.Controls.Add(this.pctProdutos);
            this.Name = "frmConsultarProdutos";
            this.Text = "Consultar Produtos - FarmaTec";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConsultarProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtProdutos)).EndInit();
            this.pnlConsulta.ResumeLayout(false);
            this.pnlConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdutosRegistrados;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dtProdutos;
        private System.Windows.Forms.Panel pnlConsulta;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcodproduto;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.PictureBox pctProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
    }
}