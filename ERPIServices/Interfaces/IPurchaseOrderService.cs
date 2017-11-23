using ERPmodels.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPIServices.Interfaces
{
    public interface IPurchaseOrderService
    {
        PurchaseOrderItemModel[] Get();
        PurchaseOrderItemModel Get(Guid id);
        void Post(PurchaseOrderItemModel value);
        void Put(Guid id, PurchaseOrderItemModel value);
        void Delete(Guid id);
    }
}
