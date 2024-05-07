using System;
using System.Data;
using System.Data.SqlClient;

namespace ChatAppDataAccess
{
public class clsBlockedContactData
{
public static bool GetInfoByID(int? blockedContactID, ref int blockerID, ref int blockedID, ref DateTime blockedDataTime)
{
    bool isFound = false;

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand("SP_GetBlockedContactInfoByID", connection))
            {
command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@BlockedContactID", (object)blockedContactID ?? DBNull.Value);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // The record was found
                        isFound = true;

blockerID = (int)reader["BlockerID"];
blockedID = (int)reader["BlockedID"];
blockedDataTime = (DateTime)reader["BlockedDataTime"];
                    }
                    else
                    {
                        // The record was not found
                        isFound = false;
                    }
                }
            }
        }
    }
catch (Exception ex)
            {
                isFound = false;
                clsDataAccessHelper.HandleException(ex);
            }

    return isFound;
}

public static int? Add(int blockerID, int blockedID, DateTime blockedDataTime)
{
// This function will return the new person id if succeeded and null if not
    int? blockedContactID = null;

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand("SP_AddNewBlockedContact", connection))
            {
command.CommandType = CommandType.StoredProcedure;

command.Parameters.AddWithValue("@BlockerID", blockerID);
command.Parameters.AddWithValue("@BlockedID", blockedID);
command.Parameters.AddWithValue("@BlockedDataTime", blockedDataTime);

SqlParameter outputIdParam = new SqlParameter("@NewBlockedContactID", SqlDbType.Int)
{
Direction = ParameterDirection.Output
};
command.Parameters.Add(outputIdParam);

command.ExecuteNonQuery();

blockedContactID = (int?)outputIdParam.Value;
            }
        }
    }
catch (Exception ex)
            {
                clsDataAccessHelper.HandleException(ex);
            }

    return blockedContactID;
}

public static bool Update(int? blockedContactID, int blockerID, int blockedID, DateTime blockedDataTime)
{
    int rowAffected = 0;

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand("SP_UpdateBlockedContact", connection))
            {
command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@BlockedContactID", (object)blockedContactID ?? DBNull.Value);
command.Parameters.AddWithValue("@BlockerID", blockerID);
command.Parameters.AddWithValue("@BlockedID", blockedID);
command.Parameters.AddWithValue("@BlockedDataTime", blockedDataTime);

                rowAffected = command.ExecuteNonQuery();
            }
        }
    }
catch (Exception ex)
            {
                clsDataAccessHelper.HandleException(ex);
            }

    return (rowAffected > 0);
}

public static bool Delete(int? blockedContactID)
=> clsDataAccessHelper.Delete("SP_DeleteBlockedContact", "BlockedContactID", blockedContactID);

public static bool Exists(int? blockedContactID)
=> clsDataAccessHelper.Exists("SP_DoesBlockedContactExist", "BlockedContactID", blockedContactID);

public static DataTable All()
=> clsDataAccessHelper.All("SP_GetAllBlockedContacts");
}
}