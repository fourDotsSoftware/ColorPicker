using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ColorPicker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ExceptionHandlersHelper.AddUnhandledExceptionHandlers();

            frmLanguage.SetLanguages();
            frmLanguage.SetLanguage();

            if (args.Length > 0 && args[0].StartsWith("/uninstall"))
            {
                /*
                frmUninstallQuestionnaire fq = new frmUninstallQuestionnaire();
                fq.ShowDialog();
                */

                System.Diagnostics.Process.Start("https://www.4dots-software.com/support/bugfeature.php?uninstall=true&app=" + System.Web.HttpUtility.UrlEncode(Module.ShortApplicationTitle));

                Environment.Exit(0);

                return;
            }


            bool hide = false;

            if (args.Length > 0 && args[0].Trim() == "/hide")
            {
                hide = true;
            }

            Application.Run(new frmMain(hide));
        }
    }
}
