using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BilWebAPI.Interfaces;
using BilWebAPI.Models;

namespace BilWebAPI.Repositories
{
    public class RepositoryEventInfoDB : IRepositoryEventInfo<EventInfoConfirm>
    {
        public void Add(EventInfoConfirm t)
        {
            throw new NotImplementedException();
        }

        public List<EventInfoConfirm> GetAllEventInfo(User user)
        {
            throw new NotImplementedException();
        }

        public EventInfoConfirm GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public EventInfoConfirm GetEventInfoByID(int eventInfoID, User user)
        {
            throw new NotImplementedException();
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