using System;
using System.Windows.Forms;

namespace FarmaTec
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          //  Application.Run(new frmPrincipal());

              frmLogin frm = new frmLogin();
             frm.ShowDialog();
             if (frm.LoginSucesso)
             {
                 Application.Run(new frmPrincipal());
             }
           
            
        }
    }
}
