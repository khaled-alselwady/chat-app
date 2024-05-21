using Microsoft.Data.SqlClient;
using System.Data;

namespace ChatAppDataAccess
{
    public class clsMessageData
    {
        public static bool GetInfoByID(int? messageID, ref int? senderID, ref int? recipientID,
            ref string messageContent, ref DateTime messageDate, ref byte status)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetMessageInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MessageID", (object)messageID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                senderID = (reader["SenderID"] != DBNull.Value) ? (int?)reader["SenderID"] : null;
                                recipientID = (reader["RecipientID"] != DBNull.Value) ? (int?)reader["RecipientID"] : null;
                                messageContent = (string)reader["MessageContent"];
                                messageDate = (DateTime)reader["MessageDate"];
                                status = (byte)reader["Status"];
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

        public static int? Add(int senderID, int recipientID, string messageContent)
        {
            // This function will return the new person id if succeeded and null if not
            int? messageID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewMessage", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SenderID", senderID);
                        command.Parameters.AddWithValue("@RecipientID", recipientID);
                        command.Parameters.AddWithValue("@MessageContent", messageContent);

                        SqlParameter outputIdParam = new SqlParameter("@NewMessageID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        messageID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessHelper.HandleException(ex);
            }

            return messageID;
        }

        public static bool Update(int messageID, int senderID, int recipientID,
            string messageContent, DateTime messageDate, byte status)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateMessage", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MessageID", messageID);
                        command.Parameters.AddWithValue("@SenderID", senderID);
                        command.Parameters.AddWithValue("@RecipientID", recipientID);
                        command.Parameters.AddWithValue("@MessageContent", messageContent);
                        command.Parameters.AddWithValue("@MessageDate", messageDate);
                        command.Parameters.AddWithValue("@Status", status);

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

        public static bool Delete(int? messageID)
        => clsDataAccessHelper.Delete("SP_DeleteMessage", "MessageID", messageID);

        public static bool Exists(int? messageID)
        => clsDataAccessHelper.Exists("SP_DoesMessageExist", "MessageID", messageID);

        public static DataTable All()
        => clsDataAccessHelper.All("SP_GetAllMessages");
    }
}