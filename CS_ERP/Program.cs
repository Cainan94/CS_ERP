using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CS_ERP
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        /// 
        static Thread TLogin;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StartLogin();
        }

        static void StartLogin()
        {
            TLogin = new Thread(new ThreadStart(Login));
            TLogin.Start();
        }

        static void Login()
        {
            Application.Run(new VIEWS.Frm_Login());
        }

        static void ClosseFoem(Form form)
        {
            if (form.Text.Contains("Login"))
            {
                TLogin.Abort();
            }
        }
    }
}
