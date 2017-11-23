using ERPmodels.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPIServices.Interfaces
{
    public interface ISalesOrderService
    {
        SalesOrderModel[] Get();
        SalesOrderModel Get(Guid id);
        void Post(SalesOrderModel value);
        void Put(Guid id, SalesOrderModel value);
        void Delete(Guid id);
    }
}
