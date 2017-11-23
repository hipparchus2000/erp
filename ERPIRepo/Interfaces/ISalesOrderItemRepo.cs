using ERPdto.dtos;
using System;

namespace ERPServiceLayer.Services
{
    public interface ISalesOrderItemRepo
    {
        SalesOrderItemDto[] Get();
        SalesOrderItemDto Get(Guid id);
        void Post(SalesOrderItemDto value);
        void Put(Guid id, SalesOrderItemDto value);
        void Delete(Guid id);
    }
}