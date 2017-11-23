using System;
using ERPdto.dtos;

namespace ERPServiceLayer.Services
{
    public class SalesOrderRepo : ISalesOrderRepo
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public SalesOrderDto Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public object Get()
        {
            throw new NotImplementedException();
        }

        public void Post(SalesOrderDto model)
        {
            throw new NotImplementedException();
        }

        public void Put(Guid id, SalesOrderDto value)
        {
            throw new NotImplementedException();
        }

        SalesOrderDto[] ISalesOrderRepo.Get()
        {
            throw new NotImplementedException();
        }
    }
}