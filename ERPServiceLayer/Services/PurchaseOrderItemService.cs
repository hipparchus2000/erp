using ERPIServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERPmodels.models;

namespace ERPServiceLayer.Services
{
    public class PurchaseOrderItemService : IPurchaseOrderItemService
    {
        IPurchaseOrderItemRepo _repo;

        public PurchaseOrderItemService(IPurchaseOrderItemRepo repo)
        {
            _repo = repo;
        }

        PurchaseOrderItemModel[] IPurchaseOrderItemService.Get()
        {
            throw new NotImplementedException();
        }

        public PurchaseOrderItemModel Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Post(PurchaseOrderItemModel value)
        {
            throw new NotImplementedException();
        }

        public void Put(Guid id, PurchaseOrderItemModel value)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
