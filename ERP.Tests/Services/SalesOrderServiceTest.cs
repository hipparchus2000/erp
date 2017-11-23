using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;
using ERPServiceLayer.Services;
using Moq;
using System.Collections.Generic;
using System.Linq;
using ERPmodels.models;
using ERPIServices.Interfaces;

namespace ERP.Tests.Services
{
    [TestClass]
    public class SalesOrderServiceTest
    {
        UnityContainer _container;

        public SalesOrderServiceTest()
        {
            var repMock = new Mock<ISalesOrderRepo>();

            _container.RegisterInstance<ISalesOrderRepo>(repMock.Object);
            var _orderController = _container.Resolve<SalesOrderService>();
        }


        [TestMethod]
        public void Get()
        {
            // Arrange
            SalesOrderService controller = _container.Resolve<SalesOrderService>();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
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
            Controllers.SalesOrderController controller = _container.Resolve<Controllers.SalesOrderController>();

            // Act
            var result = controller.Get(salesOrder2.ID);

            // Assert
            Assert.AreEqual(salesOrder2, result);
        }

        [TestMethod]
        public void Post()
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
            Controllers.SalesOrderController controller = _container.Resolve<Controllers.SalesOrderController>();

            // Act
            controller.Post(salesOrder1);

            // Assert
//            Assert.AreEqual(salesOrder2, result);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            SalesOrderService controller = _container.Resolve<SalesOrderService>();

            // Act
            //controller.Put(5, "value");

            // Assert

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            SalesOrderService controller = _container.Resolve<SalesOrderService>();

            // Act
            //controller.Delete(5);


            // Assert
            Assert.Fail();
        }
    }
}
