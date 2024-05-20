using ChatAppBusiness;
using ChatAppDesktopUI.Chats.UserControls;
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

        private void _ShowChat(int? recipientID)
        {
            panelMassages.Controls.Clear();

            ucMessageContainer messageContainer = new ucMessageContainer();
            messageContainer.ShowChat(clsGlobal.CurrentUser?.UserID, recipientID);
            panelMassages.Controls.Add(messageContainer);

            panelNoSelectedMessageText.Visible = false;
        }

        private static void _SaveUserContactToDatabase(int? contactID)
        {
            clsUserContact userContact = new clsUserContact();
            userContact.UserID = clsGlobal.CurrentUser?.UserID;
            userContact.ContactID = contactID;

            userContact.Save();
        }

        private ucSubContactInfo _FillSubContactInfo(clsUser user)
        {
            ucSubContactInfo subContactInfo = new ucSubContactInfo();
            subContactInfo.ContactID = user.UserID;
            subContactInfo.ContactName = user.Username;
            subContactInfo.ImagePath = user.ImagePath;
            subContactInfo.ContactIDBack += _ShowChat;

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

            _SaveUserContactToDatabase(user.UserID);

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
