using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;
using Transitions;

namespace WindowsAutomationSpy.UserControls
{
    public partial class SliderPanel : MetroUserControl
    {
        private readonly Form _owner;
        private bool _loaded;

        #region Events

        public event EventHandler CloseHandler;
        public event EventHandler ShowHandler;

        protected virtual void Closed(EventArgs e)
        {
            EventHandler handler = CloseHandler;
            handler?.Invoke(this, e);
        }

        protected virtual void Shown(EventArgs e)
        {
            EventHandler handler = ShowHandler;
            handler?.Invoke(this, e);
        }

        #endregion

        public SliderPanel()
        {
            InitializeComponent();
        }

        public SliderPanel(Form owner) 
            : this()
        {
            Visible = false;

            _owner = owner;
            _owner.Controls.Add(this);
            BringToFront();
            _owner.Resize += owner_Resize;

            ResizeForm();
        }

        void owner_Resize(object sender, EventArgs e)
        {
            ResizeForm();
        }

        private void ResizeForm()
        {
            Width = _owner.Width;
            Height = _owner.Height - 77;
            Location = new Point(_loaded ? 0 : _owner.Width, 50);
        }

        public void Swipe(bool show = true)
        {
            Visible = true;
            Transition transasition = new Transition(new TransitionType_EaseInEaseOut(1000));
            transasition.add(this, "Left", show ? 0 : Width);
            transasition.run();

            /*
                Commented for the ui mislocation problem
            */

//            while (Left != (show ? 0 : Width))
//            {
//                Application.DoEvents();
//            }

            if (!show)
            {
                Closed(new EventArgs());
                _owner.Resize -= owner_Resize;
                _owner.Controls.Remove(this);
                Dispose();
            }
            else
            {
                _loaded = true;
                ResizeForm();
                Shown(new EventArgs());
            }
        }
    }
}
