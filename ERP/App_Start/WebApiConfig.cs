using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using Unity;
using ERPIServices.Interfaces;
using ERPServiceLayer.Services;
using Unity.Lifetime;
using AutoMapper;
using ERPmodels.models;
using ERPdto.dtos;
using ERPmapper;

namespace ERP
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();
            container.RegisterType<ISalesOrderService, SalesOrderService>(new HierarchicalLifetimeManager());
            container.RegisterType<ISalesOrderItemService, SalesOrderItemService>(new HierarchicalLifetimeManager());
            container.RegisterType<IPurchaseOrderService, PurchaseOrderService>(new HierarchicalLifetimeManager());
            container.RegisterType<IPurchaseOrderItemService, PurchaseOrderItemService>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);

            ERPmapper.ERPmapper.SetupAutomapper();

            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        
    }
}
