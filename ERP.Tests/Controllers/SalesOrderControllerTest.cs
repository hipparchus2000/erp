using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Moq;
using Unity;
using ERPIServices.Interfaces;
using ERPdto.dtos;
using ERPmodels.models;
using ERPmapper;

namespace ERP.Tests.Controllers
{
    [TestClass]
    public class SalesOrderControllerTest
    {
        UnityContainer _container;
        
        public SalesOrderControllerTest()
        {
            ERPmapper.ERPmapper.SetupAutomapper();
        }


        [TestMethod]
        public void Get()
        {
            // Arrange
            var _service = new Mock<ISalesOrderService>();
            _container.RegisterInstance<ISalesOrderService>(_service.Object);
            var salesOrder1 = new SalesOrderModel
            {
                Created = DateTime.UtcNow,
                Description = "test1",
                ID = Guid.NewGuid(),
                Submitted = null
            };
            var salesOrder2 = new SalesOrderModel
            {
                Created = DateTime.UtcNow,
                Description = "test1",
                ID = Guid.NewGuid(),
                Submitted = null
            };
            var salesOrders = new List<SalesOrderModel>();
            salesOrders.Add(salesOrder1);
            salesOrders.Add(salesOrder2);
            _service.Setup(x => x.Get()).Returns(salesOrders.ToArray());
            SalesOrderController controller = _container.Resolve<SalesOrderController>();
            
            // Act
            IEnumerable<SalesOrderModel> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual(salesOrder1, result.ElementAt(0));
            Assert.AreEqual(salesOrder2, result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            var _service = new Mock<ISalesOrderService>();
            _container.RegisterInstance<ISalesOrderService>(_service.Object);
            var salesOrder1 = new SalesOrderModel
            {
                Created = DateTime.UtcNow,
                Description = "test1",
                ID = Guid.NewGuid(),
                Submitted = null
            };
            var salesOrder2 = new SalesOrderModel
            {
                Created = DateTime.UtcNow,
                Description = "test1",
                ID = Guid.NewGuid(),
                Submitted = null
            };
            var salesOrders = new List<SalesOrderModel>();
            salesOrders.Add(salesOrder1);
            salesOrders.Add(salesOrder2);
            _service.Setup(x => x.Get()).Returns(salesOrders.ToArray());
            SalesOrderController controller = _container.Resolve<SalesOrderController>();

            // Act
            var result = controller.Get(salesOrder2.ID);

            // Assert
            Assert.AreEqual(salesOrder2, result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            ///SalesOrderController controller = _container.Resolve<SalesOrderController>();

            // Act
            //controller.Post("value");

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            //SalesOrderController controller = _container.Resolve<SalesOrderController>();

            // Act
            //controller.Put(5, "value");

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            SalesOrderController controller = _container.Resolve<SalesOrderController>();

            // Act
            controller.Delete(Guid.NewGuid);

            // Assert
        }
    }
}
