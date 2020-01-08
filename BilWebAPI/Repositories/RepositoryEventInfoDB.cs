using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using BilWebAPI.Interfaces;
using BilWebAPI.Models;

namespace BilWebAPI.Repositories
{
    public class RepositoryEventInfoDB : IRepositoryEventInfo<EventInfoConfirm>
    {
        public string ConnectionString { get; set; } = "Server = 192.168.1.200; Database = communicating_cars; User Id=sa; Password = Password1;";

        public void Add(EventInfoConfirm eventInfoConfirm)
        {
            // Creates a connection to the database using the connection string.
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                try
                {
                    // Opens the connection to the database.
                    cnn.Open();

                    using (SqlCommand cmd = new SqlCommand("exec create_event_info @event_info_type_id = @pEvent_Info_Type_ID, @lon = @pLon, @lat = @pLat, @time_of_confirm = @pTime_Of_Confirm, @username = @pUsername;", cnn))
                    {
                        // Adds parameters to the query
                        cmd.Parameters.Add("@pEvent_Info_Type_ID", SqlDbType.Decimal).Value = eventInfoConfirm.EI.EIType.ID;
                        cmd.Parameters.Add("@pLon", SqlDbType.Decimal).Value = eventInfoConfirm.EI.Lon;
                        cmd.Parameters.Add("@pLat", SqlDbType.Decimal).Value = eventInfoConfirm.EI.Lat;
                        cmd.Parameters.Add("@pTime_Of_Confirm", SqlDbType.DateTime).Value = eventInfoConfirm.EI.Lat;
                        cmd.Parameters.Add("@pUsername", SqlDbType.VarChar).Value = eventInfoConfirm.EI.Lat;

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

        public List<EventInfoConfirm> GetAllEventInfo(User user)
        {
            List<EventInfoConfirm> eventInfoConfirms = new List<EventInfoConfirm>();

            // Creates a connection to the database using the connection string.
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                try
                {
                    // Opens the connection to the database.
                    cnn.Open();

                    using (SqlCommand cmd = new SqlCommand("exec get_all_event_infos @language = @pLanguage", cnn))
                    {
                        // Adds parameters to the query
                        cmd.Parameters.Add("@pLanguage", SqlDbType.VarChar).Value = "DK";

                        // Executes the query, getting longitude and latitude.
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            EventInfoConfirm eiConfirm = new EventInfoConfirm((int)reader["event_info_type_id"], (decimal)reader["lon"], (decimal)reader["lat"],
                                (int)reader["confirmed times"], user, (string)reader["title"], (string)reader["description"]);

                            eventInfoConfirms.Add(eiConfirm);
                        }
                    }
                }
                finally
                {
                    // Closes connection.
                    cnn.Close();
                }
            }

            return eventInfoConfirms;
        }

        public EventInfoConfirm GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public EventInfoConfirm GetEventInfoByID(int eventInfoID, User user)
        {
            EventInfoConfirm eiConfirm = null;

            // Creates a connection to the database using the connection string.
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                try
                {
                    // Opens the connection to the database.
                    cnn.Open();

                    using (SqlCommand cmd = new SqlCommand("exec get_event_info_by_id @event_info_id = @pEvent_Info_ID, @language = @pLanguage", cnn))
                    {
                        // Adds parameters to the query
                        cmd.Parameters.Add("@pEvent_Info_ID", SqlDbType.Int).Value = eventInfoID;
                        cmd.Parameters.Add("@pLanguage", SqlDbType.VarChar).Value = user.Language;

                        // Executes the query, getting longitude and latitude.
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            eiConfirm = new EventInfoConfirm(eventInfoID, (decimal)reader["lon"], (decimal)reader["lat"],
                                (int)reader["confirmed times"], user, (string)reader["title"], (string)reader["description"]);
                        }
                    }
                }
                finally
                {
                    // Closes connection.
                    cnn.Close();
                }
            }

            // Returns EventInfoConfirm.
            return eiConfirm;
        }

        public void Remove(EventInfoConfirm t)
        {
            throw new NotImplementedException();
        }

        public void Update(EventInfoConfirm t)
        {
            throw new NotImplementedException();
        }
    }
}