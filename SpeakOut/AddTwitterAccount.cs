using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpeakYourMind.UI
{
    public partial class AddTwitterAccount : Form
    {
        public AddTwitterAccount()
        {
            InitializeComponent();
        }

        public string TwitterAccountName
        {
            get
            {
                return txtTwitterAccountName.Text.Trim();
            }
        }

        public string TwitterVerificationString
        {
            get
            {
                return txtTwitterVerificationString.Text.Trim();
            }
        }

        private void txtTwitterAccountName_TextChanged(object sender, EventArgs e)
        {
            if (txtTwitterAccountName.Text.Trim() == String.Empty)
            {
                btnSaveTwitterAccount.Enabled = false;
            }
            else if (txtTwitterVerificationString.Text.Trim() != String.Empty)
            {
                btnSaveTwitterAccount.Enabled = true;
            }
        }

        private void txtTwitterVerificationString_TextChanged(object sender, EventArgs e)
        {
            if (txtTwitterVerificationString.Text.Trim() == String.Empty)
            {
                btnSaveTwitterAccount.Enabled = false;
            }
            else if (txtTwitterAccountName.Text.Trim() != String.Empty)
            {
                btnSaveTwitterAccount.Enabled = true;
            }

        }

        private void btnSaveTwitterAccount_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
