namespace WindowsAutomationSpy.UserControls
{
    partial class SidePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SidePanel));
            this.spyMpSettings = new MetroFramework.Controls.MetroPanel();
            this.spySettingsTabControl = new MetroFramework.Controls.MetroTabControl();
            this.spyDBConnectionTab = new MetroFramework.Controls.MetroTabPage();
            this.spyMbTestDBConnection = new MetroFramework.Controls.MetroButton();
            this.spyMtbDBPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.spyMtbDBName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.spyMtbDBUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.spyMtbPortNo = new MetroFramework.Controls.MetroTextBox();
            this.spyMtbServerName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.spyThemeTab = new MetroFramework.Controls.MetroTabPage();
            this.spyFlpSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.spyMrbLight = new MetroFramework.Controls.MetroRadioButton();
            this.spyMrbDark = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.spyMlSettingsBack = new MetroFramework.Controls.MetroLink();
            this.spyMpSettings.SuspendLayout();
            this.spySettingsTabControl.SuspendLayout();
            this.spyDBConnectionTab.SuspendLayout();
            this.spyThemeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // spyMpSettings
            // 
            this.spyMpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spyMpSettings.Controls.Add(this.spySettingsTabControl);
            this.spyMpSettings.Controls.Add(this.panel1);
            this.spyMpSettings.Controls.Add(this.spyMlSettingsBack);
            this.spyMpSettings.HorizontalScrollbarBarColor = true;
            this.spyMpSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.spyMpSettings.HorizontalScrollbarSize = 10;
            this.spyMpSettings.Location = new System.Drawing.Point(285, 10);
            this.spyMpSettings.Name = "spyMpSettings";
            this.spyMpSettings.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.spyMpSettings.Size = new System.Drawing.Size(249, 423);
            this.spyMpSettings.TabIndex = 1;
            this.spyMpSettings.VerticalScrollbarBarColor = true;
            this.spyMpSettings.VerticalScrollbarHighlightOnWheel = false;
            this.spyMpSettings.VerticalScrollbarSize = 10;
            // 
            // spySettingsTabControl
            // 
            this.spySettingsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spySettingsTabControl.Controls.Add(this.spyDBConnectionTab);
            this.spySettingsTabControl.Controls.Add(this.spyThemeTab);
            this.spySettingsTabControl.ItemSize = new System.Drawing.Size(88, 34);
            this.spySettingsTabControl.Location = new System.Drawing.Point(4, 42);
            this.spySettingsTabControl.Name = "spySettingsTabControl";
            this.spySettingsTabControl.SelectedIndex = 1;
            this.spySettingsTabControl.Size = new System.Drawing.Size(245, 381);
            this.spySettingsTabControl.TabIndex = 4;
            this.spySettingsTabControl.UseSelectable = true;
            // 
            // spyDBConnectionTab
            // 
            this.spyDBConnectionTab.Controls.Add(this.spyMbTestDBConnection);
            this.spyDBConnectionTab.Controls.Add(this.spyMtbDBPassword);
            this.spyDBConnectionTab.Controls.Add(this.metroLabel8);
            this.spyDBConnectionTab.Controls.Add(this.spyMtbDBName);
            this.spyDBConnectionTab.Controls.Add(this.metroLabel7);
            this.spyDBConnectionTab.Controls.Add(this.spyMtbDBUsername);
            this.spyDBConnectionTab.Controls.Add(this.metroLabel6);
            this.spyDBConnectionTab.Controls.Add(this.spyMtbPortNo);
            this.spyDBConnectionTab.Controls.Add(this.spyMtbServerName);
            this.spyDBConnectionTab.Controls.Add(this.metroLabel5);
            this.spyDBConnectionTab.Controls.Add(this.metroLabel4);
            this.spyDBConnectionTab.HorizontalScrollbarBarColor = true;
            this.spyDBConnectionTab.HorizontalScrollbarHighlightOnWheel = false;
            this.spyDBConnectionTab.HorizontalScrollbarSize = 10;
            this.spyDBConnectionTab.Location = new System.Drawing.Point(4, 38);
            this.spyDBConnectionTab.Name = "spyDBConnectionTab";
            this.spyDBConnectionTab.Size = new System.Drawing.Size(237, 339);
            this.spyDBConnectionTab.TabIndex = 0;
            this.spyDBConnectionTab.Text = "&Connection";
            this.spyDBConnectionTab.VerticalScrollbarBarColor = true;
            this.spyDBConnectionTab.VerticalScrollbarHighlightOnWheel = false;
            this.spyDBConnectionTab.VerticalScrollbarSize = 10;
            // 
            // spyMbTestDBConnection
            // 
            this.spyMbTestDBConnection.Location = new System.Drawing.Point(26, 238);
            this.spyMbTestDBConnection.Name = "spyMbTestDBConnection";
            this.spyMbTestDBConnection.Size = new System.Drawing.Size(184, 23);
            this.spyMbTestDBConnection.TabIndex = 23;
            this.spyMbTestDBConnection.Text = "Test Database Connection";
            this.spyMbTestDBConnection.UseSelectable = true;
            // 
            // spyMtbDBPassword
            // 
            // 
            // 
            // 
            this.spyMtbDBPassword.CustomButton.Image = null;
            this.spyMtbDBPassword.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.spyMtbDBPassword.CustomButton.Name = "";
            this.spyMtbDBPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.spyMtbDBPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.spyMtbDBPassword.CustomButton.TabIndex = 1;
            this.spyMtbDBPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.spyMtbDBPassword.CustomButton.UseSelectable = true;
            this.spyMtbDBPassword.CustomButton.Visible = false;
            this.spyMtbDBPassword.Lines = new string[0];
            this.spyMtbDBPassword.Location = new System.Drawing.Point(26, 209);
            this.spyMtbDBPassword.MaxLength = 32767;
            this.spyMtbDBPassword.Name = "spyMtbDBPassword";
            this.spyMtbDBPassword.PasswordChar = '●';
            this.spyMtbDBPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.spyMtbDBPassword.SelectedText = "";
            this.spyMtbDBPassword.SelectionLength = 0;
            this.spyMtbDBPassword.SelectionStart = 0;
            this.spyMtbDBPassword.Size = new System.Drawing.Size(184, 23);
            this.spyMtbDBPassword.TabIndex = 22;
            this.spyMtbDBPassword.UseSelectable = true;
            this.spyMtbDBPassword.UseSystemPasswordChar = true;
            this.spyMtbDBPassword.WaterMark = "Database password";
            this.spyMtbDBPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.spyMtbDBPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.Location = new System.Drawing.Point(26, 191);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(62, 15);
            this.metroLabel8.TabIndex = 21;
            this.metroLabel8.Text = "password :";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spyMtbDBName
            // 
            // 
            // 
            // 
            this.spyMtbDBName.CustomButton.Image = null;
            this.spyMtbDBName.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.spyMtbDBName.CustomButton.Name = "";
            this.spyMtbDBName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.spyMtbDBName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.spyMtbDBName.CustomButton.TabIndex = 1;
            this.spyMtbDBName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.spyMtbDBName.CustomButton.UseSelectable = true;
            this.spyMtbDBName.CustomButton.Visible = false;
            this.spyMtbDBName.Lines = new string[0];
            this.spyMtbDBName.Location = new System.Drawing.Point(26, 121);
            this.spyMtbDBName.MaxLength = 32767;
            this.spyMtbDBName.Name = "spyMtbDBName";
            this.spyMtbDBName.PasswordChar = '\0';
            this.spyMtbDBName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.spyMtbDBName.SelectedText = "";
            this.spyMtbDBName.SelectionLength = 0;
            this.spyMtbDBName.SelectionStart = 0;
            this.spyMtbDBName.Size = new System.Drawing.Size(184, 23);
            this.spyMtbDBName.TabIndex = 20;
            this.spyMtbDBName.UseSelectable = true;
            this.spyMtbDBName.WaterMark = "Name of the database";
            this.spyMtbDBName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.spyMtbDBName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.Location = new System.Drawing.Point(26, 103);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(91, 15);
            this.metroLabel7.TabIndex = 19;
            this.metroLabel7.Text = "database name :";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spyMtbDBUsername
            // 
            // 
            // 
            // 
            this.spyMtbDBUsername.CustomButton.Image = null;
            this.spyMtbDBUsername.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.spyMtbDBUsername.CustomButton.Name = "";
            this.spyMtbDBUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.spyMtbDBUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.spyMtbDBUsername.CustomButton.TabIndex = 1;
            this.spyMtbDBUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.spyMtbDBUsername.CustomButton.UseSelectable = true;
            this.spyMtbDBUsername.CustomButton.Visible = false;
            this.spyMtbDBUsername.Lines = new string[0];
            this.spyMtbDBUsername.Location = new System.Drawing.Point(26, 165);
            this.spyMtbDBUsername.MaxLength = 32767;
            this.spyMtbDBUsername.Name = "spyMtbDBUsername";
            this.spyMtbDBUsername.PasswordChar = '\0';
            this.spyMtbDBUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.spyMtbDBUsername.SelectedText = "";
            this.spyMtbDBUsername.SelectionLength = 0;
            this.spyMtbDBUsername.SelectionStart = 0;
            this.spyMtbDBUsername.Size = new System.Drawing.Size(184, 23);
            this.spyMtbDBUsername.TabIndex = 18;
            this.spyMtbDBUsername.UseSelectable = true;
            this.spyMtbDBUsername.WaterMark = "Database username";
            this.spyMtbDBUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.spyMtbDBUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.Location = new System.Drawing.Point(26, 147);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 15);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "username :";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spyMtbPortNo
            // 
            // 
            // 
            // 
            this.spyMtbPortNo.CustomButton.Image = null;
            this.spyMtbPortNo.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.spyMtbPortNo.CustomButton.Name = "";
            this.spyMtbPortNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.spyMtbPortNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.spyMtbPortNo.CustomButton.TabIndex = 1;
            this.spyMtbPortNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.spyMtbPortNo.CustomButton.UseSelectable = true;
            this.spyMtbPortNo.CustomButton.Visible = false;
            this.spyMtbPortNo.Lines = new string[0];
            this.spyMtbPortNo.Location = new System.Drawing.Point(26, 77);
            this.spyMtbPortNo.MaxLength = 32767;
            this.spyMtbPortNo.Name = "spyMtbPortNo";
            this.spyMtbPortNo.PasswordChar = '\0';
            this.spyMtbPortNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.spyMtbPortNo.SelectedText = "";
            this.spyMtbPortNo.SelectionLength = 0;
            this.spyMtbPortNo.SelectionStart = 0;
            this.spyMtbPortNo.Size = new System.Drawing.Size(184, 23);
            this.spyMtbPortNo.TabIndex = 16;
            this.spyMtbPortNo.UseSelectable = true;
            this.spyMtbPortNo.WaterMark = "Database port number";
            this.spyMtbPortNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.spyMtbPortNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // spyMtbServerName
            // 
            // 
            // 
            // 
            this.spyMtbServerName.CustomButton.Image = null;
            this.spyMtbServerName.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.spyMtbServerName.CustomButton.Name = "";
            this.spyMtbServerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.spyMtbServerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.spyMtbServerName.CustomButton.TabIndex = 1;
            this.spyMtbServerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.spyMtbServerName.CustomButton.UseSelectable = true;
            this.spyMtbServerName.CustomButton.Visible = false;
            this.spyMtbServerName.Lines = new string[0];
            this.spyMtbServerName.Location = new System.Drawing.Point(26, 33);
            this.spyMtbServerName.MaxLength = 32767;
            this.spyMtbServerName.Name = "spyMtbServerName";
            this.spyMtbServerName.PasswordChar = '\0';
            this.spyMtbServerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.spyMtbServerName.SelectedText = "";
            this.spyMtbServerName.SelectionLength = 0;
            this.spyMtbServerName.SelectionStart = 0;
            this.spyMtbServerName.Size = new System.Drawing.Size(184, 23);
            this.spyMtbServerName.TabIndex = 15;
            this.spyMtbServerName.UseSelectable = true;
            this.spyMtbServerName.WaterMark = "Database server name";
            this.spyMtbServerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.spyMtbServerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.Location = new System.Drawing.Point(26, 59);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(78, 15);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "port number :";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.Location = new System.Drawing.Point(26, 15);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 15);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "server name :";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spyThemeTab
            // 
            this.spyThemeTab.Controls.Add(this.spyFlpSettings);
            this.spyThemeTab.Controls.Add(this.metroLabel2);
            this.spyThemeTab.Controls.Add(this.spyMrbLight);
            this.spyThemeTab.Controls.Add(this.spyMrbDark);
            this.spyThemeTab.Controls.Add(this.metroLabel1);
            this.spyThemeTab.HorizontalScrollbarBarColor = true;
            this.spyThemeTab.HorizontalScrollbarHighlightOnWheel = false;
            this.spyThemeTab.HorizontalScrollbarSize = 10;
            this.spyThemeTab.Location = new System.Drawing.Point(4, 38);
            this.spyThemeTab.Name = "spyThemeTab";
            this.spyThemeTab.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.spyThemeTab.Size = new System.Drawing.Size(237, 339);
            this.spyThemeTab.TabIndex = 1;
            this.spyThemeTab.Text = "&Themes";
            this.spyThemeTab.VerticalScrollbarBarColor = true;
            this.spyThemeTab.VerticalScrollbarHighlightOnWheel = false;
            this.spyThemeTab.VerticalScrollbarSize = 10;
            // 
            // spyFlpSettings
            // 
            this.spyFlpSettings.BackColor = System.Drawing.Color.Transparent;
            this.spyFlpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spyFlpSettings.Location = new System.Drawing.Point(0, 80);
            this.spyFlpSettings.Name = "spyFlpSettings";
            this.spyFlpSettings.Size = new System.Drawing.Size(237, 259);
            this.spyFlpSettings.TabIndex = 6;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 58);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Style";
            // 
            // spyMrbLight
            // 
            this.spyMrbLight.AutoSize = true;
            this.spyMrbLight.Checked = true;
            this.spyMrbLight.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.spyMrbLight.Location = new System.Drawing.Point(63, 29);
            this.spyMrbLight.Name = "spyMrbLight";
            this.spyMrbLight.Size = new System.Drawing.Size(56, 19);
            this.spyMrbLight.TabIndex = 4;
            this.spyMrbLight.TabStop = true;
            this.spyMrbLight.Text = "&Light";
            this.spyMrbLight.UseSelectable = true;
            // 
            // spyMrbDark
            // 
            this.spyMrbDark.AutoSize = true;
            this.spyMrbDark.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.spyMrbDark.Location = new System.Drawing.Point(3, 29);
            this.spyMrbDark.Name = "spyMrbDark";
            this.spyMrbDark.Size = new System.Drawing.Size(54, 19);
            this.spyMrbDark.TabIndex = 3;
            this.spyMrbDark.Text = "&Dark";
            this.spyMrbDark.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 2);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Theme";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 423);
            this.panel1.TabIndex = 3;
            // 
            // spyMlSettingsBack
            // 
            this.spyMlSettingsBack.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.spyMlSettingsBack.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.spyMlSettingsBack.Image = ((System.Drawing.Image)(resources.GetObject("spyMlSettingsBack.Image")));
            this.spyMlSettingsBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.spyMlSettingsBack.ImageSize = 32;
            this.spyMlSettingsBack.Location = new System.Drawing.Point(8, 0);
            this.spyMlSettingsBack.Name = "spyMlSettingsBack";
            this.spyMlSettingsBack.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("spyMlSettingsBack.NoFocusImage")));
            this.spyMlSettingsBack.Size = new System.Drawing.Size(138, 36);
            this.spyMlSettingsBack.TabIndex = 2;
            this.spyMlSettingsBack.Text = "&Settings";
            this.spyMlSettingsBack.UseSelectable = true;
            // 
            // SidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spyMpSettings);
            this.Name = "SidePanel";
            this.Size = new System.Drawing.Size(819, 443);
            this.spyMpSettings.ResumeLayout(false);
            this.spySettingsTabControl.ResumeLayout(false);
            this.spyDBConnectionTab.ResumeLayout(false);
            this.spyDBConnectionTab.PerformLayout();
            this.spyThemeTab.ResumeLayout(false);
            this.spyThemeTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel spyMpSettings;
        private MetroFramework.Controls.MetroTabControl spySettingsTabControl;
        private MetroFramework.Controls.MetroTabPage spyDBConnectionTab;
        private MetroFramework.Controls.MetroButton spyMbTestDBConnection;
        private MetroFramework.Controls.MetroTextBox spyMtbDBPassword;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox spyMtbDBName;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox spyMtbDBUsername;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox spyMtbPortNo;
        private MetroFramework.Controls.MetroTextBox spyMtbServerName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTabPage spyThemeTab;
        private System.Windows.Forms.FlowLayoutPanel spyFlpSettings;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroRadioButton spyMrbLight;
        private MetroFramework.Controls.MetroRadioButton spyMrbDark;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLink spyMlSettingsBack;
    }
}
