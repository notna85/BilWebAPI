using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BilWebAPI.Interfaces;
using BilWebAPI.Models;

namespace BilWebAPI.Repositories
{
    public class RepositoryUserDB : IRepositoryUser<User>
    {
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
            throw new NotImplementedException();
        }

        public User GetUserByRegNo(string regNo)
        {
            throw new NotImplementedException();
        }

        public User GetUserBySID(string SID, string username)
        {
            throw new NotImplementedException();
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