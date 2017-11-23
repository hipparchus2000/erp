using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using ERP.Controllers;
using ERPIServices.Interfaces;
using Moq;
using Unity;
using ERPdto.dtos;
using ERPmodels.models;

namespace ERP.Tests.Controllers
{
    [TestClass]
    public class SalesOrderItemControllerTest
    {
        UnityContainer _container;

        public SalesOrderItemControllerTest()
        {
            ERPmapper.ERPmapper.SetupAutomapper();
        }

        [TestMethod]
        public void Get()
        {
            // Arrange
            var _service = new Mock<ISalesOrderItemService>();
            _container.RegisterInstance<ISalesOrderItemService>(_service.Object);
            var salesOrder1 = new SalesOrderItemModel
            {
                Created = DateTime.UtcNow,
                Description = "test1",
                ID = Guid.NewGuid(),
                Submitted = null
            };
            var salesOrder2 = new SalesOrderItemModel
            {
                Created = DateTime.UtcNow,
                Description = "test1",
                ID = Guid.NewGuid(),
                Submitted = null
            };
            var salesOrders = new List<SalesOrderItemModel>();
            salesOrders.Add(salesOrder1);
            salesOrders.Add(salesOrder2);
            _service.Setup(x => x.Get()).Returns(salesOrders.ToArray());
            var controller = _container.Resolve<SalesOrderItemController>();

            // Act
            IEnumerable<SalesOrderItemModel> result = controller.Get();

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
            var _service = new Mock<ISalesOrderItemService>();
            _container.RegisterInstance<ISalesOrderItemService>(_service.Object);
            var salesOrder1 = new SalesOrderItemModel
            {
                Created = DateTime.UtcNow,
                Description = "test1",
                ID = Guid.NewGuid(),
                Submitted = null
            };
            var salesOrder2 = new SalesOrderItemModel
            {
                Created = DateTime.UtcNow,
                Description = "test1",
                ID = Guid.NewGuid(),
                Submitted = null
            };
            var salesOrders = new List<SalesOrderItemModel>();
            salesOrders.Add(salesOrder1);
            salesOrders.Add(salesOrder2);
            _service.Setup(x => x.Get()).Returns(salesOrders.ToArray());
            SalesOrderItemController controller = _container.Resolve<SalesOrderItemController>();

            // Act
            var result = controller.Get(salesOrder2.ID);

            // Assert
            Assert.AreEqual(salesOrder2, result);
        }

        [TestMethod]
        public void Post()
        {
            //controller.Post("value");
            // Arrange
            var _service = new Mock<ISalesOrderItemService>();
            _container.RegisterInstance<ISalesOrderItemService>(_service.Object);
            var salesOrder1 = new SalesOrderItemModel
            {
                Created = DateTime.UtcNow,
                Description = "test1",
                ID = Guid.NewGuid(),
                Submitted = null
            };
            var salesOrder2 = new SalesOrderItemModel
            {
                Created = DateTime.UtcNow,
                Description = "test1",
                ID = Guid.NewGuid(),
                Submitted = null
            };
            var salesOrders = new List<SalesOrderItemModel>();
            salesOrders.Add(salesOrder1);
            salesOrders.Add(salesOrder2);
            _service.Setup(x => x.Get()).Returns(salesOrders.ToArray());
            SalesOrderItemController controller = _container.Resolve<SalesOrderItemController>();

            // Act
            controller.Post(salesOrder2);

            // Assert
            _service.Verify(x => x.Post(salesOrder2), Times.Exactly(1));

        }

        [TestMethod]
        public void Put()
        {
            //controller.Post("value");
            // Arrange
            var _service = new Mock<ISalesOrderItemService>();
            _container.RegisterInstance<ISalesOrderItemService>(_service.Object);
            var salesOrder1 = new SalesOrderItemModel
            {
                Created = DateTime.UtcNow,
                Description = "test1",
                ID = Guid.NewGuid(),
                Submitted = null
            };
            var salesOrder2 = new SalesOrderItemModel
            {
                Created = DateTime.UtcNow,
                Description = "test1",
                ID = Guid.NewGuid(),
                Submitted = null
            };
            var salesOrders = new List<SalesOrderItemModel>();
            salesOrders.Add(salesOrder1);
            salesOrders.Add(salesOrder2);
            _service.Setup(x => x.Get()).Returns(salesOrders.ToArray());
            SalesOrderItemController controller = _container.Resolve<SalesOrderItemController>();

            // Act
            controller.Put(salesOrder2.ID, salesOrder2);

            // Assert
            //_service.Verify(x => Put(salesOrder2.ID, salesOrder2), Times.Exactly(1));
            Assert.Fail();
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            //SalesOrderItemController controller = new SalesOrderItemController();

            // Act
            //controller.Delete(5);


            // Assert
            Assert.Fail();
        }

    }
}
