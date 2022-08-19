using WindowsAutomationSpy.UserControls;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace WindowsAutomationSpy.UI
{
    public partial class MainForm : MetroForm
    {
        /* Login panel */
        private readonly LoginPanel _login;

        /* Home panel */
        private HomePanel _home;

        public MainForm()
        {
            InitializeComponent();

            /* Setting MetroForm StyleManager to custom spyMsmMainForm style manager*/
            StyleManager = spyMsmMainForm;

            /* 
                Shown : Occurs whenever the form is first displayed 
                Assigning MainForm_Show to Shown EventHandler
            */
            Shown += MainForm_Shown;

            /*
                Creating LoginPanel object
                Assigning SettingsClosed and LoginSuccess event handlers to methods.
                Invoke Swipe method
            */
            _login = new LoginPanel(this);
            _login.SettingsClosed += LoginSettings_Closed;
            _login.LogInSuccess += Login_Success;
            _login.Swipe();

            /*
                Assigning Theme and Style to Settings Default values
            */
            //StyleManager.Theme = Settings.Default.Theme;
            //StyleManager.Style = Settings.Default.Style;
        }

        #region Event_Handler

        private void MainForm_Shown(object sender, EventArgs e)
        {
            /*
                Shown event handler implementation
            */
            WindowState = FormWindowState.Maximized;
        }

        private void LoginSettings_Closed(object sender, EventArgs e)
        {
            /*
                Displaying Settings and Power button after closing Settings panel
            */
            spyLnkSettings.Visible = true;
            spyLnkClose.Visible = true;
        }

        private void Login_Success(object sender, EventArgs e)
        {
            /*
                Executing after Login success
            */
            _login.Swipe(false);

            /* Displaying home panel */
            _home = new HomePanel(this);
            _home.ApplicationSelectorHandler += Application_Selector;
            _home.EditUiObjectHandler += Edit_UIObject;
            _home.DeleteUiObjectHandler += Delete_UIObject;         
            _home.Swipe();

        }

        private void Application_Selector(object sender, EventArgs e)
        {
            /*
                Application Selector event implementation
            */
        }

        private void Edit_UIObject(object sender, EventArgs e)
        {
            /*
                Edit ui object event implementation
            */
        }

        private void Delete_UIObject(object sender, EventArgs e)
        {
            /*
                Delete ui object event implementation
            */
        }

        #endregion

        #region Click_Events

        private void spyLnkSettings_Click(object sender, EventArgs e)
        {
            // Settings links click event
            spyLnkSettings.Visible = false;
            spyLnkClose.Visible = false;

            _login.ShowSettings();
        }

        private void spyLnkClose_Click(object sender, EventArgs e)
        {
            // Power button click event
            Application.Exit();
        }

        #endregion
    }
}
