
namespace FarmaTec
{
    partial class frmEditarCadastro
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
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtEmailFuncionario = new System.Windows.Forms.TextBox();
            this.lblEmailFuncionario = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblTituloEditarCadastro = new System.Windows.Forms.Label();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.txtCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblStatusCadastro = new System.Windows.Forms.Label();
            this.radAtivo = new System.Windows.Forms.RadioButton();
            this.radReset = new System.Windows.Forms.RadioButton();
            this.radDesativado = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cmbCargo
            // 
            this.cmbCargo.Enabled = false;
            this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.ItemHeight = 20;
            this.cmbCargo.Location = new System.Drawing.Point(284, 262);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(121, 28);
            this.cmbCargo.TabIndex = 5;
            this.cmbCargo.SelectionChangeCommitted += new System.EventHandler(this.cmbCargo_SelectionChangeCommitted);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(156, 265);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(52, 20);
            this.lblCargo.TabIndex = 57;
            this.lblCargo.Text = "Cargo";
            // 
            // txtEmailFuncionario
            // 
            this.txtEmailFuncionario.Enabled = false;
            this.txtEmailFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailFuncionario.Location = new System.Drawing.Point(284, 230);
            this.txtEmailFuncionario.Name = "txtEmailFuncionario";
            this.txtEmailFuncionario.Size = new System.Drawing.Size(250, 26);
            this.txtEmailFuncionario.TabIndex = 4;
            // 
            // lblEmailFuncionario
            // 
            this.lblEmailFuncionario.AutoSize = true;
            this.lblEmailFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailFuncionario.Location = new System.Drawing.Point(156, 233);
            this.lblEmailFuncionario.Name = "lblEmailFuncionario";
            this.lblEmailFuncionario.Size = new System.Drawing.Size(48, 20);
            this.lblEmailFuncionario.TabIndex = 55;
            this.lblEmailFuncionario.Text = "Email";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(459, 370);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 28);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(438, 129);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(98, 28);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(202, 370);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 28);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblTituloEditarCadastro
            // 
            this.lblTituloEditarCadastro.AutoSize = true;
            this.lblTituloEditarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEditarCadastro.Location = new System.Drawing.Point(126, 35);
            this.lblTituloEditarCadastro.Name = "lblTituloEditarCadastro";
            this.lblTituloEditarCadastro.Size = new System.Drawing.Size(510, 37);
            this.lblTituloEditarCadastro.TabIndex = 51;
            this.lblTituloEditarCadastro.Text = "Editar Cadastro de Funcionários";
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.Location = new System.Drawing.Point(156, 199);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(51, 20);
            this.lblNomeFuncionario.TabIndex = 49;
            this.lblNomeFuncionario.Text = "Nome";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Enabled = false;
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.Location = new System.Drawing.Point(284, 196);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(390, 26);
            this.txtNomeFuncionario.TabIndex = 3;
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(284, 131);
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(142, 26);
            this.txtCodigoFuncionario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(156, 131);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 46;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblStatusCadastro
            // 
            this.lblStatusCadastro.AutoSize = true;
            this.lblStatusCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCadastro.Location = new System.Drawing.Point(156, 299);
            this.lblStatusCadastro.Name = "lblStatusCadastro";
            this.lblStatusCadastro.Size = new System.Drawing.Size(56, 20);
            this.lblStatusCadastro.TabIndex = 61;
            this.lblStatusCadastro.Text = "Status";
            // 
            // radAtivo
            // 
            this.radAtivo.AutoSize = true;
            this.radAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAtivo.Location = new System.Drawing.Point(283, 302);
            this.radAtivo.Name = "radAtivo";
            this.radAtivo.Size = new System.Drawing.Size(62, 24);
            this.radAtivo.TabIndex = 6;
            this.radAtivo.TabStop = true;
            this.radAtivo.Text = "Ativo";
            this.radAtivo.UseVisualStyleBackColor = true;
            // 
            // radReset
            // 
            this.radReset.AutoSize = true;
            this.radReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radReset.Location = new System.Drawing.Point(464, 302);
            this.radReset.Name = "radReset";
            this.radReset.Size = new System.Drawing.Size(70, 24);
            this.radReset.TabIndex = 8;
            this.radReset.TabStop = true;
            this.radReset.Text = "Reset";
            this.radReset.UseVisualStyleBackColor = true;
            // 
            // radDesativado
            // 
            this.radDesativado.AutoSize = true;
            this.radDesativado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDesativado.Location = new System.Drawing.Point(351, 302);
            this.radDesativado.Name = "radDesativado";
            this.radDesativado.Size = new System.Drawing.Size(107, 24);
            this.radDesativado.TabIndex = 7;
            this.radDesativado.TabStop = true;
            this.radDesativado.Text = "Desativado";
            this.radDesativado.UseVisualStyleBackColor = true;
            // 
            // frmEditarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radDesativado);
            this.Controls.Add(this.radReset);
            this.Controls.Add(this.radAtivo);
            this.Controls.Add(this.lblStatusCadastro);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtEmailFuncionario);
            this.Controls.Add(this.lblEmailFuncionario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblTituloEditarCadastro);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.txtCodigoFuncionario);
            this.Controls.Add(this.lblUsuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditarCadastro";
            this.Text = "Editar Cadastro de Funcionários - FarmaTec - Usuário: ";
            this.Load += new System.EventHandler(this.frmEditarCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtEmailFuncionario;
        private System.Windows.Forms.Label lblEmailFuncionario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblTituloEditarCadastro;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.TextBox txtCodigoFuncionario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblStatusCadastro;
        private System.Windows.Forms.RadioButton radAtivo;
        private System.Windows.Forms.RadioButton radReset;
        private System.Windows.Forms.RadioButton radDesativado;
    }
}