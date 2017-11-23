using ERPIServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace ERP.Tests.Controllers
{
    [Authorize]
    public class PurchaseOrderController : ApiController
    {
        IPurchaseOrderService _orderService;

        public PurchaseOrderController(IPurchaseOrderService orderService)
        {
            _orderService = orderService; 
        }

        public void Put(int v1, string v2)
        {
            throw new NotImplementedException();
        }

        public void Delete(int v)
        {
            throw new NotImplementedException();
        }

        public void Post(string v)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Get()
        {
            throw new NotImplementedException();
        }

        public string Get(int v)
        {
            throw new NotImplementedException();
        }
    }
}