using ChatAppDataAccess;
using System;
using System.Data;

namespace ChatAppBusiness
{
    public class clsUserContact
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? UserContactID { get; set; }
        public int? UserID { get; set; }
        public int? ContactID { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsUser UserInfo { get; private set; }
        public clsUser ContactInfo { get; private set; }

        public clsUserContact()
        {
            UserContactID = null;
            UserID = null;
            ContactID = null;
            CreatedDate = DateTime.Now;

            Mode = enMode.AddNew;
        }

        private clsUserContact(int? userContactID, int? userID, int? contactID, DateTime createdDate)
        {
            UserContactID = userContactID;
            UserID = userID;
            ContactID = contactID;
            CreatedDate = createdDate;

            UserInfo = clsUser.Find(userID);
            ContactInfo = clsUser.Find(contactID);

            Mode = enMode.Update;
        }

        private bool _Add()
        {
            UserContactID = clsUserContactData.Add(UserID.Value, ContactID.Value);

            return (UserContactID.HasValue);
        }

        private bool _Update()
        {
            return clsUserContactData.Update(UserContactID.Value, UserID.Value, ContactID.Value);
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

        public static clsUserContact Find(int? userContactID)
        {
            int? userID = null;
            int? contactID = null;
            DateTime createdDate = DateTime.Now;

            bool isFound = clsUserContactData.GetInfoByID(userContactID, ref userID,
                ref contactID, ref createdDate);

            return (isFound) ? (new clsUserContact(userContactID, userID, contactID, createdDate)) : null;
        }

        public static bool Delete(int? userContactID)
        => clsUserContactData.Delete(userContactID);

        public static bool Exists(int? userContactID)
        => clsUserContactData.Exists(userContactID);

        public static DataTable All()
        => clsUserContactData.All();
    }
}