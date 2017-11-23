using ERPIServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERPmodels.models;

namespace ERPServiceLayer.Services
{
    public class SalesOrderItemService : ISalesOrderItemService
    {
        ISalesOrderItemRepo _repo;

        public SalesOrderItemService(ISalesOrderItemRepo repo)
        {
            _repo = repo;
        }


        SalesOrderItemModel[] ISalesOrderItemService.Get()
        {
            throw new NotImplementedException();
        }

        public SalesOrderItemModel Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Post(SalesOrderItemModel value)
        {
            throw new NotImplementedException();
        }

        public void Put(Guid id, SalesOrderItemModel value)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
