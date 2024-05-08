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
public int UserID { get; set; }
public int ContactID { get; set; }

public clsUserContact()
{
    UserContactID = null;
    UserID = -1;
    ContactID = -1;

    Mode = enMode.AddNew;
}

private clsUserContact(int? userContactID, int userID, int contactID)
{
    UserContactID = userContactID;
    UserID = userID;
    ContactID = contactID;

    Mode = enMode.Update;
}

private bool _Add()
{
    UserContactID = clsUserContactData.Add(UserID, ContactID);

    return (UserContactID.HasValue);
}

private bool _Update()
{
return clsUserContactData.Update(UserContactID, UserID, ContactID);
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
int userID = -1;
    int contactID = -1;

bool isFound = clsUserContactData.GetInfoByID(userContactID, ref userID, ref contactID);

return (isFound) ? (new clsUserContact(userContactID, userID, contactID)) : null;
}

public static bool Delete(int? userContactID)
=> clsUserContactData.Delete(userContactID);

public static bool Exists(int? userContactID)
=> clsUserContactData.Exists(userContactID);

public static DataTable All()
=> clsUserContactData.All();
}
}