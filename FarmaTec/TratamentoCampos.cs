using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTec
{
    public class TratamentoCampos
    {
        public void Limpar(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                    item.BackColor = System.Drawing.Color.White;
                }

                if (item is MaskedTextBox)
                {
                    item.Text = string.Empty;
                    item.BackColor = System.Drawing.Color.White;
                }
                if (item is ComboBox)
                {
                    item.Text = string.Empty;
                    item.BackColor = System.Drawing.Color.White;
                }
            }
        }

        public void Bloquear(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is TextBox && item.Name != "txtCodFuncionario")
                {
                    item.Enabled = false;
                }

                if (item is MaskedTextBox)
                {
                    item.Enabled = false;
                }
                if (item is ComboBox)
                {
                    item.Enabled = false;
                }
            }
        }

        public void Desbloquear(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is TextBox && item.TabIndex != 1)
                {
                    item.Enabled = true;
                }

                if (item is MaskedTextBox)
                {
                    item.Enabled = true;
                }

                if (item is ComboBox)
                {
                    item.Enabled = true;
                }
            }
        }

        public bool Vazio(Form form)
        {
            bool controlevazio = false;

            foreach (Control item in form.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == string.Empty && item.Enabled == true)
                    {
                        item.BackColor = System.Drawing.Color.Yellow;
                        controlevazio = true;
                    }
                    else
                    {
                        item.BackColor = System.Drawing.Color.White;
                    }
                }

                else if (item is MaskedTextBox)
                {
                    if (item.Text == string.Empty)
                    {
                        item.BackColor = System.Drawing.Color.Yellow;
                        controlevazio = true;
                    }
                    else
                    {
                        item.BackColor = System.Drawing.Color.White;
                    }
                }
            }

            if (controlevazio == true)
            {
                MessageBox.Show("Favor preencher os campos vazios. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}
