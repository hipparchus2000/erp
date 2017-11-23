using AutoMapper;
using ERPdto.dtos;
using ERPmodels.models;
using System;

namespace ERPmapper
{
    public static class ERPmapper
    {
        public static void SetupAutomapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<SalesOrderModel, SalesOrderDto>().ReverseMap();
                cfg.CreateMap<SalesOrderItemModel, SalesOrderItemDto>().ReverseMap();
                cfg.CreateMap<PurchaseOrderModel, PurchaseOrderDto>().ReverseMap();
                cfg.CreateMap<PurchaseOrderItemModel, PurchaseOrderItemDto>().ReverseMap();
            });
        }
        
    }
}
