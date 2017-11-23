using ERPdto.dtos;
using System;

namespace ERPServiceLayer.Services
{
    public interface IPurchaseOrderItemRepo
    {
        PurchaseOrderItemDto[] Get();
        PurchaseOrderItemDto Get(Guid id);
        void Post(PurchaseOrderItemDto value);
        void Put(Guid id, PurchaseOrderItemDto value);
        void Delete(Guid id);
    }
}