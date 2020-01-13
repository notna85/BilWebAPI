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
        private int id;

        public decimal Lon { get; set; }
        public decimal Lat { get; set; }
        public int ConfirmCount { get; set; }
        public EventInfoType EIType { get; set; } 
        public int ID { get; set; }
        public int TimeSinceLastConfirm { get; set; }

        public EventInfo()
        {

        }
        public EventInfo(int eventInfoTypeID, decimal lon, decimal lat)
        {
            Lon = lon;
            Lat = lat;
            EIType = new EventInfoType(eventInfoTypeID);
        }
        public EventInfo(decimal lon, decimal lat, int confirmCount, int eventInfoTypeID, string title, string description, int id, int timeSinceLastConfirm)
        {
            Lon = lon;
            Lat = lat;
            ConfirmCount = confirmCount;
            EIType = new EventInfoType(title, description, eventInfoTypeID);
            ID = id;
            TimeSinceLastConfirm = timeSinceLastConfirm;
        }
        public EventInfo(decimal lon, decimal lat, int confirmCount, int eventInfoTypeID, string title, string description, int id)
        {
            Lon = lon;
            Lat = lat;
            ConfirmCount = confirmCount;
            EIType = new EventInfoType(title, description, eventInfoTypeID);
            ID = id;
        }
    }
}