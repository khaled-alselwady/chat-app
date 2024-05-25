using ChatAppBusiness;
using ChatAppDesktopUI.Chats.UserControls;
using ChatAppDesktopUI.Contacts;
using ChatAppDesktopUI.Contacts.UserControls;
using ChatAppDesktopUI.GlobalClasses;
using ChatAppDesktopUI.Login;
using ChatAppDesktopUI.Users;
using System.Data;

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

        private bool _IsUserNull(clsUser user)
        {
            if (user == null)
            {
                MessageBox.Show($"No user found with this username", "Missing Data",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }

            return false;
        }

        private void _ShowChat(int? recipientID)
        {
            panelMassages.Controls.Clear();

            ucMessageContainer messageContainer = new ucMessageContainer();
            messageContainer.ShowChat(clsGlobal.CurrentUser?.UserID, recipientID);
            panelMassages.Controls.Add(messageContainer);

            panelNoSelectedMessageText.Visible = false;
        }

        private void _SaveUserContactToDatabase(int? contactID)
        {
            clsUserContact userContact = new clsUserContact();
            userContact.UserID = clsGlobal.CurrentUser?.UserID;
            userContact.ContactID = contactID;

            userContact.Save();
        }

        private clsMessage? _GetLastMessageInChat(int? senderID, int? recipientID)
            => clsMessage.FindLastMessage(senderID, recipientID);

        private ucSubContactInfo _CreateSubContactInfo(clsUser user)
        {
            clsMessage? lastMessage = _GetLastMessageInChat(clsGlobal.CurrentUser?.UserID, user.UserID);

            ucSubContactInfo subContactInfo = new ucSubContactInfo();
            subContactInfo.ContactID = user.UserID;
            subContactInfo.ContactName = user.Username;
            subContactInfo.ImagePath = user.ImagePath;
            subContactInfo.LastMessage = lastMessage?.MessageContent;
            subContactInfo.TimeOfLastMessage = lastMessage?.MessageDate;
            subContactInfo.ContactIDBack += _ShowChat;

            return subContactInfo;
        }

        private void _AddContactInfoToTheChatsPanel(ucSubContactInfo subContactInfo)
        {
            panelToIncludeNoLContentsExistPanel.Visible = false;
            flowLayoutChatsPanel.Controls.Add(subContactInfo);
        }

        private clsUser _GetUserInfoByUsername(string username)
           => clsUser.Find(username);

        private void _GetUsernameOfNewContact(string username)
        {
            clsUser user = _GetUserInfoByUsername(username);

            if (_IsUserNull(user))
            {
                return;
            }

            _SaveUserContactToDatabase(user.UserID);

            ucSubContactInfo subContactInfo = _CreateSubContactInfo(user);
            _AddContactInfoToTheChatsPanel(subContactInfo);
        }

        private DataTable _GetContactsOfCurrentUser()
            => clsUserContact.AllUserIDAndUsernameOfContactsOfUser(clsGlobal.CurrentUser?.UserID);

        private bool _HasContacts(DataTable dtContactsOfUser)
            => (dtContactsOfUser.Rows.Count > 0);

        private void _PerformShowingContactsOfCurrentUser(DataTable dtContactsOfUser)
        {
            foreach (DataRow row in dtContactsOfUser.Rows)
            {
                clsUser user = _GetUserInfoByUsername(row["Username"].ToString());

                if (!_IsUserNull(user))
                {
                    ucSubContactInfo subContactInfo = _CreateSubContactInfo(user);
                    _AddContactInfoToTheChatsPanel(subContactInfo);
                }
            }
        }

        private void _ShowContactsOfCurrentUser()
        {
            DataTable dtContactsOfUser = _GetContactsOfCurrentUser();

            if (!_HasContacts(dtContactsOfUser))
            {
                return;
            }

            _PerformShowingContactsOfCurrentUser(dtContactsOfUser);
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
            addNewContact.UsernameBack += _GetUsernameOfNewContact;
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

            _ShowContactsOfCurrentUser();
        }
    }
}

