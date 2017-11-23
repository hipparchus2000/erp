using System;
using ERPdto.dtos;

namespace ERPServiceLayer.Services
{
    public class FakeSalesOrderItemRepo : ISalesOrderItemRepo
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public SalesOrderItemDto[] Get()
        {
            throw new NotImplementedException();
        }

        public SalesOrderItemDto Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Post(SalesOrderItemDto value)
        {
            throw new NotImplementedException();
        }

        public void Put(Guid id, SalesOrderItemDto value)
        {
            throw new NotImplementedException();
        }
    }
}