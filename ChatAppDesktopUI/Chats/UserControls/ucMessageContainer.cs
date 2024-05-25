using ChatAppBusiness;
using ChatAppDesktopUI.GlobalClasses;
using ChatAppDesktopUI.Users;
using System.Data;

namespace ChatAppDesktopUI.Chats.UserControls
{
    public partial class ucMessageContainer : UserControl
    {
        private int? _senderID = null;
        private clsUser _sender = null;

        private int? _recipientID = null;
        private clsUser _recipient = null;

        private const byte _HeightBetweenMessages = 50;
        private const int _LeftPadding = 10;
        private const int _RightPadding = 700;

        public ucMessageContainer()
        {
            InitializeComponent();
        }

        private void _ShowRecipientInfoInHeader()
        {
            clsGlobal.ShowUserImageInPictureBox(_recipient?.ImagePath, pbContactImage);
            lblContactName.Text = _recipient?.Username ?? "N/A";
        }

        private void _SaveMessageToDatabase()
        {
            clsMessage message = new clsMessage();
            message.SenderID = _senderID;
            message.RecipientID = _recipientID;
            message.MessageContent = txtMessage.Text;

            message.Save();
        }

        private static ucMessage _CreateMessage(string message, DateTime messageTime)
        {
            return new ucMessage
            {
                MessageContent = message,
                MessageTime = messageTime,
            };
        }

        private void _AddMessageToThePanel(ucMessage chatMessage)
        {
            ucMessage.WidthOfContainer = panelMessageContainer.Width - 20;

            panelMessageContainer.Controls.Add(chatMessage);
        }

        private void _PositionMessageControl(ucMessage chatMessage, bool isSentByUser)
        {
            // Determine the top position (Height between messages)
            chatMessage.Top = panelMessageContainer.Controls.Count > 1
                ? panelMessageContainer.Controls[panelMessageContainer.Controls.Count - 2].Bottom + _HeightBetweenMessages
                : _HeightBetweenMessages;

            // Adjust the alignment based on the sender
            if (isSentByUser)
            {
                // Align to the left
                chatMessage.Left = _LeftPadding;
            }
            else
            {
                // Align to the right
                chatMessage.Left = _RightPadding;
            }
        }

        private void _AddMessage(string message, DateTime messageTime, bool isSentByUser)
        {
            ucMessage chatMessage = _CreateMessage(message, messageTime);

            _AddMessageToThePanel(chatMessage);

            _PositionMessageControl(chatMessage, isSentByUser);

            // Ensure the panel refreshes its layout
            panelMessageContainer.PerformLayout();
            panelMessageContainer.Invalidate();
        }

        private static bool _IsChatEmpty(DataTable dtMessagesInAChat)
            => dtMessagesInAChat.Rows.Count <= 0;

        private void _PerformShowMessagesInAChat(DataTable dtMessagesInAChat)
        {
            if (dtMessagesInAChat is null)
            {
                return;
            }

            foreach (DataRow row in dtMessagesInAChat.Rows)
            {
                bool isSentByUser = Convert.ToInt32(row["SenderID"]) == _senderID;

                _AddMessage
                    (Convert.ToString(row["MessageContent"]),
                     Convert.ToDateTime(row["MessageDate"]),
                     isSentByUser
                    );
            }
        }

        private void _ShowMessagesInAChat()
        {
            DataTable dtMessagesInAChat = clsMessage.AllMessagesInAChat(_senderID, _recipientID);

            if (dtMessagesInAChat is null || _IsChatEmpty(dtMessagesInAChat))
            {
                return;
            }

            _PerformShowMessagesInAChat(dtMessagesInAChat);
        }

        private void btnContactInfo_Click(object sender, System.EventArgs e)
        {
            frmShowUserInfo showRecipientInfo = new frmShowUserInfo(_recipientID, false);
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

            _ShowMessagesInAChat();
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
                _AddMessage(txtMessage.Text, DateTime.Now, true);

                _SaveMessageToDatabase();

                txtMessage.Clear();
            }
        }
    }
}
