using ChatAppDesktopUI.GlobalClasses;

namespace ChatAppDesktopUI.Contacts.UserControls
{
    public partial class ucSubContactInfo : UserControl
    {
        public Action<int?> ContactIDBack;

        public int? ContactID { get; set; }

        private string _contactName;
        public string ContactName
        {
            get => _contactName;
            set => _contactName = lblContactName.Text = value;
        }

        private string? _lastMessage;
        public string? LastMessage
        {
            get => _lastMessage;
            set => _lastMessage = lblLastMessage.Text = value;
        }

        private DateTime? _timeOfLastMessage;
        public DateTime? TimeOfLastMessage
        {
            get => _timeOfLastMessage;
            set
            {
                _timeOfLastMessage = value;
                lblDateOfTheLastMessage.Text = _timeOfLastMessage?.ToString("hh\\:mm");
            }
        }

        private string _imagePath;
        public string ImagePath
        {
            get => _imagePath;
            set
            {
                _imagePath = value;
                clsGlobal.ShowUserImageInPictureBox(_imagePath, pbContactImage);
            }
        }

        public ucSubContactInfo()
        {
            InitializeComponent();
        }

        private void ucSubContactInfo_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(53, 60, 67);
            this.Cursor = Cursors.Hand;
        }

        private void ucSubContactInfo_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(41, 58, 76);
            this.Cursor = Cursors.Default;
        }

        private void On_Click(object sender, EventArgs e)
        {
            ContactIDBack?.Invoke(ContactID);
        }
    }
}
