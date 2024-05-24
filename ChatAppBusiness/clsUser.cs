using ChatAppDataAccess;
using System.Data;

namespace ChatAppBusiness
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Bio { get; set; }
        public string ImagePath { get; set; }

        public clsUser()
        {
            UserID = null;
            Username = string.Empty;
            Password = string.Empty;
            Bio = null;
            ImagePath = null;

            Mode = enMode.AddNew;
        }

        private clsUser(int? userID, string username, string password, string bio, string imagePath)
        {
            UserID = userID;
            Username = username;
            Password = password;
            Bio = bio;
            ImagePath = imagePath;

            Mode = enMode.Update;
        }

        private bool _Add()
        {
            UserID = clsUserData.Add(Username, Password, Bio, ImagePath);

            return (UserID.HasValue);
        }

        private bool _Update()
        {
            return clsUserData.Update(UserID, Username, Password, Bio, ImagePath);
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

        public static clsUser Find(int? userID)
        {
            string username = string.Empty;
            string password = string.Empty;
            string bio = null;
            string imagePath = null;

            bool isFound = clsUserData.GetInfoByID(userID, ref username, ref password, ref bio, ref imagePath);

            return (isFound) ? (new clsUser(userID, username, password, bio, imagePath)) : null;
        }

        public static clsUser Find(string username)
        {
            int? userID = null;
            string password = string.Empty;
            string bio = null;
            string imagePath = null;

            bool isFound = clsUserData.GetInfoByUsername(ref userID, username, ref password, ref bio, ref imagePath);

            return (isFound) ? (new clsUser(userID, username, password, bio, imagePath)) : null;
        }

        public static clsUser Find(string username, string password)
        {
            int? userID = null;
            string bio = null;
            string imagePath = null;
            bool isFound = clsUserData.GetInfoByUsernameAndPassword(ref userID, username, password, ref bio, ref imagePath);

            return (isFound) ? (new clsUser(userID, username, password, bio, imagePath)) : null;
        }

        public static bool Delete(int? userID)
        => clsUserData.Delete(userID);

        public static bool Exists(int? userID)
        => clsUserData.Exists(userID);

        public static bool Exists(string username)
        => clsUserData.Exists(username);

        public static bool Exists(string username, string password)
        => clsUserData.Exists(username, password);

        public static DataTable All()
        => clsUserData.All();

        public bool ChangePassword(string NewPassword)
            => ChangePassword(UserID, NewPassword);

        public static bool ChangePassword(int? UserID, string NewPassword)
            => clsUserData.ChangePassword(UserID, NewPassword);

        public static string GetImagePath(int? userID)
            => clsUserData.GetImagePath(userID);

        public bool IsContactByContactUsername(string contactUsername)
            => clsUserContact.CheckIfUserIsContactByContactUsername(this.UserID, contactUsername);
    }
}