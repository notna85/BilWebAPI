using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BilWebAPI.Models;
using BilWebAPI.Repositories;

namespace BilWebAPI.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public User GetUserByRegNo(string regNo)
        {
            RepositoryUserDB rUDB = new RepositoryUserDB();
            return rUDB.GetUserByRegNo(regNo);           
        }

        [HttpGet]
        public User CheckLogin(string username, string password)
        {
            if (username == null || password == null)
            {
                username = "";
                password = "";
            }
            User user = new User(username, password);
            RepositoryUserDB rUDB = new RepositoryUserDB();            
            return rUDB.GetSessionInfo(user);
        }

        [HttpGet]
        public User GetUserBySID(string SID, string username, string language)
        {
            RepositoryUserDB rUDB = new RepositoryUserDB();
            User user = rUDB.GetUserBySID(SID, username);
            user.Language = language;
            return user;
        }
    }
}