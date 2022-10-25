
namespace FarmaTec
{
    partial class frmCaixa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.txtnomecliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.grpProduto = new System.Windows.Forms.GroupBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.dtPedido = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.nrPedido = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.grpPagamento = new System.Windows.Forms.GroupBox();
            this.cboFormaPagamento = new System.Windows.Forms.ComboBox();
            this.btnReceber = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtVenda = new System.Windows.Forms.DataGridView();
            this.codProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.grpCliente.SuspendLayout();
            this.grpProduto.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.grpPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnomecliente
            // 
            this.txtnomecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomecliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtnomecliente.Location = new System.Drawing.Point(119, 65);
            this.txtnomecliente.Name = "txtnomecliente";
            this.txtnomecliente.Size = new System.Drawing.Size(500, 29);
            this.txtnomecliente.TabIndex = 0;
            this.txtnomecliente.TextChanged += new System.EventHandler(this.txtNomeCliente_TextChanged);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(115, 42);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(130, 20);
            this.lblNomeCliente.TabIndex = 4;
            this.lblNomeCliente.Text = "Nome do Cliente:";
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.label3);
            this.grpCliente.Controls.Add(this.lblNomeCliente);
            this.grpCliente.Controls.Add(this.txtNomeFuncionario);
            this.grpCliente.Controls.Add(this.txtnomecliente);
            this.grpCliente.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCliente.Location = new System.Drawing.Point(29, 64);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(647, 203);
            this.grpCliente.TabIndex = 7;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Cliente/Funcionário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome do Funcionário";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Enabled = false;
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeFuncionario.Location = new System.Drawing.Point(119, 131);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(500, 29);
            this.txtNomeFuncionario.TabIndex = 2;
            this.txtNomeFuncionario.TextChanged += new System.EventHandler(this.txtNomeFuncionario_TextChanged);
            // 
            // grpProduto
            // 
            this.grpProduto.BackColor = System.Drawing.Color.Transparent;
            this.grpProduto.Controls.Add(this.btnIncluir);
            this.grpProduto.Controls.Add(this.dtPedido);
            this.grpProduto.Controls.Add(this.label1);
            this.grpProduto.Controls.Add(this.label6);
            this.grpProduto.Controls.Add(this.label4);
            this.grpProduto.Controls.Add(this.txtdescricao);
            this.grpProduto.Controls.Add(this.txtCodProduto);
            this.grpProduto.Controls.Add(this.txtPedido);
            this.grpProduto.Controls.Add(this.nrPedido);
            this.grpProduto.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProduto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpProduto.Location = new System.Drawing.Point(703, 64);
            this.grpProduto.Name = "grpProduto";
            this.grpProduto.Size = new System.Drawing.Size(647, 203);
            this.grpProduto.TabIndex = 8;
            this.grpProduto.TabStop = false;
            this.grpProduto.Text = "Produto";
            this.grpProduto.Paint += new System.Windows.Forms.PaintEventHandler(this.grpProduto_Paint);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(534, 131);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(98, 37);
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click_1);
            // 
            // dtPedido
            // 
            this.dtPedido.Enabled = false;
            this.dtPedido.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPedido.Location = new System.Drawing.Point(132, 140);
            this.dtPedido.Name = "dtPedido";
            this.dtPedido.Size = new System.Drawing.Size(313, 28);
            this.dtPedido.TabIndex = 14;
            this.dtPedido.ValueChanged += new System.EventHandler(this.dtPedido_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Data do pedido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Código:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nome do Produto";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtdescricao.Location = new System.Drawing.Point(132, 65);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(500, 29);
            this.txtdescricao.TabIndex = 1;
            this.txtdescricao.TextChanged += new System.EventHandler(this.txtNomeProduto_TextChanged);
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.AllowDrop = true;
            this.txtCodProduto.Enabled = false;
            this.txtCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProduto.Location = new System.Drawing.Point(19, 65);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(76, 29);
            this.txtCodProduto.TabIndex = 7;
            // 
            // txtPedido
            // 
            this.txtPedido.AllowDrop = true;
            this.txtPedido.Enabled = false;
            this.txtPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedido.Location = new System.Drawing.Point(19, 139);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(76, 29);
            this.txtPedido.TabIndex = 6;
            // 
            // nrPedido
            // 
            this.nrPedido.AutoSize = true;
            this.nrPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrPedido.Location = new System.Drawing.Point(19, 112);
            this.nrPedido.Name = "nrPedido";
            this.nrPedido.Size = new System.Drawing.Size(58, 20);
            this.nrPedido.TabIndex = 10;
            this.nrPedido.Text = "Pedido";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConsulta,
            this.menuCadastro});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1384, 24);
            this.menuStrip.TabIndex = 16;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuConsulta
            // 
            this.menuConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConsultaProdutos,
            this.menuConsultaClientes});
            this.menuConsulta.Name = "menuConsulta";
            this.menuConsulta.Size = new System.Drawing.Size(66, 20);
            this.menuConsulta.Text = "Consulta";
            // 
            // menuConsultaProdutos
            // 
            this.menuConsultaProdutos.Name = "menuConsultaProdutos";
            this.menuConsultaProdutos.Size = new System.Drawing.Size(122, 22);
            this.menuConsultaProdutos.Text = "Produtos";
            // 
            // menuConsultaClientes
            // 
            this.menuConsultaClientes.Name = "menuConsultaClientes";
            this.menuConsultaClientes.Size = new System.Drawing.Size(122, 22);
            this.menuConsultaClientes.Text = "Clientes";
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroClientes});
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(66, 20);
            this.menuCadastro.Text = "Cadastro";
            // 
            // menuCadastroClientes
            // 
            this.menuCadastroClientes.Name = "menuCadastroClientes";
            this.menuCadastroClientes.Size = new System.Drawing.Size(116, 22);
            this.menuCadastroClientes.Text = "Clientes";
            // 
            // grpPagamento
            // 
            this.grpPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpPagamento.Controls.Add(this.cboFormaPagamento);
            this.grpPagamento.Controls.Add(this.btnReceber);
            this.grpPagamento.Controls.Add(this.txtValorTotal);
            this.grpPagamento.Controls.Add(this.lblTotal);
            this.grpPagamento.Controls.Add(this.lblFormaPagamento);
            this.grpPagamento.Controls.Add(this.txtDesconto);
            this.grpPagamento.Controls.Add(this.lblDesconto);
            this.grpPagamento.Controls.Add(this.txtValor);
            this.grpPagamento.Controls.Add(this.lblPagamento);
            this.grpPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPagamento.Location = new System.Drawing.Point(515, 303);
            this.grpPagamento.Name = "grpPagamento";
            this.grpPagamento.Size = new System.Drawing.Size(434, 401);
            this.grpPagamento.TabIndex = 17;
            this.grpPagamento.TabStop = false;
            this.grpPagamento.Text = "PAGAMENTO";
            // 
            // cboFormaPagamento
            // 
            this.cboFormaPagamento.FormattingEnabled = true;
            this.cboFormaPagamento.Location = new System.Drawing.Point(62, 217);
            this.cboFormaPagamento.Name = "cboFormaPagamento";
            this.cboFormaPagamento.Size = new System.Drawing.Size(260, 33);
            this.cboFormaPagamento.TabIndex = 9;
            this.cboFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.cbFormaPagamento_SelectedIndexChanged);
            // 
            // btnReceber
            // 
            this.btnReceber.Location = new System.Drawing.Point(322, 350);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(106, 45);
            this.btnReceber.TabIndex = 8;
            this.btnReceber.Text = "Receber";
            this.btnReceber.UseVisualStyleBackColor = true;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(221, 292);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(113, 31);
            this.txtValorTotal.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(56, 292);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 31);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPagamento.Location = new System.Drawing.Point(56, 185);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(274, 31);
            this.lblFormaPagamento.TabIndex = 4;
            this.lblFormaPagamento.Text = "Forma de Pagamento";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(221, 116);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(113, 31);
            this.txtDesconto.TabIndex = 3;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.Location = new System.Drawing.Point(60, 116);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(130, 31);
            this.lblDesconto.TabIndex = 2;
            this.lblDesconto.Text = "Desconto";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(221, 54);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(113, 31);
            this.txtValor.TabIndex = 1;
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamento.Location = new System.Drawing.Point(56, 54);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(77, 31);
            this.lblPagamento.TabIndex = 0;
            this.lblPagamento.Text = "Valor";
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.btnFinalizarCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizarCompra.Image")));
            this.btnFinalizarCompra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(1265, 303);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(107, 107);
            this.btnFinalizarCompra.TabIndex = 15;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinalizarCompra.UseVisualStyleBackColor = false;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSair.FlatAppearance.BorderSize = 20;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(1265, 416);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 107);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 20;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(1265, 529);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 104);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // dtVenda
            // 
            this.dtVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProduto,
            this.descricao,
            this.qtde,
            this.preco});
            this.dtVenda.Location = new System.Drawing.Point(318, 280);
            this.dtVenda.Name = "dtVenda";
            this.dtVenda.Size = new System.Drawing.Size(842, 349);
            this.dtVenda.TabIndex = 9;
            this.dtVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codProduto
            // 
            this.codProduto.HeaderText = "Código";
            this.codProduto.Name = "codProduto";
            this.codProduto.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Produto";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 300;
            // 
            // qtde
            // 
            this.qtde.HeaderText = "Quantidade";
            this.qtde.Name = "qtde";
            this.qtde.ReadOnly = true;
            this.qtde.Width = 200;
            // 
            // preco
            // 
            this.preco.HeaderText = "Valor Unitário";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            this.preco.Width = 200;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1384, 700);
            this.Controls.Add(this.grpPagamento);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpProduto);
            this.Controls.Add(this.dtVenda);
            this.Controls.Add(this.grpCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa - FarmaTec - Usuário: ";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpProduto.ResumeLayout(false);
            this.grpProduto.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.grpPagamento.ResumeLayout(false);
            this.grpPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnomecliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.GroupBox grpProduto;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label nrPedido;
        private System.Windows.Forms.DateTimePicker dtPedido;
        private System.Windows.Forms.Button btnIncluir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuConsulta;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaClientes;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroClientes;
        private System.Windows.Forms.GroupBox grpPagamento;
        private System.Windows.Forms.ComboBox cboFormaPagamento;
        private System.Windows.Forms.Button btnReceber;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.DataGridView dtVenda;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
    }
}