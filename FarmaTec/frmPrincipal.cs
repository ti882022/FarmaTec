﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTec
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuVendasCaixa_Click(object sender, EventArgs e)
        {
            FecharTodos();
            Form childForm = new frmCaixa();
            AbrirForm(childForm);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
        public void FecharTodos()
        {
            try
            {
                foreach (Form childForm in Application.OpenForms)
                {
                    if (childForm.Name != this.Name)
                    {
                        childForm.Close();
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        public void AbrirForm(Form childForm)
        {
            childForm.StartPosition = FormStartPosition.CenterScreen;
            int x = (this.Width - childForm.Width) / 2;
            int y = (this.Height - childForm.Height) / 2;
            childForm.Location = new Point(x, y);
            childForm.Show();
        }

        private void menuVendasRetirada_Click(object sender, EventArgs e)
        {
            FecharTodos();
            Form childForm = new frmRetirada();
            AbrirForm(childForm);
        }

        private void menuConsultaProdutos_Click(object sender, EventArgs e)
        {
            FecharTodos();
            Form childForm = new frmConsultarProdutos();
            AbrirForm(childForm);
        }

        private void menuConsultaClientes_Click(object sender, EventArgs e)
        {
            FecharTodos();
            Form childForm = new frmConsultarClientes();
            AbrirForm(childForm);
        }

        private void menuCadastroClientes_Click(object sender, EventArgs e)
        {
            FecharTodos();
            Form childForm = new frmCadastro();
            AbrirForm(childForm);
        }

        private void menuCadastroFuncionarios_Click(object sender, EventArgs e)
        {

        }

        private void menuNovoAcesso_Click(object sender, EventArgs e)
        {
            FecharTodos();
            Form childForm = new frmCadastroFuncionario();
            AbrirForm(childForm);
        }

        private void menuEditarCadastro_Click(object sender, EventArgs e)
        {
            FecharTodos();
            Form childForm = new frmEditarCadastro();
            AbrirForm(childForm);
        }

        private void menuAlterarSenha_Click(object sender, EventArgs e)
        {
           
        }

        private void menuCadastroFornecedores_Click(object sender, EventArgs e)
        {
            FecharTodos();
            Form childForm = new frmCadastroFornecedor();
            AbrirForm(childForm);
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }


        private void menuMovimentacaoEntrada_Click(object sender, EventArgs e)
        {
            FecharTodos();
            Form childForm = new frmEstoque();
            AbrirForm(childForm);
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuRelatorioFinanceiro_Click(object sender, EventArgs e)
        {
            FecharTodos();
            Form childForm = new frmRelatorioFinanceiro();
            AbrirForm(childForm);

        }

        

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharTodos();
            Form childForm = new frmCadastroProdutos();
            AbrirForm(childForm);
        }

    }
}