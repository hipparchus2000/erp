using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ERP.Controllers
{
    [Authorize]
    public class PurchaseOrderItemController : ApiController
    {
        // GET: api/OrderItem
        public IEnumerable<string> Get()
        {
            throw new NotImplementedException();
        }

        // GET: api/OrderItem/5
        public string Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/OrderItem
        public void Post([FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // PUT: api/OrderItem/5
        public void Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/OrderItem/5
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
