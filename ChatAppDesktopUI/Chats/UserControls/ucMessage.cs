using System;
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
                lblMessageContent.Text = _messageContent;
                AdjustSize();
            }
        }

        private DateTime _messageTime;
        public DateTime MessageTime
        {
            get => _messageTime;
            set
            {
                _messageTime = value;
                lblMessageTime.Text = value.ToShortTimeString();
            }
        }

        public static int WidthOfContainer { get; set; } = 0;

        private void _InitializeCustomLabel()
        {
            lblMessageContent = new Label();
            lblMessageContent.AutoSize = true;
            lblMessageContent.AutoEllipsis = true;
            lblMessageContent.TextAlign = ContentAlignment.TopLeft;
            lblMessageContent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Customize font properties
            lblMessageContent.Font = new Font("Segoe UI", 12, FontStyle.Regular); // Example: Arial, 12pt, Regular

            // Customize font color
            lblMessageContent.ForeColor = Color.White; // Example: Black

            // Increase padding around the label
            lblMessageContent.Padding = new Padding(10);

            // Add label to the control's controls collection
            this.Controls.Add(lblMessageContent);
        }

        public ucMessage()
        {
            InitializeComponent();

            _InitializeCustomLabel();
        }

        private void AdjustSize()
        {
            int maxWidth = WidthOfContainer / 2;
            int fixedWidth = maxWidth < this.Width ? maxWidth : this.Width;

            lblMessageContent.MaximumSize = new Size(fixedWidth, 0); // Set maximum width

            using (Graphics g = CreateGraphics())
            {
                SizeF size = g.MeasureString(lblMessageContent.Text, lblMessageContent.Font, fixedWidth);
                lblMessageContent.Height = (int)Math.Ceiling(size.Height);
            }

            this.Height = lblMessageContent.Bottom + 10; // Adding some padding
        }
    }
}
