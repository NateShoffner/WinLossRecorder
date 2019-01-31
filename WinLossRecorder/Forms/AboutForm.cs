using System.Diagnostics;
using System.Windows.Forms;
using ExtendedVersion;

namespace WinLossRecorder.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            lblProgram.Text += $" {AppUtils.GetVersion().ToString(ExtendedVersionFormatFlags.BuildString | ExtendedVersionFormatFlags.Truncated)}";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://nateshoffner.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://icons8.com/");
        }
    }
}