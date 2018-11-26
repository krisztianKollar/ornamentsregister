using System;
using System.Windows.Forms;

namespace Ornaments_Register
{
    public partial class Alert : Form
    {

        public string Message
        {
            set { labelMessage.Text = value; }
        }

        public int ProgressValue
        {
            set { progressBar1.Value = value; }
        }

        public Alert()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> Canceled;

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Canceled?.Invoke(this, e);
        }


    }
}
