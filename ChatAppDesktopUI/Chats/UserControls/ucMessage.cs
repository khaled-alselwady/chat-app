using System.Drawing;
using System.Windows.Forms;

namespace ChatAppDesktopUI.Chats.UserControls
{
    public partial class ucMessage : UserControl
    {
        private string _messageContent;
        public string MessageContent
        {
            get => _messageContent;
            set
            {
                _messageContent = value;
                lblMessageContent.Text = value;
                AdjustSize();
            }
        }

        public ucMessage()
        {
            InitializeComponent();

            lblMessageContent.AutoSize = false;
            lblMessageContent.MaximumSize = new Size(this.Width - 20, 0); // Maximum width and no limit on height
            lblMessageContent.AutoEllipsis = true;
            lblMessageContent.TextAlign = ContentAlignment.TopLeft;
        }

        private void AdjustSize()
        {
            // Measure the size of the message
            Size size = TextRenderer.MeasureText(lblMessageContent.Text, lblMessageContent.Font, new Size(this.Width, int.MaxValue), TextFormatFlags.WordBreak);

            // Adjust the height of the label and the user control
            lblMessageContent.Height = size.Height;
            this.Height = lblMessageContent.Bottom + 10; // Adding some padding
        }
    }
}
