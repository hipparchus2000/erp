using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERPServiceLayer.Services;
using Unity;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace ERP.Tests.Services
{
    [TestClass]
    public class PurchaseOrderServiceTest
    {
        UnityContainer _container;

        public PurchaseOrderServiceTest()
        {
            var repMock = new Mock<IPurchaseOrderRepo>();

            _container.RegisterInstance<IPurchaseOrderRepo>(repMock.Object);
            var _orderController = _container.Resolve<PurchaseOrderService>();
        }


        [TestMethod]
        public void Get()
        {
            // Arrange
            PurchaseOrderService controller = _container.Resolve<PurchaseOrderService>();

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
            PurchaseOrderService controller = _container.Resolve<PurchaseOrderService>();

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            PurchaseOrderService controller = _container.Resolve<PurchaseOrderService>();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            PurchaseOrderService controller = _container.Resolve<PurchaseOrderService>();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            PurchaseOrderService controller = _container.Resolve<PurchaseOrderService>();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
