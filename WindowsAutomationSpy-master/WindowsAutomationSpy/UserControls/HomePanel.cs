
using System;
using System.Windows.Forms;

namespace WindowsAutomationSpy.UserControls
{
    public partial class HomePanel : SliderPanel
    {
        //Owner form inastance
        private readonly Form _owner;

        //Event handler after Edit UI Object
        public event EventHandler ApplicationSelectorHandler;

        //Event handler after Edit UI Object
        public event EventHandler DeleteUiObjectHandler;

        //Event handler after Edit UI Object
        public event EventHandler EditUiObjectHandler;

        public HomePanel(Form owner) : base(owner)
        {
            InitializeComponent();

            _owner = owner;

            ShowHandler += HomePanel_Shown;
        }

        #region Event_Handler

        private void HomePanel_Shown(object sender, EventArgs e)
        {
//            spyMtAppSelector.Focus();
        }

        #endregion

        #region Click_Events

        private void spyMtAppSelector_Click(object sender, EventArgs e)
        {
            EventHandler handler = ApplicationSelectorHandler;
            handler?.Invoke(this, e);
        }

        private void spyMtEditObj_Click(object sender, EventArgs e)
        {
            EventHandler handler = EditUiObjectHandler;
            handler?.Invoke(this, e);
        }

        private void spyMtDeleteObj_Click(object sender, EventArgs e)
        {
            EventHandler handler = DeleteUiObjectHandler;
            handler?.Invoke(this, e);
        }

        #endregion

    }
}
