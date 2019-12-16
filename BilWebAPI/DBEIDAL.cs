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
        public List<List<string>> GetEventInfo()
        {
            //The list to return
            List<List<string>> result = new List<List<string>> { };
            //The list to be used for populating the above list
            List<string> resultRow = new List<string> { };

            string sqlQuery = "select * from event_infos";

            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    resultRow.Clear();
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
    }
}