using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilWebAPI.Models
{
    public class EventInfo
    {
        private float lon;
        private float lat;
        private int confirmCount;
        private EventInfoType eIType;

        public float Lon { get; set; }
        public float Lat { get; set; }
        public int ConfirmCount { get; set; }
        public EventInfoType EIType { get; set; } 

        public EventInfo(float lon, float lat, int confirmCount, EventInfoType eIType)
        {
            Lon = lon;
            Lat = lat;
            ConfirmCount = confirmCount;
            EIType = eIType;
        }
    }
}