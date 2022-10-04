
namespace FarmaTec
{
    partial class frmConsultarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarClientes));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendasCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendasRetirada = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNovoAcesso = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlterarSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovimentacao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovimentacaoEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovimentacaoSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorioFinanceiro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorioFluxo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorioVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorioEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlConsulta = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.dtClientes = new System.Windows.Forms.DataGridView();
            this.lblClientesRegistrados = new System.Windows.Forms.Label();
            this.codCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foneCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pctClientes = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.pnlConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVendas,
            this.menuConsulta,
            this.menuCadastro,
            this.menuMovimentacao,
            this.menuRelatorios,
            this.menuSair});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1352, 24);
            this.menuStrip.TabIndex = 17;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuVendas
            // 
            this.menuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVendasCaixa,
            this.menuVendasRetirada});
            this.menuVendas.Name = "menuVendas";
            this.menuVendas.Size = new System.Drawing.Size(56, 20);
            this.menuVendas.Text = "Vendas";
            // 
            // menuVendasCaixa
            // 
            this.menuVendasCaixa.Name = "menuVendasCaixa";
            this.menuVendasCaixa.Size = new System.Drawing.Size(117, 22);
            this.menuVendasCaixa.Text = "Caixa";
            // 
            // menuVendasRetirada
            // 
            this.menuVendasRetirada.Name = "menuVendasRetirada";
            this.menuVendasRetirada.Size = new System.Drawing.Size(117, 22);
            this.menuVendasRetirada.Text = "Retirada";
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
            this.menuCadastroClientes,
            this.menuCadastroFuncionarios,
            this.menuCadastroFornecedores,
            this.produtosToolStripMenuItem});
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(66, 20);
            this.menuCadastro.Text = "Cadastro";
            // 
            // menuCadastroClientes
            // 
            this.menuCadastroClientes.Name = "menuCadastroClientes";
            this.menuCadastroClientes.Size = new System.Drawing.Size(145, 22);
            this.menuCadastroClientes.Text = "Clientes";
            // 
            // menuCadastroFuncionarios
            // 
            this.menuCadastroFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovoAcesso,
            this.menuEditarCadastro,
            this.menuAlterarSenha});
            this.menuCadastroFuncionarios.Name = "menuCadastroFuncionarios";
            this.menuCadastroFuncionarios.Size = new System.Drawing.Size(145, 22);
            this.menuCadastroFuncionarios.Text = "Funcionários";
            // 
            // menuNovoAcesso
            // 
            this.menuNovoAcesso.Name = "menuNovoAcesso";
            this.menuNovoAcesso.Size = new System.Drawing.Size(154, 22);
            this.menuNovoAcesso.Text = "Novo Acesso";
            // 
            // menuEditarCadastro
            // 
            this.menuEditarCadastro.Name = "menuEditarCadastro";
            this.menuEditarCadastro.Size = new System.Drawing.Size(154, 22);
            this.menuEditarCadastro.Text = "Editar Cadastro";
            // 
            // menuAlterarSenha
            // 
            this.menuAlterarSenha.Name = "menuAlterarSenha";
            this.menuAlterarSenha.Size = new System.Drawing.Size(154, 22);
            this.menuAlterarSenha.Text = "Alterar Senha";
            // 
            // menuCadastroFornecedores
            // 
            this.menuCadastroFornecedores.Name = "menuCadastroFornecedores";
            this.menuCadastroFornecedores.Size = new System.Drawing.Size(145, 22);
            this.menuCadastroFornecedores.Text = "Fornecedores";
            // 
            // menuMovimentacao
            // 
            this.menuMovimentacao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMovimentacaoEntrada,
            this.menuMovimentacaoSaida});
            this.menuMovimentacao.Name = "menuMovimentacao";
            this.menuMovimentacao.Size = new System.Drawing.Size(99, 20);
            this.menuMovimentacao.Text = "Movimentação";
            // 
            // menuMovimentacaoEntrada
            // 
            this.menuMovimentacaoEntrada.Name = "menuMovimentacaoEntrada";
            this.menuMovimentacaoEntrada.Size = new System.Drawing.Size(159, 22);
            this.menuMovimentacaoEntrada.Text = "Entrada Estoque";
            // 
            // menuMovimentacaoSaida
            // 
            this.menuMovimentacaoSaida.Name = "menuMovimentacaoSaida";
            this.menuMovimentacaoSaida.Size = new System.Drawing.Size(159, 22);
            this.menuMovimentacaoSaida.Text = "Saida Estoque";
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRelatorioFinanceiro,
            this.menuRelatorioFluxo,
            this.menuRelatorioVendas,
            this.menuRelatorioEstoque});
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(71, 20);
            this.menuRelatorios.Text = "Relatórios";
            // 
            // menuRelatorioFinanceiro
            // 
            this.menuRelatorioFinanceiro.Name = "menuRelatorioFinanceiro";
            this.menuRelatorioFinanceiro.Size = new System.Drawing.Size(151, 22);
            this.menuRelatorioFinanceiro.Text = "Financeiro";
            // 
            // menuRelatorioFluxo
            // 
            this.menuRelatorioFluxo.Name = "menuRelatorioFluxo";
            this.menuRelatorioFluxo.Size = new System.Drawing.Size(151, 22);
            this.menuRelatorioFluxo.Text = "Fluxo de Caixa";
            // 
            // menuRelatorioVendas
            // 
            this.menuRelatorioVendas.Name = "menuRelatorioVendas";
            this.menuRelatorioVendas.Size = new System.Drawing.Size(151, 22);
            this.menuRelatorioVendas.Text = "Vendas";
            // 
            // menuRelatorioEstoque
            // 
            this.menuRelatorioEstoque.Name = "menuRelatorioEstoque";
            this.menuRelatorioEstoque.Size = new System.Drawing.Size(151, 22);
            this.menuRelatorioEstoque.Text = "Estoque";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlConsulta.Controls.Add(this.maskedTextBox1);
            this.pnlConsulta.Controls.Add(this.lblCpf);
            this.pnlConsulta.Controls.Add(this.lblBuscar);
            this.pnlConsulta.Controls.Add(this.btnBuscar);
            this.pnlConsulta.Controls.Add(this.lblNomeCliente);
            this.pnlConsulta.Controls.Add(this.lblcodigo);
            this.pnlConsulta.Controls.Add(this.txtCodCliente);
            this.pnlConsulta.Controls.Add(this.txtNomeCliente);
            this.pnlConsulta.Location = new System.Drawing.Point(37, 67);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(974, 121);
            this.pnlConsulta.TabIndex = 18;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(377, 65);
            this.maskedTextBox1.Mask = "###.###.###-##";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(136, 29);
            this.maskedTextBox1.TabIndex = 16;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(426, 42);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(40, 20);
            this.lblCpf.TabIndex = 15;
            this.lblCpf.Text = "CPF";
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
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(119, 42);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(126, 20);
            this.lblNomeCliente.TabIndex = 11;
            this.lblNomeCliente.Text = "Nome do Cliente";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(11, 42);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(59, 20);
            this.lblcodigo.TabIndex = 8;
            this.lblcodigo.Text = "Código";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.AllowDrop = true;
            this.txtCodCliente.Enabled = false;
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(5, 65);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(80, 29);
            this.txtCodCliente.TabIndex = 7;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeCliente.Location = new System.Drawing.Point(118, 65);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(226, 29);
            this.txtNomeCliente.TabIndex = 6;
            // 
            // dtClientes
            // 
            this.dtClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codCliente,
            this.nomeCliente,
            this.endereco,
            this.cep,
            this.cidade,
            this.bairro,
            this.uf,
            this.cpf,
            this.foneCliente,
            this.emailCliente});
            this.dtClientes.Location = new System.Drawing.Point(118, 274);
            this.dtClientes.Name = "dtClientes";
            this.dtClientes.Size = new System.Drawing.Size(1247, 388);
            this.dtClientes.TabIndex = 19;
            this.dtClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblClientesRegistrados
            // 
            this.lblClientesRegistrados.AutoSize = true;
            this.lblClientesRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesRegistrados.Location = new System.Drawing.Point(172, 243);
            this.lblClientesRegistrados.Name = "lblClientesRegistrados";
            this.lblClientesRegistrados.Size = new System.Drawing.Size(211, 25);
            this.lblClientesRegistrados.TabIndex = 21;
            this.lblClientesRegistrados.Text = "Clientes Registrados";
            // 
            // codCliente
            // 
            this.codCliente.HeaderText = "Código";
            this.codCliente.MaxInputLength = 1000;
            this.codCliente.Name = "codCliente";
            this.codCliente.Width = 80;
            // 
            // nomeCliente
            // 
            this.nomeCliente.HeaderText = "Cliente";
            this.nomeCliente.MaxInputLength = 50;
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Width = 130;
            // 
            // endereco
            // 
            this.endereco.HeaderText = "Endereço";
            this.endereco.MaxInputLength = 50;
            this.endereco.Name = "endereco";
            this.endereco.Width = 130;
            // 
            // cep
            // 
            this.cep.HeaderText = "CEP";
            this.cep.MaxInputLength = 8;
            this.cep.Name = "cep";
            this.cep.Width = 80;
            // 
            // cidade
            // 
            this.cidade.HeaderText = "Cidade";
            this.cidade.MaxInputLength = 50;
            this.cidade.Name = "cidade";
            this.cidade.Width = 130;
            // 
            // bairro
            // 
            this.bairro.HeaderText = "Bairro";
            this.bairro.MaxInputLength = 50;
            this.bairro.Name = "bairro";
            this.bairro.Width = 200;
            // 
            // uf
            // 
            this.uf.HeaderText = "UF";
            this.uf.Name = "uf";
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.MaxInputLength = 13;
            this.cpf.Name = "cpf";
            this.cpf.Width = 130;
            // 
            // foneCliente
            // 
            this.foneCliente.HeaderText = "Telefone";
            this.foneCliente.MaxInputLength = 13;
            this.foneCliente.Name = "foneCliente";
            // 
            // emailCliente
            // 
            this.emailCliente.HeaderText = "Email";
            this.emailCliente.MaxInputLength = 100;
            this.emailCliente.Name = "emailCliente";
            this.emailCliente.Width = 130;
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSair.FlatAppearance.BorderSize = 20;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(1067, 67);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 107);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(825, 73);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(132, 40);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // pctClientes
            // 
            this.pctClientes.Image = ((System.Drawing.Image)(resources.GetObject("pctClientes.Image")));
            this.pctClientes.Location = new System.Drawing.Point(121, 234);
            this.pctClientes.Name = "pctClientes";
            this.pctClientes.Size = new System.Drawing.Size(45, 50);
            this.pctClientes.TabIndex = 22;
            this.pctClientes.TabStop = false;
            // 
            // frmConsultarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1352, 729);
            this.Controls.Add(this.lblClientesRegistrados);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dtClientes);
            this.Controls.Add(this.pnlConsulta);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pctClientes);
            this.Name = "frmConsultarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultarClientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlConsulta.ResumeLayout(false);
            this.pnlConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuVendas;
        private System.Windows.Forms.ToolStripMenuItem menuVendasCaixa;
        private System.Windows.Forms.ToolStripMenuItem menuVendasRetirada;
        private System.Windows.Forms.ToolStripMenuItem menuConsulta;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaClientes;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroClientes;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menuNovoAcesso;
        private System.Windows.Forms.ToolStripMenuItem menuEditarCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuAlterarSenha;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentacao;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentacaoEntrada;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentacaoSaida;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorioFinanceiro;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorioFluxo;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorioVendas;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorioEstoque;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.Panel pnlConsulta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.DataGridView dtClientes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblClientesRegistrados;
        private System.Windows.Forms.PictureBox pctClientes;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn foneCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCliente;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
    }
}