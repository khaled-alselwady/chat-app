using ChatAppBusiness;
using ChatAppDesktopUI.GlobalClasses;

namespace ChatAppDesktopUI.Contacts
{
    public partial class frmAddNewContactToMainMenu : Form
    {
        public Action<string> UsernameBack;

        public frmAddNewContactToMainMenu()
        {
            InitializeComponent();
        }

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Username is required. Please enter a username.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
            }

            if (!clsUser.Exists(txtUsername.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "The entered username does not exist. Please check and try again.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
            }

            if (txtUsername.Text.Trim() == clsGlobal.CurrentUser?.Username)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "You cannot add yourself as a contact. Please choose a different username.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
            }

            if (clsGlobal.CurrentUser?.IsContactByContactUsername(txtUsername.Text.Trim()) ?? false)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "This user is already in your contacts. Please choose a different username.");
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

            UsernameBack?.Invoke(txtUsername.Text.Trim());
            Close();
        }

        private void frmAddNewContactToMainMenu_Activated(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
