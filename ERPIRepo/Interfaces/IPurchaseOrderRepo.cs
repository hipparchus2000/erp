using ERPdto.dtos;
using System;

namespace ERPServiceLayer.Services
{
    public interface IPurchaseOrderRepo
    {
        PurchaseOrderDto[] Get();
        PurchaseOrderDto Get(Guid id);
        void Post(PurchaseOrderDto value);
        void Put(Guid id, PurchaseOrderDto value);
        void Delete(Guid id);
    }
}