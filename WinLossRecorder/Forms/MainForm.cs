using System;
using System.IO;
using System.Windows.Forms;
using ExtendedVersion;
using WinLossRecorder.Properties;

namespace WinLossRecorder.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Text += $" {AppUtils.GetVersion().ToString(ExtendedVersionFormatFlags.BuildString | ExtendedVersionFormatFlags.Truncated)}";

            rcWins.Updated += OnRecordUpdated;
            rcLosses.Updated += OnRecordUpdated;
            rcDraws.Updated += OnRecordUpdated;

            if (string.IsNullOrEmpty(Settings.Default.OutputPath))
            {
                ShowTemplateEditor(true);
            }
        }

        private void OnRecordUpdated(object sender, EventArgs e)
        {
            SaveRecords();
        }

        private void SaveRecords()
        {
            try
            {
                File.WriteAllText(Settings.Default.OutputPath, Settings.Default.OutputTemplate.Replace("{wins}",
                    rcWins.Value.ToString()).Replace("{losses}", rcLosses.Value.ToString()).Replace("{draws}", rcDraws.Value.ToString()));
            }

            catch
            {
                MessageBox.Show("An error occured while trying to save the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            ShowTemplateEditor(false);
        }

        private void ShowTemplateEditor(bool startup)
        {
            using (var frm = new EditForm(startup)
            {
                StartPosition = startup
                    ? FormStartPosition.CenterScreen
                    : FormStartPosition.CenterParent
            })
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    SaveRecords();
                }

                else
                {
                    if (startup)
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (var frm = new AboutForm())
            {
                frm.ShowDialog();
            }
        }
    }
}