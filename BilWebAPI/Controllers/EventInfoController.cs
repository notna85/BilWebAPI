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
    public class EventInfoController : ApiController
    {
        [HttpGet, HttpPost]
        public void Post(int eventInfoTypeID, decimal lon, decimal lat, string regNo)
        {
            /// Creates a UserController which will get a user from the database by its Registration Number.
            UserController uc = new UserController();
            User user = uc.GetUserByRegNo(regNo);

            /// Creates an EventInfoConfirm with the provided parameters.
            EventInfoConfirm eventInfoConfirm = new EventInfoConfirm(eventInfoTypeID, lon, lat, user);

            /// Creates an EventInfoDB to add the EventInfoConfirm to the database.
            RepositoryEventInfoDB eiDB = new RepositoryEventInfoDB();
            eiDB.Add(eventInfoConfirm);
        }

        public List<EventInfoConfirm> GetAllEventInfo(string SID, string username, string language)
        {
            /// Creates a UserController which will get a user from the database by its sessionID.
            UserController uc = new UserController();
            User user = uc.GetUserBySID(SID, username, language);
            
            //Return empty list if sessionID has expired
            if (user.SessionID == "")
            {                
                return new List<EventInfoConfirm>();
            }            
            /// Creates a RepositoryEventInfoDB to get a list of EventInfoConfirms.
            RepositoryEventInfoDB eiDB = new RepositoryEventInfoDB();
            List<EventInfoConfirm> eventInfoConfirms = eiDB.GetAllEventInfo(user);

            /// Returns list of EventInfoConfirms.
            return eventInfoConfirms;            
        }

        public EventInfoConfirm GetEventInfoByID(int eventInfoID, string SID, string username, string language)
        {
            /// Creates a UserController which will get a user from the database by its sessionID.
            UserController uc = new UserController();
            User user = uc.GetUserBySID(SID, username, language);
            
            //Return empty object if sessionID has expired
            if (user.SessionID == "")
            {
                return new EventInfoConfirm();
            }
            /// Creates an EventInfoDB get a list of EventInfoConfirms.
            RepositoryEventInfoDB eiDB = new RepositoryEventInfoDB();
            EventInfoConfirm eiConfirm = eiDB.GetEventInfoByID(eventInfoID, user);

            /// Returns EventInfoConfirm.
            return eiConfirm;
        }
    }
}
