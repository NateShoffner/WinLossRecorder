using WinLossRecorder.Controls;

namespace WinLossRecorder.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnOptions = new System.Windows.Forms.Button();
            this.rcDraws = new RecordControl();
            this.rcLosses = new RecordControl();
            this.rcWins = new RecordControl();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.Location = new System.Drawing.Point(300, 77);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 3;
            this.btnOptions.Text = "Options...";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // rcDraws
            // 
            this.rcDraws.AutoSize = true;
            this.rcDraws.Location = new System.Drawing.Point(12, 95);
            this.rcDraws.Name = "rcDraws";
            this.rcDraws.Size = new System.Drawing.Size(194, 35);
            this.rcDraws.TabIndex = 8;
            this.rcDraws.Text = "Draws";
            this.rcDraws.Value = 0;
            // 
            // rcLosses
            // 
            this.rcLosses.AutoSize = true;
            this.rcLosses.Location = new System.Drawing.Point(12, 54);
            this.rcLosses.Name = "rcLosses";
            this.rcLosses.Size = new System.Drawing.Size(194, 35);
            this.rcLosses.TabIndex = 7;
            this.rcLosses.Text = "Losses";
            this.rcLosses.Value = 0;
            // 
            // rcWins
            // 
            this.rcWins.AutoSize = true;
            this.rcWins.Location = new System.Drawing.Point(12, 12);
            this.rcWins.Name = "rcWins";
            this.rcWins.Size = new System.Drawing.Size(194, 36);
            this.rcWins.TabIndex = 6;
            this.rcWins.Text = "Wins";
            this.rcWins.Value = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(300, 106);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "About...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 138);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.rcDraws);
            this.Controls.Add(this.rcLosses);
            this.Controls.Add(this.rcWins);
            this.Controls.Add(this.btnOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Win/Loss Record Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOptions;
        private RecordControl rcWins;
        private RecordControl rcLosses;
        private RecordControl rcDraws;
        private System.Windows.Forms.Button btnAbout;
    }
}

