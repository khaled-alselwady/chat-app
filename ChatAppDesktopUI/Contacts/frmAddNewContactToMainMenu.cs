using ChatAppDesktopUI.GlobalClasses;
using System;
using System.Windows.Forms;

namespace ChatAppDesktopUI.Contacts
{
    public partial class frmAddNewContactToMainMenu : Form
    {
        public Action UsernameBack;

        public frmAddNewContactToMainMenu()
        {
            InitializeComponent();
        }

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (!ValidateChildren())
            {
                clsStandardMessages.ShowValidationErrorMessage();
                return;
            }

            UsernameBack?.Invoke();
            Close();
        }
    }
}
