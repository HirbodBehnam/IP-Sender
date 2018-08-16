using System;
using System.Windows.Forms;

namespace IP_Sender
{
    public partial class PasswordHasher : Form
    {
        public PasswordHasher()
        {
            InitializeComponent();
        }

        private void passTXT_TextChanged(object sender, EventArgs e)
        {
            LBLHash.Text = Helper.SHA256(TXTPass.Text);
        }

        private void CpyBTN_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LBLHash.Text);
        }
    }
}
