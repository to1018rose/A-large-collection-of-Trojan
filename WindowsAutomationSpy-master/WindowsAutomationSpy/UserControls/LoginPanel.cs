using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsAutomationSpy.Properties;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace WindowsAutomationSpy.UserControls
{
    public partial class LoginPanel : SliderPanel
    {
        //Event handler for Settings panel close
        public event EventHandler SettingsClosed;

        //Event handler after Login success
        public event EventHandler LogInSuccess;

        //Owner form inastance
        private readonly Form _owner;

        public LoginPanel(Form owner) : base(owner) 
        {
            InitializeComponent();

            _owner = owner;

            /*
                Adding color tiles to flow layout panel
            */
            for (int i = 3; i < 13; i++)
            {
                MetroTile tile = new MetroTile();
                tile.Size = new Size(30, 30);
                tile.Tag = i;
                tile.Style = (MetroColorStyle) i;
                tile.Click += tile_Click;
                spyFlpSettings.Controls.Add(tile);
            }

            /*
                Assigning default values from Settings file
            */
            spyMtbServerName.Text = Settings.Default.Server;
            spyMtbPortNo.Text = Settings.Default.Port;
            spyMtbDBName.Text = Settings.Default.Database;
            spyMtbDBUsername.Text = Settings.Default.Username;
            spyMtbDBPassword.Text = Settings.Default.Password;
            ((MetroForm) Parent).StyleManager.Theme = Settings.Default.Theme;
            ((MetroForm) Parent).StyleManager.Style = Settings.Default.Style;

            /*
                Change radio button selection according to the theme
            */
            if (Settings.Default.Theme == MetroThemeStyle.Dark)
            {
                spyMrbDark.Checked = true;
            }
            else
            {
                spyMrbLight.Checked = true;
            }

            /*
                Assigning LoginPanel_Shown to ShowHandler EventHandler
            */
            ShowHandler += LoginPanel_Shown;
        }

        #region Event_Handler

        private void LoginPanel_Shown(object sender, EventArgs e)
        {
            // ShowHandler event implementation
            spyMtbUsername.Focus();
        }

        #endregion

        #region Click_Events

        private void tile_Click(object sender, EventArgs e)
        {
            //Tile click event
            ((MetroForm)Parent).StyleManager.Style = (MetroColorStyle)((MetroTile)sender).Tag;
            SaveSettings();
        }

        private void spyMlSettingsBack_Click(object sender, EventArgs e)
        {
            spyMpSettings.Visible = false;
            spyMpCenter.Enabled = true;

            EventHandler handler = SettingsClosed;
            handler?.Invoke(this, e);
        }

        private void spyMbTestDBConnection_Click(object sender, EventArgs e)
        {
            SaveSettings();
            TestConnection();
        }

        private void spyMbLogin_Click(object sender, EventArgs e)
        {
            if (!TestConnection(true)) return;

            //            string _sql = "select * from tbl_User where username = '" + spyMtbUsername.Text + "' limit 1";
            //            DataTable _table = Functions.DataTable(_sql);
            //            if (_table.Rows.Count > 0)
            //            {
            //                if (_table.Rows[0].Field<string>("Password") != spyMtbPassword.Text)
            //                {
            //                    spyMtbPassword.Clear();
            //                    spyMtbPassword.Focus();
            //                    MetroMessageBox.Show(_owner, "Invalid password!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                    return;
            //                }
            //            }
            //            else
            //            {
            //                spyMtbUsername.Clear();
            //                spyMtbPassword.Clear();
            //                spyMtbUsername.Focus();
            //                MetroMessageBox.Show(_owner, "Username not found!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                return;
            //            }

            EventHandler handler = LogInSuccess;
            handler?.Invoke(this, e);
        }

        #endregion

        #region Checked_Change_Events

        private void spyMrbDark_CheckedChanged(object sender, EventArgs e)
        {
            if (spyMrbDark.Checked)
            {
                ((MetroForm)Parent).StyleManager.Theme = MetroThemeStyle.Dark;
            }
            SaveSettings();
        }

        private void spyMrbLight_CheckedChanged(object sender, EventArgs e)
        {
            if (spyMrbLight.Checked)
            {
                ((MetroForm)Parent).StyleManager.Theme = MetroThemeStyle.Light;
            }
            SaveSettings();
        }

        #endregion

        #region Methods

        public void ShowSettings()
        {
            spyMpSettings.Visible = true;
            spyMpCenter.Enabled = false;
        }

        private void SaveSettings()
        {
            Settings.Default.Server = spyMtbServerName.Text;
            Settings.Default.Port = spyMtbPortNo.Text;
            Settings.Default.Database = spyMtbDBName.Text;
            Settings.Default.Username = spyMtbDBUsername.Text;
            Settings.Default.Password = spyMtbDBPassword.Text;
            Settings.Default.Theme = ((MetroForm)Parent).StyleManager.Theme;
            Settings.Default.Style = ((MetroForm)Parent).StyleManager.Style;
            Settings.Default.Save();
        }

        private bool TestConnection(bool nomessage = false)
        {
            //            bool connection = true;
            string message = "Successfully established a connection!";
            MessageBoxIcon icon = MessageBoxIcon.Information;

            //Test connection function..
            //If connection fails 
            //set message "Failed to establish a connection using the specified connection values!"
            //set icon MessageBoxIcon.Error
            //set connection to false

            if (!nomessage) MetroMessageBox.Show(_owner, message, Application.ProductName, MessageBoxButtons.OK, icon);

            return true;
        }

        #endregion

    }
}
