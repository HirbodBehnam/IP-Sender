using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_Sender
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 1 && args[0] == "-s")
            {
                ServiceBase.Run(new IPService());
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                if (Helper.ServiceExists("IP Sender Bot") && new ServiceController("IP Sender Bot").Status != ServiceControllerStatus.Stopped)
                    MessageBox.Show("Please stop the service before opening the application!","Service Running",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                    Application.Run(new Main());
            }
        }
    }
}
