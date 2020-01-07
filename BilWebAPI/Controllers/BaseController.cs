using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BilWebAPI.Models;

namespace BilWebAPI.Controllers
{
    public abstract class BaseController : ApiController
    {
        public virtual List<List<string>> Get(string value)
        {
            return new List<List<string>> { };
        }

        public virtual List<string> Get(int eventInfoID, string value)
        {
            return new List<string> { };
        }

        public virtual void Post(string value)
        {
        }
        public virtual void Post(int value1, float value2, float value3, string value4)
        {
        }

        public virtual void Put(int id, string value)
        {

        }

        public virtual void Delete(int id)
        {

        }
    }
}
