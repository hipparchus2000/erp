using ERPIServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERPmodels.models;

namespace ERPServiceLayer.Services
{
    public class PurchaseOrderService : IPurchaseOrderService
    {
        IPurchaseOrderRepo _repo;

        public PurchaseOrderService(IPurchaseOrderRepo repo)
        {
            _repo = repo;
        }

        PurchaseOrderItemModel[] IPurchaseOrderService.Get()
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
