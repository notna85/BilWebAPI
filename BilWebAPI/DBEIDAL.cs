using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BilWebAPI.Interfaces;
using System.Data.SqlClient;
using System.Data;

namespace BilWebAPI
{
    public class DBEIDAL : IEIDAL
    {
        public string ConnectionString { get; set; } = "Server = 192.168.1.200; Database = communicating_cars; User Id=sa; Password = Password1;";

        // Inserts an event_info into the database.
        public void SaveEventInfo(int eventTypeID, double lon, double lat, string userRegistrationNo)
        {
            // Creates a connection to the database using the connection string.
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                try
                {
                    // Opens the connection to the database.
                    cnn.Open();

                    using (SqlCommand cmd = new SqlCommand("exec create_event_info @event_info_type_id = @pEventType, @lon = @pLon, @lat = @pLat, @user_registration_no = @pUserRegistrationNo", cnn))
                    {
                        // Adds parameters to the non-query
                        cmd.Parameters.Add("@pEventType", SqlDbType.Int).Value = eventTypeID;
                        cmd.Parameters.Add("@pLon", SqlDbType.Decimal).Value = lon;
                        cmd.Parameters.Add("@pLat", SqlDbType.Decimal).Value = lat;
                        cmd.Parameters.Add("@pUserRegistrationNo", SqlDbType.VarChar).Value = userRegistrationNo;

                        // Executes the non-query.
                        cmd.ExecuteNonQuery();
                    }
                }
                finally
                {
                    // Closes connection.
                    cnn.Close();
                }
            }
        }
        
        //Returns info from the database in the form of a list of lists
        public List<List<string>> GetEventInfo(string language)
        {
            //The list to return
            List<List<string>> result = new List<List<string>> { };

            string sqlQuery = "exec get_event_info @language = @pLanguage";

            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, cnn);
                cmd.Parameters.Add("@pLanguage", SqlDbType.VarChar).Value = language;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //The list to be used for populating the above list
                    List<string> resultRow = new List<string> { };
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        resultRow.Add(reader.GetValue(i).ToString());
                    }
                    result.Add(resultRow);
                }
                reader.Close();
            }
            return result;
        }


        //Returns info from the database in the form of a list
        public List<string> GetEventInfoByID(int event_info_id, string language)
        {
            //The list to return
            List<string> result = new List<string> { };

            string sqlQuery = "exec get_event_info_by_id @id = @pId, @language = @pLanguage";

            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, cnn);
                cmd.Parameters.Add("@pId", SqlDbType.VarChar).Value = event_info_id;
                cmd.Parameters.Add("@pLanguage", SqlDbType.VarChar).Value = language;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        result.Add(reader.GetValue(i).ToString());
                    }
                }
                reader.Close();
            }
            return result;
        }
    }
}