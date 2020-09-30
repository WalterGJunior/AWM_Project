using System;
using System.Collections.Generic; 
using System.Linq;
using System.Windows.Forms;


namespace WF_Principal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            //Application.Run(new FrmPrincipal());
            //Application.Run(new FrmAgenda());

            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();

            if (frmLogin.logado)
            {
                Application.Run(new FrmPrincipal());
            }
        }
    }
}
