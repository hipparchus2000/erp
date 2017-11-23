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
    public class SalesOrderItemServiceTest
    {
        UnityContainer _container;

        public SalesOrderItemServiceTest()
        {
            var repMock = new Mock<ISalesOrderItemRepo>();

            //todo this would be quite useless of course, need to mock the repo below the service
            _container.RegisterInstance<ISalesOrderItemRepo>(repMock.Object);
            var _orderController = _container.Resolve<SalesOrderItemService>();
        }


        [TestMethod]
        public void Get()
        {
            //// Arrange
            //SalesOrderItemService controller = _container.Resolve<SalesOrderItemService>();

            //// Act
            //IEnumerable<string> result = controller.Get();

            //// Assert
            //Assert.IsNotNull(result);
            //Assert.AreEqual(2, result.Count());
            //Assert.AreEqual("value1", result.ElementAt(0));
            //Assert.AreEqual("value2", result.ElementAt(1));
            Assert.Fail();
        }

        [TestMethod]
        public void GetById()
        {
            //// Arrange
            //SalesOrderItemService controller = _container.Resolve<SalesOrderItemService>();

            //// Act
            //string result = controller.Get(5);

            //// Assert
            //Assert.AreEqual("value", result);
            Assert.Fail();
        }

        [TestMethod]
        public void Post()
        {
            //// Arrange
            //SalesOrderItemService controller = _container.Resolve<SalesOrderItemService>();

            //// Act
            //controller.Post("value");

            //// Assert
            Assert.Fail();
        }

        [TestMethod]
        public void Put()
        {
            //// Arrange
            //SalesOrderItemService controller = _container.Resolve<SalesOrderItemService>();

            //// Act
            //controller.Put(5, "value");

            //// Assert
            Assert.Fail();
        }

        [TestMethod]
        public void Delete()
        {
            //// Arrange
            //SalesOrderItemService controller = _container.Resolve<SalesOrderItemService>();

            //// Act
            //controller.Delete(5);

            //// Assert
            Assert.Fail();
        }
    }
}
