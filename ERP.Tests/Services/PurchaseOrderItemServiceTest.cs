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
    public class PurchaseOrderItemServiceTest
    {
        UnityContainer _container;

        public PurchaseOrderItemServiceTest()
        {
            var repMock = new Mock<IPurchaseOrderItemRepo>();

            _container.RegisterInstance<IPurchaseOrderItemRepo>(repMock.Object);
            var _orderController = _container.Resolve<PurchaseOrderItemService>();
        }


        [TestMethod]
        public void Get()
        {
            // Arrange
            PurchaseOrderItemService controller = _container.Resolve<PurchaseOrderItemService>();

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
            PurchaseOrderItemService controller = _container.Resolve<PurchaseOrderItemService>();

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            PurchaseOrderItemService controller = _container.Resolve<PurchaseOrderItemService>();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            PurchaseOrderItemService controller = _container.Resolve<PurchaseOrderItemService>();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            PurchaseOrderItemService controller = _container.Resolve<PurchaseOrderItemService>();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
