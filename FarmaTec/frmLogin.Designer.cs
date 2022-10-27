
namespace FarmaTec
{
    partial class frmLogin
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.mskSenha = new System.Windows.Forms.MaskedTextBox();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mskNovaSenha = new System.Windows.Forms.MaskedTextBox();
            this.mskConfirmarSenha = new System.Windows.Forms.MaskedTextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.mskSenhaAtual = new System.Windows.Forms.MaskedTextBox();
            this.lblSenhaAtual = new System.Windows.Forms.Label();
            this.lblPrimeiroAcesso = new System.Windows.Forms.Label();
            this.pnlMudarSenha = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.pnlMudarSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(62, 283);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(102, 29);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(62, 334);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(88, 29);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(178, 283);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(260, 31);
            this.txtusuario.TabIndex = 0;
            // 
            // mskSenha
            // 
            this.mskSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSenha.Location = new System.Drawing.Point(178, 334);
            this.mskSenha.Name = "mskSenha";
            this.mskSenha.PasswordChar = '*';
            this.mskSenha.Size = new System.Drawing.Size(260, 31);
            this.mskSenha.TabIndex = 1;
            // 
            // btnAcessar
            // 
            this.btnAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.Location = new System.Drawing.Point(246, 377);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(113, 36);
            this.btnAcessar.TabIndex = 2;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::FarmaTec.Properties.Resources.FarmaTec_removebg_preview2;
            this.imgLogo.Location = new System.Drawing.Point(178, 18);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(260, 259);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // mskNovaSenha
            // 
            this.mskNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNovaSenha.Location = new System.Drawing.Point(121, 177);
            this.mskNovaSenha.Name = "mskNovaSenha";
            this.mskNovaSenha.PasswordChar = '*';
            this.mskNovaSenha.Size = new System.Drawing.Size(211, 26);
            this.mskNovaSenha.TabIndex = 4;
            // 
            // mskConfirmarSenha
            // 
            this.mskConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskConfirmarSenha.Location = new System.Drawing.Point(121, 237);
            this.mskConfirmarSenha.Name = "mskConfirmarSenha";
            this.mskConfirmarSenha.PasswordChar = '*';
            this.mskConfirmarSenha.Size = new System.Drawing.Size(211, 26);
            this.mskConfirmarSenha.TabIndex = 5;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.Location = new System.Drawing.Point(161, 214);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(129, 20);
            this.lblConfirmarSenha.TabIndex = 86;
            this.lblConfirmarSenha.Text = "Confirmar Senha";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(257, 292);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 28);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(121, 292);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 28);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaSenha.Location = new System.Drawing.Point(178, 154);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(96, 20);
            this.lblNovaSenha.TabIndex = 85;
            this.lblNovaSenha.Text = "Nova Senha";
            // 
            // mskSenhaAtual
            // 
            this.mskSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSenhaAtual.Location = new System.Drawing.Point(121, 111);
            this.mskSenhaAtual.Name = "mskSenhaAtual";
            this.mskSenhaAtual.PasswordChar = '*';
            this.mskSenhaAtual.Size = new System.Drawing.Size(211, 26);
            this.mskSenhaAtual.TabIndex = 3;
            // 
            // lblSenhaAtual
            // 
            this.lblSenhaAtual.AutoSize = true;
            this.lblSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAtual.Location = new System.Drawing.Point(178, 88);
            this.lblSenhaAtual.Name = "lblSenhaAtual";
            this.lblSenhaAtual.Size = new System.Drawing.Size(97, 20);
            this.lblSenhaAtual.TabIndex = 88;
            this.lblSenhaAtual.Text = "Senha Atual";
            // 
            // lblPrimeiroAcesso
            // 
            this.lblPrimeiroAcesso.AutoSize = true;
            this.lblPrimeiroAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiroAcesso.Location = new System.Drawing.Point(130, 39);
            this.lblPrimeiroAcesso.Name = "lblPrimeiroAcesso";
            this.lblPrimeiroAcesso.Size = new System.Drawing.Size(191, 29);
            this.lblPrimeiroAcesso.TabIndex = 89;
            this.lblPrimeiroAcesso.Text = "Altere sua senha";
            // 
            // pnlMudarSenha
            // 
            this.pnlMudarSenha.Controls.Add(this.lblPrimeiroAcesso);
            this.pnlMudarSenha.Controls.Add(this.lblNovaSenha);
            this.pnlMudarSenha.Controls.Add(this.mskSenhaAtual);
            this.pnlMudarSenha.Controls.Add(this.btnSalvar);
            this.pnlMudarSenha.Controls.Add(this.lblSenhaAtual);
            this.pnlMudarSenha.Controls.Add(this.btnLimpar);
            this.pnlMudarSenha.Controls.Add(this.mskNovaSenha);
            this.pnlMudarSenha.Controls.Add(this.lblConfirmarSenha);
            this.pnlMudarSenha.Controls.Add(this.mskConfirmarSenha);
            this.pnlMudarSenha.Location = new System.Drawing.Point(592, 12);
            this.pnlMudarSenha.Name = "pnlMudarSenha";
            this.pnlMudarSenha.Size = new System.Drawing.Size(435, 395);
            this.pnlMudarSenha.TabIndex = 90;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1112, 432);
            this.Controls.Add(this.pnlMudarSenha);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.mskSenha);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.imgLogo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FarmaTec - Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.pnlMudarSenha.ResumeLayout(false);
            this.pnlMudarSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.MaskedTextBox mskSenha;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.MaskedTextBox mskNovaSenha;
        private System.Windows.Forms.MaskedTextBox mskConfirmarSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.MaskedTextBox mskSenhaAtual;
        private System.Windows.Forms.Label lblSenhaAtual;
        private System.Windows.Forms.Label lblPrimeiroAcesso;
        private System.Windows.Forms.Panel pnlMudarSenha;
    }
}