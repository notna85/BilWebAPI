using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilWebAPI.Models
{
    public class EventInfo
    {
        public int EventInfoType { get; set; }
        public  string UserRegNo { get; set; }
        public float Lon { get; set; }
        public float Lat { get; set; }
    }
}