using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BilWebAPI.Controllers
{
    public abstract class BaseController : ApiController
    {
        // GET: api/Base
        public virtual IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Base/5
        protected virtual string Get(int id)
        {
            return "value";
        }

        // POST: api/Base
        public virtual void Post([FromBody]string value)
        {

        }

        // PUT: api/Base/5
        public virtual void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Base/5
        public virtual void Delete(int id)
        {

        }
    }
}
