using ERPIServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERPdto.dtos;
using AutoMapper;
using System.Collections;
using ERPmodels.models;

namespace ERPServiceLayer.Services
{
    public class SalesOrderService : ISalesOrderService
    {
        ISalesOrderRepo _repo;
        
        public SalesOrderService(ISalesOrderRepo repo)
        {
            _repo = repo;
        }

        public SalesOrderModel Get(Guid id)
        {
            var dto = _repo.Get(id);
            var model = Mapper.Map<SalesOrderModel>(dto);
            return model;
        }

        public void Post(SalesOrderModel model)
        {
            var dto = Mapper.Map<SalesOrderDto>(model);
            _repo.Post(dto);
        }

        public void Put(SalesOrderModel model)
        {
            var dto = Mapper.Map<SalesOrderDto>(model);
            _repo.Post(dto);
        }

        public IEnumerable<string> Get()
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid Id)
        {
            _repo.Delete(Id);
        }

        SalesOrderModel[] ISalesOrderService.Get()
        {
            //var dtoList = _repo.Get();
            //var model = Mapper.Map <IList<SalesOrderModel> > dtoList;
            //todo add list get 
            throw new NotImplementedException();
        }

        public void Put(Guid id, SalesOrderModel value)
        {
            throw new NotImplementedException();
        }
    }
}
