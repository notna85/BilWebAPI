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

        public EventInfoConfirm(DateTime time, EventInfo ei, User user)
        {
            Time = time;
            EI = ei;
            User = user;
        }
    }
}