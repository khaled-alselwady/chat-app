using ChatAppBusiness;
using ChatAppDesktopUI.GlobalClasses;
using ChatAppDesktopUI.Users;
using System;
using System.Windows.Forms;

namespace ChatAppDesktopUI.Chats.UserControls
{
    public partial class ucMessageContainer : UserControl
    {
        private int? _senderID = null;
        private clsUser _sender = null;

        private int? _recipientID = null;
        private clsUser _recipient = null;

        public ucMessageContainer()
        {
            InitializeComponent();
        }

        private void _ShowRecipientInfoInHeader()
        {
            clsGlobal.ShowUserImageInPictureBox(_recipient?.ImagePath, pbContactImage);
            lblContactName.Text = _recipient?.Username ?? "N/A";
        }

        private void AddMessage(string message)
        {
            var chatMessage = new ucMessage
            {
                MessageContent = message,
                MessageTime = DateTime.Now,
            };

            ucMessage.WidthOfContainer = panelMessageContainer.Width - 20;

            // Add the control to a panel
            panelMessageContainer.Controls.Add(chatMessage);

            //// Position the new control appropriately
            chatMessage.Top = panelMessageContainer.Controls.Count > 1
                ? panelMessageContainer.Controls[panelMessageContainer.Controls.Count - 2].Bottom + 10
                : 10;

            // Ensure the panel refreshes its layout
            panelMessageContainer.PerformLayout();
            panelMessageContainer.Invalidate();
        }

        private void btnContactInfo_Click(object sender, System.EventArgs e)
        {
            frmShowUserInfo showRecipientInfo = new frmShowUserInfo(_recipientID);
            showRecipientInfo.ShowDialog();

            // refresh
            _ShowRecipientInfoInHeader();
        }

        public void ShowChat(int? senderID, int? recipientID)
        {
            _senderID = senderID;
            if (!_senderID.HasValue)
            {
                clsStandardMessages.ShowMissingDataMessage("sender");
                return;
            }

            _recipientID = recipientID;
            if (!_recipientID.HasValue)
            {
                clsStandardMessages.ShowMissingDataMessage("recipient");
                return;
            }

            _sender = clsUser.Find(_senderID);
            if (_sender == null)
            {
                clsStandardMessages.ShowMissingDataMessage("sender", _senderID);

                return;
            }

            _recipient = clsUser.Find(_recipientID);
            if (_recipient == null)
            {
                clsStandardMessages.ShowMissingDataMessage("recipient", _senderID);
                return;
            }

            _ShowRecipientInfoInHeader();
        }

        private void btnDeleteContact_Click(object sender, System.EventArgs e)
        {
            clsStandardMessages.ShowNotImplementedFeatures();
        }

        private void btnBlockContact_Click(object sender, System.EventArgs e)
        {
            clsStandardMessages.ShowNotImplementedFeatures();
        }

        private void btnSendMessage_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                AddMessage(txtMessage.Text);
                txtMessage.Clear();
            }
        }
    }
}
