using ERPdto.dtos;
using System;

namespace ERPServiceLayer.Services
{
    public interface ISalesOrderRepo
    {
        SalesOrderDto[] Get();
        SalesOrderDto Get(Guid id);
        void Post(SalesOrderDto value);
        void Put(Guid id, SalesOrderDto value);
        void Delete(Guid id);
    }
}