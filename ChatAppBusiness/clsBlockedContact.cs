using ChatAppDataAccess;
using System;
using System.Data;

namespace ChatAppBusiness
{
public class clsBlockedContact
{
public enum enMode { AddNew = 0, Update = 1 };
public enMode Mode = enMode.AddNew;

public int? BlockedContactID { get; set; }
public int BlockerID { get; set; }
public int BlockedID { get; set; }
public DateTime BlockedDataTime { get; set; }

public clsBlockedContact()
{
    BlockedContactID = null;
    BlockerID = -1;
    BlockedID = -1;
    BlockedDataTime = DateTime.Now;

    Mode = enMode.AddNew;
}

private clsBlockedContact(int? blockedContactID, int blockerID, int blockedID, DateTime blockedDataTime)
{
    BlockedContactID = blockedContactID;
    BlockerID = blockerID;
    BlockedID = blockedID;
    BlockedDataTime = blockedDataTime;

    Mode = enMode.Update;
}

private bool _Add()
{
    BlockedContactID = clsBlockedContactData.Add(BlockerID, BlockedID, BlockedDataTime);

    return (BlockedContactID.HasValue);
}

private bool _Update()
{
return clsBlockedContactData.Update(BlockedContactID, BlockerID, BlockedID, BlockedDataTime);
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

public static clsBlockedContact Find(int? blockedContactID)
{
int blockerID = -1;
    int blockedID = -1;
    DateTime blockedDataTime = DateTime.Now;

bool isFound = clsBlockedContactData.GetInfoByID(blockedContactID, ref blockerID, ref blockedID, ref blockedDataTime);

return (isFound) ? (new clsBlockedContact(blockedContactID, blockerID, blockedID, blockedDataTime)) : null;
}

public static bool Delete(int? blockedContactID)
=> clsBlockedContactData.Delete(blockedContactID);

public static bool Exists(int? blockedContactID)
=> clsBlockedContactData.Exists(blockedContactID);

public static DataTable All()
=> clsBlockedContactData.All();
}
}