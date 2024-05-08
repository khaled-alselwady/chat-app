using ChatAppDataAccess;
using System;
using System.Data;

namespace ChatAppBusiness
{
    public class clsMessage
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? MessageID { get; set; }
        public int SenderID { get; set; }
        public int RecipientID { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageDate { get; set; }
        public byte Status { get; set; }

        public clsMessage()
        {
            MessageID = null;
            SenderID = -1;
            RecipientID = -1;
            MessageDate = DateTime.Now;
            Status = 0;

            Mode = enMode.AddNew;
        }

        private clsMessage(int? messageID, int senderID, int recipientID, string messageContent, DateTime messageDate, byte status)
        {
            MessageID = messageID;
            SenderID = senderID;
            RecipientID = recipientID;
            MessageContent = messageContent;
            MessageDate = messageDate;
            Status = status;

            Mode = enMode.Update;
        }

        private bool _Add()
        {
            MessageID = clsMessageData.Add(SenderID, RecipientID, MessageContent, MessageDate, Status);

            return (MessageID.HasValue);
        }

        private bool _Update()
        {
            return clsMessageData.Update(MessageID, SenderID, RecipientID, MessageContent, MessageDate, Status);
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
            int senderID = -1;
            int recipientID = -1;
            string messageContent = string.Empty;
            DateTime messageDate = DateTime.Now;
            byte status = 0;

            bool isFound = clsMessageData.GetInfoByID(messageID, ref senderID, ref recipientID, ref messageContent, ref messageDate, ref status);

            return (isFound) ? (new clsMessage(messageID, senderID, recipientID, messageContent, messageDate, status)) : null;
        }

        public static bool Delete(int? messageID)
        => clsMessageData.Delete(messageID);

        public static bool Exists(int? messageID)
        => clsMessageData.Exists(messageID);

        public static DataTable All()
        => clsMessageData.All();
    }
}