using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilWebAPI.Models
{
    public class EventInfoConfirm
    {
        private DateTime time;
        private EventInfo ei;
        private User user;

        public DateTime Time { get; set; }
        public EventInfo EI { get; set; }
        public User User { get;  set; }

        public EventInfoConfirm()
        {

        }
        public EventInfoConfirm(User user)
        {
            User = user;
        }

        public EventInfoConfirm(int eventInfoTypeID, decimal lon, decimal lat, User user)
        {
            Time = DateTime.Now;
            EI = new EventInfo(eventInfoTypeID, lon, lat);
            User = user;
        }

        public EventInfoConfirm(int eventInfoTypeID, decimal lon, decimal lat, int confirmCount, User user, string title, string description, int eventID)
        {
            Time = DateTime.Now;
            EI = new EventInfo(lon, lat, confirmCount, eventInfoTypeID, title, description, eventID);
            User = user;
        }
    }
}