using ChatAppBusiness;
using ChatAppDesktopUI.Contacts;
using ChatAppDesktopUI.GlobalClasses;
using ChatAppDesktopUI.Login;
using ChatAppDesktopUI.Properties;
using ChatAppDesktopUI.Users;
using System;
using System.IO;
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

        private void _ShowUserImageInPictureBox(string path)
        {
            if (File.Exists(path))
            {
                pbUserProfile.ImageLocation = path;
            }
            else
            {
                pbUserProfile.Image = Resources.default_male;
            }
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
            addNewContact.ShowDialog();
        }

        private void pbUserProfile_Click(object sender, EventArgs e)
        {
            frmShowUserInfo showUserInfo = new frmShowUserInfo(clsGlobal.CurrentUser?.UserID);
            showUserInfo.ShowDialog();

            _ShowUserImageInPictureBox(clsUser.GetImagePath(clsGlobal.CurrentUser?.UserID));
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Hide();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            _ShowUserImageInPictureBox(clsGlobal.CurrentUser?.ImagePath);
        }
    }
}
