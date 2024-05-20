using ChatAppDataAccess;
using System;
using System.Data;

namespace ChatAppBusiness
{
    public class clsMessage
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enStatus
        {
            Sent = 1,
            Delivered = 2,
            Read = 3,
            Deleted = 4,
        }

        public int? MessageID { get; set; }
        public int? SenderID { get; set; }
        public int? RecipientID { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageDate { get; set; }
        public enStatus Status { get; set; }

        public string StatusText => _GetStatusText();

        public clsUser SenderInfo { get; private set; }
        public clsUser RecipientInfo { get; private set; }

        public clsMessage()
        {
            MessageID = null;
            SenderID = null;
            RecipientID = null;
            MessageContent = string.Empty;
            MessageDate = DateTime.Now;
            Status = enStatus.Sent;

            Mode = enMode.AddNew;
        }

        private clsMessage(int? messageID, int? senderID, int? recipientID, string messageContent,
            DateTime messageDate, enStatus status)
        {
            MessageID = messageID;
            SenderID = senderID;
            RecipientID = recipientID;
            MessageContent = messageContent;
            MessageDate = messageDate;
            Status = status;

            SenderInfo = clsUser.Find(senderID);
            RecipientInfo = clsUser.Find(recipientID);

            Mode = enMode.Update;
        }

        private string _GetStatusText()
        {
            switch (Status)
            {
                case enStatus.Sent:
                    return "Sent";

                case enStatus.Delivered:
                    return "Delivered";

                case enStatus.Read:
                    return "Read";

                case enStatus.Deleted:
                    return "Deleted";

                default:
                    return "Sent";
            }
        }

        private bool _Add()
        {
            MessageID = clsMessageData.Add(SenderID.Value, RecipientID.Value, MessageContent);

            return (MessageID.HasValue);
        }

        private bool _Update()
        {
            return clsMessageData.Update(MessageID.Value, SenderID.Value, RecipientID.Value,
                MessageContent, MessageDate, (byte)Status);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_Add())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _Update();
            }

            return false;
        }

        public static clsMessage Find(int? messageID)
        {
            int? senderID = null;
            int? recipientID = null;
            string messageContent = string.Empty;
            DateTime messageDate = DateTime.Now;
            byte status = 0;

            bool isFound = clsMessageData.GetInfoByID(messageID, ref senderID, ref recipientID,
                ref messageContent, ref messageDate, ref status);

            return (isFound) ? (new clsMessage(messageID, senderID, recipientID,
                                messageContent, messageDate, (enStatus)status))
                             : null;
        }

        public static bool Delete(int? messageID)
        => clsMessageData.Delete(messageID);

        public static bool Exists(int? messageID)
        => clsMessageData.Exists(messageID);

        public static DataTable All()
        => clsMessageData.All();
    }
}