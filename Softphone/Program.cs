using System;
using System.Windows.Forms;
using System.IO;
using Ozeki.Media;
using Ozeki.VoIP;
namespace Softphone
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSoftphone());
            Application.ExitThread();
            Application.Exit();
        }
    }
}
