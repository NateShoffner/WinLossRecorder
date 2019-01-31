using System;
using System.Windows.Forms;
using WinLossRecorder.Forms;

namespace WinLossRecorder
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppUtils.InitializeSettings();

            Application.Run(new MainForm());
        }
    }
}