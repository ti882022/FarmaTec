
namespace FarmaTec
{
    partial class frmRetirada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRetirada));
            this.grpPedido = new System.Windows.Forms.GroupBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.dtPedido = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.txtCodFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.btnFinalizarRetirada = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.dtRetirada = new System.Windows.Forms.DataGridView();
            this.dsCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsPrecoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPedido.SuspendLayout();
            this.grpCliente.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtRetirada)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPedido
            // 
            this.grpPedido.Controls.Add(this.btnIncluir);
            this.grpPedido.Controls.Add(this.dtPedido);
            this.grpPedido.Controls.Add(this.label1);
            this.grpPedido.Controls.Add(this.label4);
            this.grpPedido.Controls.Add(this.label6);
            this.grpPedido.Controls.Add(this.textBox3);
            this.grpPedido.Controls.Add(this.textBox4);
            this.grpPedido.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPedido.Location = new System.Drawing.Point(706, 38);
            this.grpPedido.Name = "grpPedido";
            this.grpPedido.Size = new System.Drawing.Size(647, 203);
            this.grpPedido.TabIndex = 11;
            this.grpPedido.TabStop = false;
            this.grpPedido.Text = "Pedido";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(521, 131);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(98, 37);
            this.btnIncluir.TabIndex = 19;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // dtPedido
            // 
            this.dtPedido.Enabled = false;
            this.dtPedido.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPedido.Location = new System.Drawing.Point(119, 140);
            this.dtPedido.Name = "dtPedido";
            this.dtPedido.Size = new System.Drawing.Size(313, 28);
            this.dtPedido.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data de Retirada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descrição do Pedido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nº Pedido";
            // 
            // textBox3
            // 
            this.textBox3.AllowDrop = true;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(6, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 29);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4.Location = new System.Drawing.Point(119, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(500, 29);
            this.textBox4.TabIndex = 0;
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.label3);
            this.grpCliente.Controls.Add(this.lblNomeCliente);
            this.grpCliente.Controls.Add(this.txtNomeFuncionario);
            this.grpCliente.Controls.Add(this.txtCodFuncionario);
            this.grpCliente.Controls.Add(this.label2);
            this.grpCliente.Controls.Add(this.lblCodCliente);
            this.grpCliente.Controls.Add(this.txtCodCliente);
            this.grpCliente.Controls.Add(this.txtNomeCliente);
            this.grpCliente.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCliente.Location = new System.Drawing.Point(38, 38);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(647, 203);
            this.grpCliente.TabIndex = 10;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Cliente/Funcionário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome do Funcionário";
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
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Enabled = false;
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeFuncionario.Location = new System.Drawing.Point(119, 139);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(500, 29);
            this.txtNomeFuncionario.TabIndex = 2;
            // 
            // txtCodFuncionario
            // 
            this.txtCodFuncionario.AllowDrop = true;
            this.txtCodFuncionario.Enabled = false;
            this.txtCodFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFuncionario.Location = new System.Drawing.Point(6, 139);
            this.txtCodFuncionario.Name = "txtCodFuncionario";
            this.txtCodFuncionario.Size = new System.Drawing.Size(76, 29);
            this.txtCodFuncionario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código:";
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCliente.Location = new System.Drawing.Point(6, 42);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(63, 20);
            this.lblCodCliente.TabIndex = 3;
            this.lblCodCliente.Text = "Código:";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.AllowDrop = true;
            this.txtCodCliente.Enabled = false;
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(6, 65);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(76, 29);
            this.txtCodCliente.TabIndex = 1;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeCliente.Location = new System.Drawing.Point(119, 65);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(500, 29);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // btnFinalizarRetirada
            // 
            this.btnFinalizarRetirada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.btnFinalizarRetirada.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizarRetirada.Image")));
            this.btnFinalizarRetirada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFinalizarRetirada.Location = new System.Drawing.Point(1265, 300);
            this.btnFinalizarRetirada.Name = "btnFinalizarRetirada";
            this.btnFinalizarRetirada.Size = new System.Drawing.Size(107, 107);
            this.btnFinalizarRetirada.TabIndex = 18;
            this.btnFinalizarRetirada.Text = "Finalizar Retirada";
            this.btnFinalizarRetirada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinalizarRetirada.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSair.FlatAppearance.BorderSize = 20;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(1265, 413);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 107);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(1265, 526);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 104);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConsulta});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1384, 24);
            this.menuStrip.TabIndex = 19;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuConsulta
            // 
            this.menuConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConsultaClientes});
            this.menuConsulta.Name = "menuConsulta";
            this.menuConsulta.Size = new System.Drawing.Size(66, 20);
            this.menuConsulta.Text = "Consulta";
            // 
            // menuConsultaClientes
            // 
            this.menuConsultaClientes.Name = "menuConsultaClientes";
            this.menuConsultaClientes.Size = new System.Drawing.Size(180, 22);
            this.menuConsultaClientes.Text = "Clientes";
            this.menuConsultaClientes.Click += new System.EventHandler(this.menuConsultaClientes_Click);
            // 
            // dtRetirada
            // 
            this.dtRetirada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRetirada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dsCodigo,
            this.dsProduto,
            this.dsPreco,
            this.dsQuantidade,
            this.dsDesconto,
            this.dsPrecoTotal});
            this.dtRetirada.Location = new System.Drawing.Point(230, 281);
            this.dtRetirada.Name = "dtRetirada";
            this.dtRetirada.Size = new System.Drawing.Size(934, 349);
            this.dtRetirada.TabIndex = 20;
            // 
            // dsCodigo
            // 
            this.dsCodigo.HeaderText = "Código";
            this.dsCodigo.MaxInputLength = 99999;
            this.dsCodigo.Name = "dsCodigo";
            this.dsCodigo.ReadOnly = true;
            // 
            // dsProduto
            // 
            this.dsProduto.HeaderText = "Produto";
            this.dsProduto.MaxInputLength = 120;
            this.dsProduto.Name = "dsProduto";
            this.dsProduto.ReadOnly = true;
            this.dsProduto.Width = 300;
            // 
            // dsPreco
            // 
            this.dsPreco.HeaderText = "Valor Unitário";
            this.dsPreco.MaxInputLength = 50;
            this.dsPreco.Name = "dsPreco";
            this.dsPreco.ReadOnly = true;
            this.dsPreco.Width = 130;
            // 
            // dsQuantidade
            // 
            this.dsQuantidade.HeaderText = "Quantidade";
            this.dsQuantidade.MaxInputLength = 5;
            this.dsQuantidade.Name = "dsQuantidade";
            this.dsQuantidade.ReadOnly = true;
            // 
            // dsDesconto
            // 
            this.dsDesconto.HeaderText = "Desconto";
            this.dsDesconto.MaxInputLength = 5;
            this.dsDesconto.Name = "dsDesconto";
            this.dsDesconto.ReadOnly = true;
            this.dsDesconto.Width = 130;
            // 
            // dsPrecoTotal
            // 
            this.dsPrecoTotal.HeaderText = "Total";
            this.dsPrecoTotal.MaxInputLength = 30;
            this.dsPrecoTotal.Name = "dsPrecoTotal";
            this.dsPrecoTotal.ReadOnly = true;
            this.dsPrecoTotal.Width = 130;
            // 
            // frmRetirada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.dtRetirada);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.btnFinalizarRetirada);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpPedido);
            this.Controls.Add(this.grpCliente);
            this.Name = "frmRetirada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retirada de Produtos - FarmaTec - Usuário: ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpPedido.ResumeLayout(false);
            this.grpPedido.PerformLayout();
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtRetirada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPedido;
        private System.Windows.Forms.DateTimePicker dtPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.TextBox txtCodFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnFinalizarRetirada;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuConsulta;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaClientes;
        private System.Windows.Forms.DataGridView dtRetirada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsPrecoTotal;
    }
}