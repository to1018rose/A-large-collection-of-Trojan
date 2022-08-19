using System.Windows.Forms;
using WindowsAutomationSpy.Utilities;
using MetroFramework;
using MetroFramework.Forms;

namespace WindowsAutomationSpy.UI
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
            //foreach (Control control in this.Controls)
            //{
            //    control.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            //}
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MetroMessageBox.Show(this, Constants.CloseFormConfirmationMsg, Constants.CloseFormTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
                Activate();
            }
        }
    }
}
