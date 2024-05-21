using Microsoft.Data.SqlClient;
using System.Data;

namespace ChatAppDataAccess
{
    public class clsUserData
    {
        public static bool GetInfoByID(int? userID, ref string username, ref string password,
            ref string bio, ref string imagePath)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetUserInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", (object)userID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                username = (string)reader["Username"];
                                password = (string)reader["Password"];
                                bio = (reader["Bio"] != DBNull.Value) ? (string)reader["Bio"] : null;
                                imagePath = (reader["ImagePath"] != DBNull.Value) ? (string)reader["ImagePath"] : null;
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

        public static bool GetInfoByUsername(ref int? userID, string username,
            ref string password, ref string bio, ref string imagePath)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetUserInfoByUsername", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                userID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                                password = (string)reader["Password"];
                                bio = (reader["Bio"] != DBNull.Value) ? (string)reader["Bio"] : null;
                                imagePath = (reader["ImagePath"] != DBNull.Value) ? (string)reader["ImagePath"] : null;
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

        public static bool GetInfoByUsernameAndPassword(ref int? userID,
            string username, string password, ref string bio, ref string imagePath)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetUserInfoByUsernameAndPassword", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                userID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                                bio = (reader["Bio"] != DBNull.Value) ? (string)reader["Bio"] : null;
                                imagePath = (reader["ImagePath"] != DBNull.Value) ? (string)reader["ImagePath"] : null;
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

        public static int? Add(string username, string password,
            string bio, string imagePath)
        {
            // This function will return the new person id if succeeded and null if not
            int? userID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Bio", (object)bio ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ImagePath", (object)imagePath ?? DBNull.Value);

                        SqlParameter outputIdParam = new SqlParameter("@NewUserID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        userID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessHelper.HandleException(ex);
            }

            return userID;
        }

        public static bool Update(int? userID, string username,
            string password, string bio, string imagePath)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", (object)userID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Bio", (object)bio ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ImagePath", (object)imagePath ?? DBNull.Value);

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

        public static bool Delete(int? userID)
        => clsDataAccessHelper.Delete("SP_DeleteUser", "UserID", userID);

        public static bool Exists(int? userID)
        => clsDataAccessHelper.Exists("SP_DoesUserExist", "UserID", userID);

        public static bool Exists(string username)
        => clsDataAccessHelper.Exists("SP_DoesUserExistByUsername", "Username", username);

        public static bool Exists(string username, string password)
        => clsDataAccessHelper.Exists("SP_DoesUserExistByUsernameAndPassword", "Username", username, "Password", password);

        public static DataTable All()
        => clsDataAccessHelper.All("SP_GetAllUsers");

        public static bool ChangePassword(int? UserID, string NewPassword)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_ChangePassword", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@NewPassword", NewPassword);

                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessHelper.HandleException(ex);
            }

            return (RowAffected > 0);
        }

        public static string GetImagePath(int? userID)
        {
            // This function will return the new person id if succeeded and null if not
            string imagePath = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetImagePathByUserID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", userID);

                        SqlParameter outputIdParam = new SqlParameter("@ImagePath", SqlDbType.NVarChar, -1)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        imagePath = outputIdParam.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessHelper.HandleException(ex);
            }

            return imagePath;
        }
    }
}