using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;
using UnitTesting.Controllers;
using UnitTesting.Models;

 namespace UnitTesting.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestIndexMethod()
        {
            //Arrange
            var controller = new HomeController();
            string viewName = "Index";
            string name = "Arpit";
            int id = 1;

            //Act
            var result = controller.Index() as ViewResult;
            var model = (EmployeeModel)result.Model;

            //Assert
            Assert.AreEqual(viewName, result.ViewName);
            Assert.AreEqual(name, model.Name);
            Assert.AreEqual(id, model.Id);
        }
    }
}
