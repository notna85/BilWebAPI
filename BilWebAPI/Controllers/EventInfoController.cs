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
            List<List<string>> eventInfoList = null;

            // eventInfoLost = [Call DAL method]

            return eventInfoList;
        }

        override public void Post([FromBody]int eventTypeID, float lon, float lat, string userRegNo)
        {
            EventInfo ei = new EventInfo();
            ei.EventInfoType = eventTypeID;
            ei.Lon = lon;
            ei.Lat = lat;
            ei.UserRegNo = userRegNo;

            //Call DAL method
        }
    }
}
