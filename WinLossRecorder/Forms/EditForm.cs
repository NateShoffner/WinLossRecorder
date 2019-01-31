using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WinLossRecorder.Properties;

namespace WinLossRecorder.Forms
{
    public partial class EditForm : Form
    {
        public EditForm(bool requireSetup)
        {
            InitializeComponent();

            txtTemplate.Text = Settings.Default.OutputTemplate;

            if (requireSetup)
            {
                btnOk.Enabled = false;
            }

            if (!string.IsNullOrEmpty(Settings.Default.OutputPath))
            {
                lblOutputPath.Text = EllipsizePath(Settings.Default.OutputPath);
            }

            UpdatePreview();
        }

        private void UpdatePreview()
        {
            lblPreview.Text = txtTemplate.Text.Replace("{wins}", "4").Replace("{losses}", "2").Replace("{draws}", "1");
        }

        private void txtTemplate_TextChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog
            {
                Filter = "Text File (*.txt)|*.txt|Show All Files (*.*)|*.*",
                Title = "Select output file"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Settings.Default.OutputPath = sfd.FileName;
                    Settings.Default.Save();

                    lblOutputPath.Text = EllipsizePath(sfd.FileName);
                    btnOk.Enabled = true;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Settings.Default.OutputTemplate = txtTemplate.Text;
            Settings.Default.Save();
        }

        public static string EllipsizePath(string rawString, int maxLength = 30, char delimiter = '\\')
        {
            maxLength -= 3; //account for delimiter spacing

            if (rawString.Length <= maxLength)
            {
                return rawString;
            }

            var final = rawString;
            List<string> parts;

            var loops = 0;
            while (loops++ < 100)
            {
                parts = rawString.Split(delimiter).ToList();
                parts.RemoveRange(parts.Count - 1 - loops, loops);
                if (parts.Count == 1)
                {
                    return parts.Last();
                }

                parts.Insert(parts.Count - 1, "...");
                final = string.Join(delimiter.ToString(), parts);
                if (final.Length < maxLength)
                {
                    return final;
                }
            }

            return rawString.Split(delimiter).ToList().Last();
        }
    }
}