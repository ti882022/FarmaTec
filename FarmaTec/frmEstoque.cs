using System;
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
    public partial class cboEstoque : Form
    {
        public cboEstoque()
        {
            InitializeComponent();
        }

        private void saida_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Pesquisa_Click(object sender, EventArgs e)
        {

        }
           

        

       

       

        private void cbocomprar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbocomprar.Text=="saida"){ cbomotivo.Visible = true;          }
            else { cbomotivo.Visible = false; }
        }

        private void codigoproduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Atualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
