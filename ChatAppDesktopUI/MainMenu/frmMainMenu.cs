using ChatAppDesktopUI.GlobalClasses;
using ChatAppDesktopUI.Login;
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void btnAddNewContent_Click(object sender, EventArgs e)
        {
            clsStandardMessages.ShowNotImplementedFeatures();
        }

        private void pbUserProfile_Click(object sender, EventArgs e)
        {
            clsStandardMessages.ShowNotImplementedFeatures();
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Hide();
        }
    }
}
