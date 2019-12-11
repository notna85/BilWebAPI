using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;
using BilWebAPI.Models;

namespace BilWebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            List<string> result = new List<string> { };
            SqlDataReader reader;
            string connectionString = "Data Source = 10.108.146.1,1433; Network Library = DBMSSOCN; Initial Catalog = communicating_cars; Integrated Security = False; TrustServerCertificate = True; User ID = sa; Password = Password1;";
            string sqlQuery = "select * from users";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(reader.GetValue(0).ToString());
                }
            }           
            return result;  
        }

        // GET api/values/5
        public string Get(int id)
        {
            //Hej
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string registration, int event_type_id, float lat, float lon, DateTime time)
        {
            /*
            EventInfo ei = new EventInfo();
            ei.EventInfoType = event_type_id;
            ei.Lat = lat;
            ei.Lon = lon;

            string connectionString = "Data Source = 10.108.146.1,1433; Network Library = DBMSSOCN; Initial Catalog = communicating_cars; Integrated Security = False; TrustServerCertificate = True; User ID = sa; Password = Password1;";
            string sqlQuery = "exec create_event_info";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
            }
            */
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
