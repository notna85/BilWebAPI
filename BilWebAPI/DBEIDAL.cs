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
        string connectionString = "Server=10.108.146.1;Database=communicating_cars;User Id=sa;Password=Password1;";

        // Inserts an event_info into the database.
        public void SaveEventInfo(int eventTypeID, double lon, double lat, string userRegistrationNo)
        {
            // Creates a connection to the database using the connection string.
            using (SqlConnection cnn = new SqlConnection(connectionString))
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
    }
}