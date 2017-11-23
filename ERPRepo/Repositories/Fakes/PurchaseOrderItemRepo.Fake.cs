using System;
using ERPdto.dtos;

namespace ERPServiceLayer.Services
{
    public class FakePurchaseOrderItemRepo : IPurchaseOrderItemRepo
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public PurchaseOrderItemDto[] Get()
        {
            throw new NotImplementedException();
        }

        public PurchaseOrderItemDto Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Post(PurchaseOrderItemDto value)
        {
            throw new NotImplementedException();
        }

        public void Put(Guid id, PurchaseOrderItemDto value)
        {
            throw new NotImplementedException();
        }
    }
}