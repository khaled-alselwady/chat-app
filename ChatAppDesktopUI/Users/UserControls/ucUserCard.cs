using ChatAppBusiness;
using ChatAppDesktopUI.GlobalClasses;
//using ChatAppDesktopUI.Properties;

namespace ChatAppDesktopUI.Users.UserControls
{
    public partial class ucUserCard : UserControl
    {
        private int? _userID = null;
        private clsUser _user = null;

        public int? UserID => _userID;
        public clsUser UserInfo => _user;

        public ucUserCard()
        {
            InitializeComponent();
        }

        private void _LoadUserImage()
        {
            if (_user.ImagePath != null)
            {
                if (File.Exists(_user.ImagePath))
                    pbUserImage.ImageLocation = _user.ImagePath;
            }
            else
            {
                pbUserImage.ImageLocation = null;
                //pbUserImage.Image = Resources.default_male;
            }
        }

        private void _FillUserData()
        {
            lblUserID.Text = _user.UserID.ToString();
            lblUsername.Text = _user.Username;
            lblBio.Text = _user.Bio ?? "N/A";

            _LoadUserImage();

            llEditUserInfo.Enabled = true;
        }

        public void Reset()
        {
            _userID = null;
            _user = null;

            lblUserID.Text = "[????]";
            lblUsername.Text = "[????]";
            lblBio.Text = "[????]";
            //pbUserImage.Image = Resources.default_male;

            llEditUserInfo.Enabled = false;
        }

        public void LoadUserInfo(int? UserID, bool allowEditInfo = true)
        {
            _userID = UserID;

            if (!_userID.HasValue)
            {
                clsStandardMessages.ShowMissingDataMessage("user");

                Reset();

                return;
            }

            _user = clsUser.Find(_userID);

            if (_user == null)
            {
                clsStandardMessages.ShowMissingDataMessage("user", _userID);

                Reset();

                return;
            }

            _FillUserData();

            llEditUserInfo.Visible = allowEditInfo;
        }

        private void llEditUserInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditUser editUser = new frmAddEditUser(_userID);
            editUser.ShowDialog();

            // Refresh
            LoadUserInfo(_userID);
        }
    }
}
