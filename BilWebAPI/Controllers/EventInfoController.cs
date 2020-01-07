using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BilWebAPI.Models;

namespace BilWebAPI.Controllers
{
    public class EventInfoController : BaseController
    {
        public List<List<string>> GetEventInfo(string language)
        {
            DBEIDAL dbeidal = new DBEIDAL();
            return dbeidal.GetEventInfo(language);
        }

        public List<string> GetEventInfoByID(int eventInfoID, string language)
        {
            DBEIDAL dbeidal = new DBEIDAL();
            return dbeidal.GetEventInfoByID(eventInfoID, language);
        }

        override public void Post(int eventTypeID, float lon, float lat, string userRegNo)
        {
            EventInfo ei = new EventInfo();
            ei.EventInfoType = eventTypeID;
            ei.Lon = lon;
            ei.Lat = lat;
            ei.UserRegNo = userRegNo;
            //
            DBEIDAL dbeidal = new DBEIDAL();
            dbeidal.SaveEventInfo(ei.EventInfoType, ei.Lon, ei.Lat, ei.UserRegNo);
        }
    }
}
