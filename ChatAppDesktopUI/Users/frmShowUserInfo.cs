namespace ChatAppDesktopUI.Users
{
    public partial class frmShowUserInfo : Form
    {
        public frmShowUserInfo(int? userID, bool allowEditInfo = true)
        {
            InitializeComponent();

            ucUserCard1.LoadUserInfo(userID, allowEditInfo);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
