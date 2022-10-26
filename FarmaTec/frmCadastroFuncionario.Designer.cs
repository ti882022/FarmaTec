
namespace FarmaTec
{
    partial class frmCadastroFuncionario
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblTituloFuncionario = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.txtCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.lblCodFuncionario = new System.Windows.Forms.Label();
            this.txtEmailFuncionario = new System.Windows.Forms.TextBox();
            this.lblEmailFuncionario = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblCargo = new System.Windows.Forms.Label();
            this.cboclassefunc = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtsexo = new System.Windows.Forms.ComboBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(585, 362);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 28);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(467, 362);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 28);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(345, 362);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 28);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblTituloFuncionario
            // 
            this.lblTituloFuncionario.AutoSize = true;
            this.lblTituloFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFuncionario.Location = new System.Drawing.Point(167, 64);
            this.lblTituloFuncionario.Name = "lblTituloFuncionario";
            this.lblTituloFuncionario.Size = new System.Drawing.Size(482, 37);
            this.lblTituloFuncionario.TabIndex = 36;
            this.lblTituloFuncionario.Text = "Cadastro de Novo Funcionário";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(194, 241);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblTelefone.TabIndex = 34;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.Location = new System.Drawing.Point(194, 181);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(51, 20);
            this.lblNomeFuncionario.TabIndex = 31;
            this.lblNomeFuncionario.Text = "Nome";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.Location = new System.Drawing.Point(325, 179);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(390, 26);
            this.txtNomeFuncionario.TabIndex = 2;
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.Enabled = false;
            this.txtCodigoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(325, 148);
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(63, 26);
            this.txtCodigoFuncionario.TabIndex = 1;
            this.txtCodigoFuncionario.TextChanged += new System.EventHandler(this.txtCodigoFuncionario_TextChanged);
            // 
            // lblCodFuncionario
            // 
            this.lblCodFuncionario.AutoSize = true;
            this.lblCodFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCodFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodFuncionario.Location = new System.Drawing.Point(194, 151);
            this.lblCodFuncionario.Name = "lblCodFuncionario";
            this.lblCodFuncionario.Size = new System.Drawing.Size(125, 20);
            this.lblCodFuncionario.TabIndex = 28;
            this.lblCodFuncionario.Text = "Cod Funcionário";
            // 
            // txtEmailFuncionario
            // 
            this.txtEmailFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailFuncionario.Location = new System.Drawing.Point(325, 266);
            this.txtEmailFuncionario.Name = "txtEmailFuncionario";
            this.txtEmailFuncionario.Size = new System.Drawing.Size(250, 26);
            this.txtEmailFuncionario.TabIndex = 6;
            // 
            // lblEmailFuncionario
            // 
            this.lblEmailFuncionario.AutoSize = true;
            this.lblEmailFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailFuncionario.Location = new System.Drawing.Point(194, 270);
            this.lblEmailFuncionario.Name = "lblEmailFuncionario";
            this.lblEmailFuncionario.Size = new System.Drawing.Size(48, 20);
            this.lblEmailFuncionario.TabIndex = 40;
            this.lblEmailFuncionario.Text = "Email";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(325, 238);
            this.mskTelefone.Mask = "(##) #####-####";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(130, 26);
            this.mskTelefone.TabIndex = 4;
            this.mskTelefone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mskTelefone_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(194, 299);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(52, 20);
            this.lblCargo.TabIndex = 42;
            this.lblCargo.Text = "Cargo";
            // 
            // cboclassefunc
            // 
            this.cboclassefunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboclassefunc.FormattingEnabled = true;
            this.cboclassefunc.Items.AddRange(new object[] {
            "Gerente",
            "Administrador",
            "Estoquista",
            "Caixa",
            "Atendente"});
            this.cboclassefunc.Location = new System.Drawing.Point(325, 296);
            this.cboclassefunc.MaxLength = 100;
            this.cboclassefunc.Name = "cboclassefunc";
            this.cboclassefunc.Size = new System.Drawing.Size(121, 28);
            this.cboclassefunc.TabIndex = 7;
            this.cboclassefunc.SelectedIndexChanged += new System.EventHandler(this.cboclassefunc_SelectedIndexChanged);
            this.cboclassefunc.SelectionChangeCommitted += new System.EventHandler(this.cboclassefunc_SelectionChangeCommitted);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(477, 238);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(45, 20);
            this.lblSexo.TabIndex = 49;
            this.lblSexo.Text = "Sexo";
            // 
            // txtsexo
            // 
            this.txtsexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsexo.FormattingEnabled = true;
            this.txtsexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.txtsexo.Location = new System.Drawing.Point(528, 236);
            this.txtsexo.MaxLength = 1;
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(47, 28);
            this.txtsexo.TabIndex = 5;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(194, 211);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(64, 20);
            this.lblusuario.TabIndex = 51;
            this.lblusuario.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(325, 208);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(390, 26);
            this.txtUsuario.TabIndex = 3;
            // 
            // frmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.cboclassefunc);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtEmailFuncionario);
            this.Controls.Add(this.lblEmailFuncionario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblTituloFuncionario);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.txtCodigoFuncionario);
            this.Controls.Add(this.lblCodFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroFuncionario";
            this.Text = "Novo Funcionário - FarmaTec";
            this.Load += new System.EventHandler(this.frmNovoAcesso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblTituloFuncionario;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.TextBox txtCodigoFuncionario;
        private System.Windows.Forms.Label lblCodFuncionario;
        private System.Windows.Forms.TextBox txtEmailFuncionario;
        private System.Windows.Forms.Label lblEmailFuncionario;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cboclassefunc;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox txtsexo;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}