namespace WindowsAutomationSpy.UI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.spyLnkClose = new MetroFramework.Controls.MetroLink();
            this.spyLnkSettings = new MetroFramework.Controls.MetroLink();
            this.spyMsmMainForm = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spyMsmMainForm)).BeginInit();
            this.SuspendLayout();
            // 
            // spyLnkClose
            // 
            this.spyLnkClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spyLnkClose.Image = ((System.Drawing.Image)(resources.GetObject("spyLnkClose.Image")));
            this.spyLnkClose.ImageSize = 32;
            this.spyLnkClose.Location = new System.Drawing.Point(807, 8);
            this.spyLnkClose.Name = "spyLnkClose";
            this.spyLnkClose.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("spyLnkClose.NoFocusImage")));
            this.spyLnkClose.Size = new System.Drawing.Size(42, 39);
            this.spyLnkClose.TabIndex = 0;
            this.spyLnkClose.UseSelectable = true;
            this.spyLnkClose.Click += new System.EventHandler(this.spyLnkClose_Click);
            // 
            // spyLnkSettings
            // 
            this.spyLnkSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spyLnkSettings.Image = ((System.Drawing.Image)(resources.GetObject("spyLnkSettings.Image")));
            this.spyLnkSettings.ImageSize = 32;
            this.spyLnkSettings.Location = new System.Drawing.Point(759, 8);
            this.spyLnkSettings.Name = "spyLnkSettings";
            this.spyLnkSettings.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("spyLnkSettings.NoFocusImage")));
            this.spyLnkSettings.Size = new System.Drawing.Size(42, 39);
            this.spyLnkSettings.TabIndex = 1;
            this.spyLnkSettings.UseSelectable = true;
            this.spyLnkSettings.Click += new System.EventHandler(this.spyLnkSettings_Click);
            // 
            // spyMsmMainForm
            // 
            this.spyMsmMainForm.Owner = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 378);
            this.ControlBox = false;
            this.Controls.Add(this.spyLnkSettings);
            this.Controls.Add(this.spyLnkClose);
            this.Name = "MainForm";
            this.Text = "Windows Automation Spy";
            ((System.ComponentModel.ISupportInitialize)(this.spyMsmMainForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink spyLnkClose;
        private MetroFramework.Controls.MetroLink spyLnkSettings;
        private MetroFramework.Components.MetroStyleManager spyMsmMainForm;
    }
}