using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BilWebAPI.Models;

namespace BilWebAPI.Controllers
{
    public class UserController : ApiController
    {
        public User GetUserByRegNo(string regNo)
        {
            return new User();
        }

        public User CheckLogin(string username, string password)
        {
            return new User();
        }

        public List<EventInfoConfirm> GetUserBySID(string SID, string username, string language)
        {
            return new List<EventInfoConfirm>();
        }
    }
}