using System;
using System.Windows.Forms;

namespace ChatAppDesktopUI.Chats.UserControls
{
    public partial class ucSubContactInfo : UserControl
    {
        private string _contactName;
        public string ContactName
        {
            get => _contactName;
            set => _contactName = lblContactName.Text = value;
        }

        private string _lastMessage;
        public string LastMessage
        {
            get => _lastMessage;
            set => _lastMessage = lblLastMessage.Text = value;
        }

        private DateTime _timeOfLastMessage;
        public DateTime TimeOfLastMessage
        {
            get => _timeOfLastMessage;
            set
            {
                _timeOfLastMessage = value;
                lblDateOfTheLastMessage.Text = _timeOfLastMessage.TimeOfDay.ToString("mm/:ss");
            }
        }

        private string _imagePath;
        public string ImagePath
        {
            get => _imagePath;
            set => _imagePath = pbContactImage.ImageLocation = value;
        }

        public ucSubContactInfo()
        {
            InitializeComponent();
        }
    }
}
