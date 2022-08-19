namespace WindowsAutomationSpy.UI
{
    partial class Main
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.aboutTab = new MetroFramework.Controls.MetroTabPage();
            this.settingsTab = new MetroFramework.Controls.MetroTabPage();
            this.homeTab = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTabControl1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1244, 527);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // aboutTab
            // 
            this.aboutTab.HorizontalScrollbarBarColor = true;
            this.aboutTab.HorizontalScrollbarHighlightOnWheel = false;
            this.aboutTab.HorizontalScrollbarSize = 10;
            this.aboutTab.Location = new System.Drawing.Point(4, 38);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Size = new System.Drawing.Size(1236, 485);
            this.aboutTab.TabIndex = 1;
            this.aboutTab.Text = "ABOUT US";
            this.aboutTab.VerticalScrollbarBarColor = true;
            this.aboutTab.VerticalScrollbarHighlightOnWheel = false;
            this.aboutTab.VerticalScrollbarSize = 10;
            // 
            // settingsTab
            // 
            this.settingsTab.HorizontalScrollbarBarColor = true;
            this.settingsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.settingsTab.HorizontalScrollbarSize = 10;
            this.settingsTab.Location = new System.Drawing.Point(4, 38);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(1236, 485);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "SETTINGS";
            this.settingsTab.VerticalScrollbarBarColor = true;
            this.settingsTab.VerticalScrollbarHighlightOnWheel = false;
            this.settingsTab.VerticalScrollbarSize = 10;
            // 
            // homeTab
            // 
            this.homeTab.HorizontalScrollbarBarColor = true;
            this.homeTab.HorizontalScrollbarHighlightOnWheel = false;
            this.homeTab.HorizontalScrollbarSize = 10;
            this.homeTab.Location = new System.Drawing.Point(4, 38);
            this.homeTab.Name = "homeTab";
            this.homeTab.Size = new System.Drawing.Size(1236, 485);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "HOME";
            this.homeTab.VerticalScrollbarBarColor = true;
            this.homeTab.VerticalScrollbarHighlightOnWheel = false;
            this.homeTab.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.homeTab);
            this.metroTabControl1.Controls.Add(this.settingsTab);
            this.metroTabControl1.Controls.Add(this.aboutTab);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(1244, 527);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 607);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "Windows Automation Spy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.metroPanel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage homeTab;
        private MetroFramework.Controls.MetroTabPage settingsTab;
        private MetroFramework.Controls.MetroTabPage aboutTab;
    }
}

