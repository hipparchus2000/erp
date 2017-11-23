using ERPdto.dtos;
using System;

namespace ERPServiceLayer.Services
{
    public interface ISalesOrderRepo
    {   
        SalesOrderDto Get(Guid id);
        void Post(SalesOrderDto model);
        object Get();
        void Delete(Guid id);
    }
}