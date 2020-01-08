using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilWebAPI.Models
{
    public class EventInfo
    {
        private decimal lon;
        private decimal lat;
        private int confirmCount;
        private EventInfoType eIType;

        public decimal Lon { get; set; }
        public decimal Lat { get; set; }
        public int ConfirmCount { get; set; }
        public EventInfoType EIType { get; set; } 

        public EventInfo()
        {

        }
        public EventInfo(decimal lon, decimal lat, int confirmCount, int eventInfoTypeID, string title, string description)
        {
            Lon = lon;
            Lat = lat;
            ConfirmCount = confirmCount;
            EIType = new EventInfoType(title, description, eventInfoTypeID);
        }
    }
}