using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BilWebAPI.Interfaces;
using BilWebAPI.Models;
using System.Data.SqlClient;
using System.Data;

namespace BilWebAPI.Repositories
{
    public class RepositoryUserDB : IRepositoryUser<User>
    {
        public string ConnectionString { get; set; } = "Server = 192.168.1.200; Database = communicating_cars; User Id=sa; Password = Password1;";
        
        public void Add(User t)
        {
            throw new NotImplementedException();
        }

        public User GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public User GetSessionInfo(User user)
        {
            string sqlQuery = "exec login @username = @pUsername, @password = @pPassword";

            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, cnn);
                cmd.Parameters.Add("@pUsername", SqlDbType.VarChar).Value = user.Username;
                cmd.Parameters.Add("@pPassword", SqlDbType.VarChar).Value = user.Password;
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                user.SessionID = reader["session_id"].ToString();
                user.Language = reader["language"].ToString();

                reader.Close();
                cnn.Close();

                return user;
            }
        }

        public User GetUserByRegNo(string regNo)
        {
            string sqlQuery = "exec get_user_by_registration_no @registration_no = @pRegno";

            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, cnn);
                cmd.Parameters.Add("@pRegno", SqlDbType.VarChar).Value = regNo;
                SqlDataReader reader = cmd.ExecuteReader();
                User user = new User();
                reader.Read();
                user.Username = reader["username"].ToString();
            
                reader.Close();
                cnn.Close();

                return user;
            }
        }

        public User GetUserBySID(string SID, string username)
        {
            string sqlQuery = "exec check_session_id @session_id = @pSID, @username = @pUsername";

            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, cnn);
                cmd.Parameters.Add("@pSID", SqlDbType.VarChar).Value = SID;
                cmd.Parameters.Add("@pUsername", SqlDbType.VarChar).Value = username;
                SqlDataReader reader = cmd.ExecuteReader();
                User user = new User();
                reader.Read();
                user.Username = reader["username"].ToString();
                user.SessionID = reader["session_id"].ToString();
                
                reader.Close();
                cnn.Close();

                return user;
            }
        }

        public void Remove(User t)
        {
            throw new NotImplementedException();
        }

        public void Update(User t)
        {
            throw new NotImplementedException();
        }
    }
}