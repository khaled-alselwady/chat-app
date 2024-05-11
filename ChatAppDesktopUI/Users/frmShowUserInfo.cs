using System;
using System.Windows.Forms;

namespace ChatAppDesktopUI.Users
{
    public partial class frmShowUserInfo : Form
    {
        public frmShowUserInfo(int? userID)
        {
            InitializeComponent();

            ucUserCard1.LoadUserInfo(userID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
