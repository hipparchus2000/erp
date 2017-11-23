using ERPIServices.Interfaces;
using ERPmodels.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ERP.Controllers
{
    [Authorize]
    public class SalesOrderItemController : ApiController
    {
        ISalesOrderItemService _orderService;

        public SalesOrderItemController(ISalesOrderItemService orderService)
        {
            _orderService = orderService;
        }

        // GET: api/OrderItem
        public IEnumerable<SalesOrderItemModel> Get()
        {
            return _orderService.Get();
        }

        // GET: api/OrderItem/2342342345
        public SalesOrderItemModel Get(Guid id)
        {
            return _orderService.Get(id);
        }

        // POST: api/OrderItem
        public void Post([FromBody]SalesOrderItemModel value)
        {
            _orderService.Post(value);
        }

        // PUT: api/OrderItem/533454
        public void Put(Guid id, [FromBody]SalesOrderItemModel value)
        {
            _orderService.Put(id, value);
        }

        // DELETE: api/OrderItem/52342342
        public void Delete(Guid id)
        {
            _orderService.Delete(id);
        }

    }
}
