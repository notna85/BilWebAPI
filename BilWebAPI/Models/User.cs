﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilWebAPI.Models
{
    public class User
    {
        private string username;
        private string password;
        private string language;
        private string sessionID;
        private int id;
        private Car userCar;

        public string Username { get; set; }
        public string Password { get; set; }
        public string Language { get; set; }
        public string SessionID { get; set; }
        public int ID { get; set; }
        public Car UserCar { get; set; }

        public User(string username, string password, string language, string sessionID, int id, Car userCar)
        {
            Username = username;
            Password = password;
            Language = language;
            SessionID = sessionID;
            ID = id;
            UserCar = userCar;
        }

        public User()
        {

        }
    }
}