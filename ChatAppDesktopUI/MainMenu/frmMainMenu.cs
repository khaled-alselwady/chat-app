using ChatAppBusiness;
using ChatAppDesktopUI.Contacts;
using ChatAppDesktopUI.Contacts.UserControls;
using ChatAppDesktopUI.GlobalClasses;
using ChatAppDesktopUI.Login;
using ChatAppDesktopUI.Users;
using System;
using System.Windows.Forms;

namespace ChatAppDesktopUI.MainMenu
{
    public partial class frmMainMenu : Form
    {
        private frmLoginScreen _frmLogin;

        public frmMainMenu(frmLoginScreen frmLogin)
        {
            InitializeComponent();

            _frmLogin = frmLogin;
        }

        //private void _ShowUserImageInPictureBox(string path)
        //{
        //    if (File.Exists(path))
        //    {
        //        pbUserProfile.ImageLocation = path;
        //    }
        //    else
        //    {
        //        pbUserProfile.Image = Resources.default_male;
        //    }
        //}

        private static ucSubContactInfo _FillSubContactInfo(clsUser user)
        {
            ucSubContactInfo subContactInfo = new ucSubContactInfo();
            subContactInfo.ContactName = user.Username;
            subContactInfo.ImagePath = user.ImagePath;

            return subContactInfo;
        }

        private void _AddContactInfoToTheChatsPanel(ucSubContactInfo subContactInfo)
        {
            panelToIncludeNoLContentsExistPanel.Visible = false;
            flowLayoutChatsPanel.Controls.Add(subContactInfo);
        }

        private void _GetUsernameFromAddNewContactToMainMenuForm(string username)
        {
            clsUser user = clsUser.Find(username);

            if (user == null)
            {
                MessageBox.Show($"No user found with this username", "Missing Data",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ucSubContactInfo subContactInfo = _FillSubContactInfo(user);

            _AddContactInfoToTheChatsPanel(subContactInfo);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void btnAddNewContent_Click(object sender, EventArgs e)
        {
            frmAddNewContactToMainMenu addNewContact = new frmAddNewContactToMainMenu();
            addNewContact.UsernameBack += _GetUsernameFromAddNewContactToMainMenuForm;
            addNewContact.ShowDialog();
        }

        private void pbUserProfile_Click(object sender, EventArgs e)
        {
            frmShowUserInfo showUserInfo = new frmShowUserInfo(clsGlobal.CurrentUser?.UserID);
            showUserInfo.ShowDialog();

            clsGlobal.ShowUserImageInPictureBox(clsUser.GetImagePath(clsGlobal.CurrentUser?.UserID), pbUserProfile);
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Hide();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            clsGlobal.ShowUserImageInPictureBox(clsUser.GetImagePath(clsGlobal.CurrentUser?.UserID), pbUserProfile);
        }
    }
}
