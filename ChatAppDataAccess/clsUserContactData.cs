using Microsoft.Data.SqlClient;
using System.Data;

namespace ChatAppDataAccess
{
    public class clsUserContactData
    {
        public static bool GetInfoByID(int? userContactID, ref int? userID,
            ref int? contactID, ref DateTime createdDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetUserContactInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserContactID", userContactID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                userID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                                contactID = (reader["ContactID"] != DBNull.Value) ? (int?)reader["ContactID"] : null;
                                createdDate = (DateTime)reader["CreatedDate"];
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

        public static int? Add(int userID, int contactID)
        {
            // This function will return the new person id if succeeded and null if not
            int? userContactID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewUserContact", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@ContactID", contactID);

                        SqlParameter outputIdParam = new SqlParameter("@NewUserContactID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        userContactID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessHelper.HandleException(ex);
            }

            return userContactID;
        }

        public static bool Update(int userContactID, int userID, int contactID)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateUserContact", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserContactID", userContactID);
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@ContactID", contactID);

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

        public static bool Delete(int? userContactID)
        => clsDataAccessHelper.Delete("SP_DeleteUserContact", "UserContactID", userContactID);

        public static bool Exists(int? userContactID)
        => clsDataAccessHelper.Exists("SP_DoesUserContactExist", "UserContactID", userContactID);

        public static DataTable All()
        => clsDataAccessHelper.All("SP_GetAllUserContacts");

        public static DataTable AllUserIDAndUsernameOfContactsOfUser(int? userID)
            => clsDataAccessHelper.All("SP_GetUserIDAndUsernameOfAllContactsOfUser", "UserID", userID);

        public static bool CheckIfUserIsContactByContactUsername(int? userID, string contactUsername)
            => clsDataAccessHelper.Exists("SP_CheckIfUserIsContactByContactUsername", "CurrentUserID", userID, "ContactUsername", contactUsername);
    }
}