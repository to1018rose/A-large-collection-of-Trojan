namespace WindowsAutomationSpy.UserControls
{
    partial class HomePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePanel));
            this.spyMpHomeCenter = new MetroFramework.Controls.MetroPanel();
            this.spyMtCaptureObj = new MetroFramework.Controls.MetroTile();
            this.spyMtDeleteObj = new MetroFramework.Controls.MetroTile();
            this.spyMtEditObj = new MetroFramework.Controls.MetroTile();
            this.spyMtAppSelector = new MetroFramework.Controls.MetroTile();
            this.spyMpHomeCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // spyMpHomeCenter
            // 
            this.spyMpHomeCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.spyMpHomeCenter.Controls.Add(this.spyMtCaptureObj);
            this.spyMpHomeCenter.Controls.Add(this.spyMtDeleteObj);
            this.spyMpHomeCenter.Controls.Add(this.spyMtEditObj);
            this.spyMpHomeCenter.Controls.Add(this.spyMtAppSelector);
            this.spyMpHomeCenter.HorizontalScrollbarBarColor = true;
            this.spyMpHomeCenter.HorizontalScrollbarHighlightOnWheel = false;
            this.spyMpHomeCenter.HorizontalScrollbarSize = 10;
            this.spyMpHomeCenter.Location = new System.Drawing.Point(0, 94);
            this.spyMpHomeCenter.Name = "spyMpHomeCenter";
            this.spyMpHomeCenter.Size = new System.Drawing.Size(895, 296);
            this.spyMpHomeCenter.TabIndex = 0;
            this.spyMpHomeCenter.VerticalScrollbarBarColor = true;
            this.spyMpHomeCenter.VerticalScrollbarHighlightOnWheel = false;
            this.spyMpHomeCenter.VerticalScrollbarSize = 10;
            // 
            // spyMtCaptureObj
            // 
            this.spyMtCaptureObj.ActiveControl = null;
            this.spyMtCaptureObj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spyMtCaptureObj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spyMtCaptureObj.Location = new System.Drawing.Point(207, 197);
            this.spyMtCaptureObj.Name = "spyMtCaptureObj";
            this.spyMtCaptureObj.Size = new System.Drawing.Size(316, 62);
            this.spyMtCaptureObj.Style = MetroFramework.MetroColorStyle.Green;
            this.spyMtCaptureObj.TabIndex = 5;
            this.spyMtCaptureObj.Tag = "5";
            this.spyMtCaptureObj.Text = "&Capture UI Object";
            this.spyMtCaptureObj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.spyMtCaptureObj.TileImage = ((System.Drawing.Image)(resources.GetObject("spyMtCaptureObj.TileImage")));
            this.spyMtCaptureObj.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.spyMtCaptureObj.UseSelectable = true;
            this.spyMtCaptureObj.UseTileImage = true;
            // 
            // spyMtDeleteObj
            // 
            this.spyMtDeleteObj.ActiveControl = null;
            this.spyMtDeleteObj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spyMtDeleteObj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spyMtDeleteObj.Location = new System.Drawing.Point(529, 143);
            this.spyMtDeleteObj.Name = "spyMtDeleteObj";
            this.spyMtDeleteObj.Size = new System.Drawing.Size(158, 116);
            this.spyMtDeleteObj.Style = MetroFramework.MetroColorStyle.Brown;
            this.spyMtDeleteObj.TabIndex = 4;
            this.spyMtDeleteObj.Tag = "3";
            this.spyMtDeleteObj.Text = "&Delete UI Object";
            this.spyMtDeleteObj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.spyMtDeleteObj.TileImage = ((System.Drawing.Image)(resources.GetObject("spyMtDeleteObj.TileImage")));
            this.spyMtDeleteObj.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.spyMtDeleteObj.UseSelectable = true;
            this.spyMtDeleteObj.UseTileImage = true;
            this.spyMtDeleteObj.Click += new System.EventHandler(this.spyMtDeleteObj_Click);
            // 
            // spyMtEditObj
            // 
            this.spyMtEditObj.ActiveControl = null;
            this.spyMtEditObj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spyMtEditObj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spyMtEditObj.Location = new System.Drawing.Point(529, 37);
            this.spyMtEditObj.Name = "spyMtEditObj";
            this.spyMtEditObj.Size = new System.Drawing.Size(158, 100);
            this.spyMtEditObj.Style = MetroFramework.MetroColorStyle.Purple;
            this.spyMtEditObj.TabIndex = 3;
            this.spyMtEditObj.Tag = "8";
            this.spyMtEditObj.Text = "&Edit UI Object";
            this.spyMtEditObj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.spyMtEditObj.TileImage = ((System.Drawing.Image)(resources.GetObject("spyMtEditObj.TileImage")));
            this.spyMtEditObj.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.spyMtEditObj.UseSelectable = true;
            this.spyMtEditObj.UseTileImage = true;
            this.spyMtEditObj.Click += new System.EventHandler(this.spyMtEditObj_Click);
            // 
            // spyMtAppSelector
            // 
            this.spyMtAppSelector.ActiveControl = null;
            this.spyMtAppSelector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spyMtAppSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spyMtAppSelector.Location = new System.Drawing.Point(207, 37);
            this.spyMtAppSelector.Name = "spyMtAppSelector";
            this.spyMtAppSelector.Size = new System.Drawing.Size(316, 154);
            this.spyMtAppSelector.Style = MetroFramework.MetroColorStyle.Teal;
            this.spyMtAppSelector.TabIndex = 2;
            this.spyMtAppSelector.Tag = "10";
            this.spyMtAppSelector.Text = "&Select Application";
            this.spyMtAppSelector.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.spyMtAppSelector.TileImage = ((System.Drawing.Image)(resources.GetObject("spyMtAppSelector.TileImage")));
            this.spyMtAppSelector.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.spyMtAppSelector.UseSelectable = true;
            this.spyMtAppSelector.UseTileImage = true;
            this.spyMtAppSelector.Click += new System.EventHandler(this.spyMtAppSelector_Click);
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spyMpHomeCenter);
            this.Name = "HomePanel";
            this.Size = new System.Drawing.Size(895, 485);
            this.spyMpHomeCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel spyMpHomeCenter;
        private MetroFramework.Controls.MetroTile spyMtEditObj;
        private MetroFramework.Controls.MetroTile spyMtAppSelector;
        private MetroFramework.Controls.MetroTile spyMtCaptureObj;
        private MetroFramework.Controls.MetroTile spyMtDeleteObj;
    }
}
