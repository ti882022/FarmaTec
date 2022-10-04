using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TransferenciaDados;

namespace FarmaTec
{
    public partial class frmNovoAcesso : Form
    {
        public frmNovoAcesso()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigoFuncionario.Clear();
            mskTelefone.Clear();
            txtNomeFuncionario.Clear();
            txtEmailFuncionario.Clear();
        }

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            MySqlConnection conn = new MySqlConnection("datasource=localhost; database=bdfarmacia;port=3306; username = root; password=");
            string query = "SELECT descricao FROM tbclasseusuario";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            conn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "tbclasseusuario");
            cmbCargo.DisplayMember = "descricao";
            conn.Close();


        }

        private void frmNovoAcesso_Load(object sender, EventArgs e)
        {

        }

        private void mskTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
