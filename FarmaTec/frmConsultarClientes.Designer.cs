
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
            this.pnlConsulta = new System.Windows.Forms.Panel();
            this.lblOu = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtnomeCliente = new System.Windows.Forms.TextBox();
            this.dtClientes = new System.Windows.Forms.DataGridView();
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
            this.lblClientesRegistrados = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.pctClientes = new System.Windows.Forms.PictureBox();
            this.pnlConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlConsulta.Controls.Add(this.lblOu);
            this.pnlConsulta.Controls.Add(this.mskCpf);
            this.pnlConsulta.Controls.Add(this.lblCpf);
            this.pnlConsulta.Controls.Add(this.lblBuscar);
            this.pnlConsulta.Controls.Add(this.btnBuscar);
            this.pnlConsulta.Controls.Add(this.lblNomeCliente);
            this.pnlConsulta.Controls.Add(this.txtnomeCliente);
            this.pnlConsulta.Location = new System.Drawing.Point(37, 67);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(974, 121);
            this.pnlConsulta.TabIndex = 18;
            // 
            // lblOu
            // 
            this.lblOu.AutoSize = true;
            this.lblOu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOu.Location = new System.Drawing.Point(308, 73);
            this.lblOu.Name = "lblOu";
            this.lblOu.Size = new System.Drawing.Size(48, 20);
            this.lblOu.TabIndex = 16;
            this.lblOu.Text = "E/OU";
            // 
            // mskCpf
            // 
            this.mskCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpf.Location = new System.Drawing.Point(408, 67);
            this.mskCpf.Mask = "###,###,###-##";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(136, 29);
            this.mskCpf.TabIndex = 3;
            this.mskCpf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mskCpf_MouseClick);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(457, 44);
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
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(40, 44);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(126, 20);
            this.lblNomeCliente.TabIndex = 11;
            this.lblNomeCliente.Text = "Nome do Cliente";
            // 
            // txtnomeCliente
            // 
            this.txtnomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomeCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtnomeCliente.Location = new System.Drawing.Point(31, 67);
            this.txtnomeCliente.Name = "txtnomeCliente";
            this.txtnomeCliente.Size = new System.Drawing.Size(226, 29);
            this.txtnomeCliente.TabIndex = 2;
            // 
            // dtClientes
            // 
            this.dtClientes.AllowUserToAddRows = false;
            this.dtClientes.AllowUserToDeleteRows = false;
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
            this.dtClientes.ReadOnly = true;
            this.dtClientes.Size = new System.Drawing.Size(1247, 388);
            this.dtClientes.TabIndex = 19;
            // 
            // codCliente
            // 
            this.codCliente.HeaderText = "Código";
            this.codCliente.MaxInputLength = 1000;
            this.codCliente.Name = "codCliente";
            this.codCliente.ReadOnly = true;
            this.codCliente.Width = 80;
            // 
            // nomeCliente
            // 
            this.nomeCliente.HeaderText = "Cliente";
            this.nomeCliente.MaxInputLength = 50;
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.ReadOnly = true;
            this.nomeCliente.Width = 130;
            // 
            // endereco
            // 
            this.endereco.HeaderText = "Endereço";
            this.endereco.MaxInputLength = 50;
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Width = 130;
            // 
            // cep
            // 
            this.cep.HeaderText = "CEP";
            this.cep.MaxInputLength = 8;
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            this.cep.Width = 80;
            // 
            // cidade
            // 
            this.cidade.HeaderText = "Cidade";
            this.cidade.MaxInputLength = 50;
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 130;
            // 
            // bairro
            // 
            this.bairro.HeaderText = "Bairro";
            this.bairro.MaxInputLength = 50;
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            this.bairro.Width = 200;
            // 
            // uf
            // 
            this.uf.HeaderText = "UF";
            this.uf.Name = "uf";
            this.uf.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.MaxInputLength = 13;
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            this.cpf.Width = 130;
            // 
            // foneCliente
            // 
            this.foneCliente.HeaderText = "Telefone";
            this.foneCliente.MaxInputLength = 13;
            this.foneCliente.Name = "foneCliente";
            this.foneCliente.ReadOnly = true;
            // 
            // emailCliente
            // 
            this.emailCliente.HeaderText = "Email";
            this.emailCliente.MaxInputLength = 100;
            this.emailCliente.Name = "emailCliente";
            this.emailCliente.ReadOnly = true;
            this.emailCliente.Width = 130;
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
            this.Controls.Add(this.pctClientes);
            this.Name = "frmConsultarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultarClientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConsultarClientes_Load);
            this.pnlConsulta.ResumeLayout(false);
            this.pnlConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlConsulta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtnomeCliente;
        private System.Windows.Forms.DataGridView dtClientes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblClientesRegistrados;
        private System.Windows.Forms.PictureBox pctClientes;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.MaskedTextBox mskCpf;
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
        private System.Windows.Forms.Label lblOu;
    }
}