using ERPmodels.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPIServices.Interfaces
{
    public interface ISalesOrderItemService
    {
        SalesOrderItemModel[] Get();
        SalesOrderItemModel Get(Guid id);
        void Post(SalesOrderItemModel value);
        void Put(Guid id, SalesOrderItemModel value);
        void Delete(Guid id);
    }
}
