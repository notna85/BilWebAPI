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
        override public List<List<string>> Get()
        {
            DBEIDAL dbeidal = new DBEIDAL();
            return dbeidal.GetEventInfo();
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
