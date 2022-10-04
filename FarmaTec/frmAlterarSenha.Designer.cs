
namespace Projeto_Integrador_QT3___Sistema_Farmacêutico
{
    partial class frmAlterarSenha
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblAlterarSenha = new System.Windows.Forms.Label();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.mskConfirmarSenha = new System.Windows.Forms.MaskedTextBox();
            this.mskNovaSenha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(155, 194);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 28);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(19, 194);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 28);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblAlterarSenha
            // 
            this.lblAlterarSenha.AutoSize = true;
            this.lblAlterarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterarSenha.Location = new System.Drawing.Point(12, 9);
            this.lblAlterarSenha.Name = "lblAlterarSenha";
            this.lblAlterarSenha.Size = new System.Drawing.Size(226, 37);
            this.lblAlterarSenha.TabIndex = 68;
            this.lblAlterarSenha.Text = "Alterar Senha";
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaSenha.Location = new System.Drawing.Point(76, 56);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(96, 20);
            this.lblNovaSenha.TabIndex = 66;
            this.lblNovaSenha.Text = "Nova Senha";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.Location = new System.Drawing.Point(59, 116);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(129, 20);
            this.lblConfirmarSenha.TabIndex = 80;
            this.lblConfirmarSenha.Text = "Confirmar Senha";
            // 
            // mskConfirmarSenha
            // 
            this.mskConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskConfirmarSenha.Location = new System.Drawing.Point(19, 139);
            this.mskConfirmarSenha.Name = "mskConfirmarSenha";
            this.mskConfirmarSenha.PasswordChar = '*';
            this.mskConfirmarSenha.Size = new System.Drawing.Size(211, 26);
            this.mskConfirmarSenha.TabIndex = 1;
            // 
            // mskNovaSenha
            // 
            this.mskNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNovaSenha.Location = new System.Drawing.Point(19, 79);
            this.mskNovaSenha.Name = "mskNovaSenha";
            this.mskNovaSenha.PasswordChar = '*';
            this.mskNovaSenha.Size = new System.Drawing.Size(211, 26);
            this.mskNovaSenha.TabIndex = 0;
            // 
            // frmAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(250, 245);
            this.Controls.Add(this.mskNovaSenha);
            this.Controls.Add(this.mskConfirmarSenha);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblAlterarSenha);
            this.Controls.Add(this.lblNovaSenha);
            this.Name = "frmAlterarSenha";
            this.Text = "Alterar Senha - FarmaTec";
            this.Load += new System.EventHandler(this.frmAlterarSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblAlterarSenha;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.MaskedTextBox mskConfirmarSenha;
        private System.Windows.Forms.MaskedTextBox mskNovaSenha;
    }
}