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
        public void Post(int eventInfoTypeID, float lon, float lat, string regNo)
        {
        }

        public List<EventInfoConfirm> GetEventInfo(string SID, string username, string language)
        {
            
            return new List<EventInfoConfirm>();
        }

        public EventInfoConfirm GetEventInfoByID(int eventInfoId, string SID, string username, string language)
        {
            return new EventInfoConfirm(new DateTime(), new EventInfo(0f, 0f, 0, new EventInfoType("0", "0", 0)), new User());
        }
    }
    

    //    public List<List<string>> Get(string language)
    //    {
    //        DBEIDAL dbeidal = new DBEIDAL();
    //        return dbeidal.GetEventInfo(language);
    //    }

    //    override public List<string> Get(int event_info_id, string language)
    //    {
    //        DBEIDAL dbeidal = new DBEIDAL();
    //        return dbeidal.GetEventInfoByID(event_info_id, language);
    //    }

    //    override public void Post(int eventTypeID, float lon, float lat, string userRegNo)
    //    {
    //        EventInfo ei = new EventInfo();
    //        ei.EventInfoType = eventTypeID;
    //        ei.Lon = lon;
    //        ei.Lat = lat;
    //        ei.UserRegNo = userRegNo;
    //        //
    //        DBEIDAL dbeidal = new DBEIDAL();
    //        dbeidal.SaveEventInfo(ei.EventInfoType, ei.Lon, ei.Lat, ei.UserRegNo);
    //    }
    //}
}
