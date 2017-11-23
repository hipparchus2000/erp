using ERPIServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Web.Http;
using ERPmodels.models;

namespace ERP.Tests.Controllers
{
    [Authorize]
    public class SalesOrderController : ApiController
    {
        ISalesOrderService _orderService;

        public SalesOrderController(ISalesOrderService orderService)
        {
            _orderService = orderService; 
        }

        public IEnumerable<SalesOrderModel> Get()
        {
            throw new NotImplementedException();
        }

        public SalesOrderModel Get(Guid iD)
        {
            throw new NotImplementedException();
        }

        public void Post(SalesOrderModel salesOrder1)
        {
            throw new NotImplementedException();
        }

        public void Put(Guid id, SalesOrderModel salesOrder1)
        {
            throw new NotImplementedException();
        }

        public void Delete(Func<Guid> newGuid)
        {
            throw new NotImplementedException();
        }
    }
}