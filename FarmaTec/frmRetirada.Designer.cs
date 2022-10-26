
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
            this.txtnumpedido = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.btnFinalizarRetirada = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.dtRetirada = new System.Windows.Forms.DataGridView();
            this.codProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtpreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtprecototal = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.grpPedido.Controls.Add(this.txtnumpedido);
            this.grpPedido.Controls.Add(this.txtdescricao);
            this.grpPedido.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPedido.Location = new System.Drawing.Point(941, 47);
            this.grpPedido.Margin = new System.Windows.Forms.Padding(4);
            this.grpPedido.Name = "grpPedido";
            this.grpPedido.Padding = new System.Windows.Forms.Padding(4);
            this.grpPedido.Size = new System.Drawing.Size(863, 250);
            this.grpPedido.TabIndex = 11;
            this.grpPedido.TabStop = false;
            this.grpPedido.Text = "Pedido";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(695, 161);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(131, 46);
            this.btnIncluir.TabIndex = 19;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // dtPedido
            // 
            this.dtPedido.Enabled = false;
            this.dtPedido.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPedido.Location = new System.Drawing.Point(159, 172);
            this.dtPedido.Margin = new System.Windows.Forms.Padding(4);
            this.dtPedido.Name = "dtPedido";
            this.dtPedido.Size = new System.Drawing.Size(416, 34);
            this.dtPedido.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data de Retirada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descrição do Pedido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nº Pedido";
            // 
            // txtnumpedido
            // 
            this.txtnumpedido.AllowDrop = true;
            this.txtnumpedido.Enabled = false;
            this.txtnumpedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumpedido.Location = new System.Drawing.Point(8, 80);
            this.txtnumpedido.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumpedido.Name = "txtnumpedido";
            this.txtnumpedido.Size = new System.Drawing.Size(100, 34);
            this.txtnumpedido.TabIndex = 1;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtdescricao.Location = new System.Drawing.Point(159, 80);
            this.txtdescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(665, 34);
            this.txtdescricao.TabIndex = 0;
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.label3);
            this.grpCliente.Controls.Add(this.lblNomeCliente);
            this.grpCliente.Controls.Add(this.txtNomeFuncionario);
            this.grpCliente.Controls.Add(this.txtNomeCliente);
            this.grpCliente.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCliente.Location = new System.Drawing.Point(51, 47);
            this.grpCliente.Margin = new System.Windows.Forms.Padding(4);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Padding = new System.Windows.Forms.Padding(4);
            this.grpCliente.Size = new System.Drawing.Size(863, 250);
            this.grpCliente.TabIndex = 10;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Cliente/Funcionário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome do Funcionário";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Enabled = false;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(2, 52);
            this.lblNomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(163, 25);
            this.lblNomeCliente.TabIndex = 4;
            this.lblNomeCliente.Text = "Nome do Cliente:";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Enabled = false;
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeFuncionario.Location = new System.Drawing.Point(8, 171);
            this.txtNomeFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(665, 34);
            this.txtNomeFuncionario.TabIndex = 2;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeCliente.Location = new System.Drawing.Point(8, 80);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(665, 34);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // btnFinalizarRetirada
            // 
            this.btnFinalizarRetirada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.btnFinalizarRetirada.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizarRetirada.Image")));
            this.btnFinalizarRetirada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFinalizarRetirada.Location = new System.Drawing.Point(1687, 369);
            this.btnFinalizarRetirada.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizarRetirada.Name = "btnFinalizarRetirada";
            this.btnFinalizarRetirada.Size = new System.Drawing.Size(143, 132);
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
            this.btnSair.Location = new System.Drawing.Point(1687, 508);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(143, 132);
            this.btnSair.TabIndex = 17;
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
            this.btnCancelar.Location = new System.Drawing.Point(1687, 647);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 128);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConsulta});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1845, 30);
            this.menuStrip.TabIndex = 19;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuConsulta
            // 
            this.menuConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConsultaClientes});
            this.menuConsulta.Name = "menuConsulta";
            this.menuConsulta.Size = new System.Drawing.Size(80, 26);
            this.menuConsulta.Text = "Consulta";
            // 
            // menuConsultaClientes
            // 
            this.menuConsultaClientes.Name = "menuConsultaClientes";
            this.menuConsultaClientes.Size = new System.Drawing.Size(144, 26);
            this.menuConsultaClientes.Text = "Clientes";
            this.menuConsultaClientes.Click += new System.EventHandler(this.menuConsultaClientes_Click);
            // 
            // dtRetirada
            // 
            this.dtRetirada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRetirada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProduto,
            this.descricao,
            this.txtpreco,
            this.qtde,
            this.txtprecototal});
            this.dtRetirada.Location = new System.Drawing.Point(419, 345);
            this.dtRetirada.Margin = new System.Windows.Forms.Padding(4);
            this.dtRetirada.Name = "dtRetirada";
            this.dtRetirada.RowHeadersWidth = 51;
            this.dtRetirada.Size = new System.Drawing.Size(991, 430);
            this.dtRetirada.TabIndex = 20;
            // 
            // codProduto
            // 
            this.codProduto.HeaderText = "Código";
            this.codProduto.MaxInputLength = 99999;
            this.codProduto.MinimumWidth = 6;
            this.codProduto.Name = "codProduto";
            this.codProduto.ReadOnly = true;
            this.codProduto.Width = 125;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Produto";
            this.descricao.MaxInputLength = 120;
            this.descricao.MinimumWidth = 6;
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 300;
            // 
            // txtpreco
            // 
            this.txtpreco.HeaderText = "Valor Unitário";
            this.txtpreco.MaxInputLength = 50;
            this.txtpreco.MinimumWidth = 6;
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.ReadOnly = true;
            this.txtpreco.Width = 170;
            // 
            // qtde
            // 
            this.qtde.HeaderText = "Quantidade";
            this.qtde.MaxInputLength = 5;
            this.qtde.MinimumWidth = 6;
            this.qtde.Name = "qtde";
            this.qtde.ReadOnly = true;
            this.qtde.Width = 170;
            // 
            // txtprecototal
            // 
            this.txtprecototal.HeaderText = "Total";
            this.txtprecototal.MaxInputLength = 30;
            this.txtprecototal.MinimumWidth = 6;
            this.txtprecototal.Name = "txtprecototal";
            this.txtprecototal.ReadOnly = true;
            this.txtprecototal.Width = 170;
            // 
            // frmRetirada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1845, 814);
            this.Controls.Add(this.dtRetirada);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.btnFinalizarRetirada);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpPedido);
            this.Controls.Add(this.grpCliente);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox txtnumpedido;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnFinalizarRetirada;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuConsulta;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaClientes;
        private System.Windows.Forms.DataGridView dtRetirada;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtpreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtprecototal;
    }
}