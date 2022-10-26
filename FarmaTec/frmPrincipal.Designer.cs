
namespace FarmaTec
{
    partial class frmPrincipal
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
            this.menuCadastroFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovimentacao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovimentacaoEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StatusSistema = new System.Windows.Forms.StatusStrip();
            this.StatusUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StatusSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVendas,
            this.menuConsulta,
            this.menuCadastro,
            this.menuMovimentacao,
            this.menuRelatorios,
            this.menuSair});
            this.menuStrip.Location = new System.Drawing.Point(-7, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1607, 24);
            this.menuStrip.TabIndex = 17;
            this.menuStrip.Text = "menuPrincipal";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
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
            this.menuVendasCaixa.Click += new System.EventHandler(this.menuVendasCaixa_Click);
            // 
            // menuVendasRetirada
            // 
            this.menuVendasRetirada.Name = "menuVendasRetirada";
            this.menuVendasRetirada.Size = new System.Drawing.Size(117, 22);
            this.menuVendasRetirada.Text = "Retirada";
            this.menuVendasRetirada.Click += new System.EventHandler(this.menuVendasRetirada_Click);
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
            this.menuConsultaProdutos.Click += new System.EventHandler(this.menuConsultaProdutos_Click);
            // 
            // menuConsultaClientes
            // 
            this.menuConsultaClientes.Name = "menuConsultaClientes";
            this.menuConsultaClientes.Size = new System.Drawing.Size(122, 22);
            this.menuConsultaClientes.Text = "Clientes";
            this.menuConsultaClientes.Click += new System.EventHandler(this.menuConsultaClientes_Click);
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroClientes,
            this.menuCadastroFuncionarios,
            this.menuCadastroFornecedores,
            this.menuCadastroProdutos});
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(66, 20);
            this.menuCadastro.Text = "Cadastro";
            // 
            // menuCadastroClientes
            // 
            this.menuCadastroClientes.Name = "menuCadastroClientes";
            this.menuCadastroClientes.Size = new System.Drawing.Size(145, 22);
            this.menuCadastroClientes.Text = "Clientes";
            this.menuCadastroClientes.Click += new System.EventHandler(this.menuCadastroClientes_Click);
            // 
            // menuCadastroFuncionarios
            // 
            this.menuCadastroFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovoAcesso,
            this.menuEditarCadastro});
            this.menuCadastroFuncionarios.Name = "menuCadastroFuncionarios";
            this.menuCadastroFuncionarios.Size = new System.Drawing.Size(145, 22);
            this.menuCadastroFuncionarios.Text = "Funcionários";
            this.menuCadastroFuncionarios.Click += new System.EventHandler(this.menuCadastroFuncionarios_Click);
            // 
            // menuNovoAcesso
            // 
            this.menuNovoAcesso.Name = "menuNovoAcesso";
            this.menuNovoAcesso.Size = new System.Drawing.Size(154, 22);
            this.menuNovoAcesso.Text = "Novo Acesso";
            this.menuNovoAcesso.Click += new System.EventHandler(this.menuNovoAcesso_Click);
            // 
            // menuEditarCadastro
            // 
            this.menuEditarCadastro.Name = "menuEditarCadastro";
            this.menuEditarCadastro.Size = new System.Drawing.Size(154, 22);
            this.menuEditarCadastro.Text = "Editar Cadastro";
            this.menuEditarCadastro.Click += new System.EventHandler(this.menuEditarCadastro_Click);
            // 
            // menuCadastroFornecedores
            // 
            this.menuCadastroFornecedores.Name = "menuCadastroFornecedores";
            this.menuCadastroFornecedores.Size = new System.Drawing.Size(145, 22);
            this.menuCadastroFornecedores.Text = "Fornecedores";
            this.menuCadastroFornecedores.Click += new System.EventHandler(this.menuCadastroFornecedores_Click);
            // 
            // menuCadastroProdutos
            // 
            this.menuCadastroProdutos.Name = "menuCadastroProdutos";
            this.menuCadastroProdutos.Size = new System.Drawing.Size(145, 22);
            this.menuCadastroProdutos.Text = "Produtos";
            this.menuCadastroProdutos.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // menuMovimentacao
            // 
            this.menuMovimentacao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMovimentacaoEntrada});
            this.menuMovimentacao.Name = "menuMovimentacao";
            this.menuMovimentacao.Size = new System.Drawing.Size(99, 20);
            this.menuMovimentacao.Text = "Movimentação";
            // 
            // menuMovimentacaoEntrada
            // 
            this.menuMovimentacaoEntrada.Name = "menuMovimentacaoEntrada";
            this.menuMovimentacaoEntrada.Size = new System.Drawing.Size(154, 22);
            this.menuMovimentacaoEntrada.Text = "Movimentação";
            this.menuMovimentacaoEntrada.Click += new System.EventHandler(this.menuMovimentacaoEntrada_Click);
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(71, 20);
            this.menuRelatorios.Text = "Relatórios";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FarmaTec.Properties.Resources.FarmaTec_removebg_preview;
            this.pictureBox1.InitialImage = global::FarmaTec.Properties.Resources.FarmaTec_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(575, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StatusSistema
            // 
            this.StatusSistema.Enabled = false;
            this.StatusSistema.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StatusSistema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusUsuario});
            this.StatusSistema.Location = new System.Drawing.Point(0, 707);
            this.StatusSistema.Name = "StatusSistema";
            this.StatusSistema.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.StatusSistema.Size = new System.Drawing.Size(1350, 22);
            this.StatusSistema.TabIndex = 18;
            this.StatusSistema.Text = "statusStrip1";
            // 
            // StatusUsuario
            // 
            this.StatusUsuario.Name = "StatusUsuario";
            this.StatusUsuario.Size = new System.Drawing.Size(118, 17);
            this.StatusUsuario.Text = "toolStripStatusLabel1";
            this.StatusUsuario.Click += new System.EventHandler(this.StatusUsuario_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.StatusSistema);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal - FarmaTec - Usuário: ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StatusSistema.ResumeLayout(false);
            this.StatusSistema.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentacao;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentacaoEntrada;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroProdutos;
        private System.Windows.Forms.ToolStripStatusLabel StatusUsuario;
        private System.Windows.Forms.StatusStrip StatusSistema;
    }
}