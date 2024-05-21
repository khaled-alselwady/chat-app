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
                errorProvider1.SetError(txtUsername, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
            }

            if (!clsUser.Exists(txtUsername.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "This username does not exist");
                return;
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
