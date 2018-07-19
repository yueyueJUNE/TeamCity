using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamCity.Controllers;

namespace TeamCity.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Index()
        {
            //Arrange
            HomeController homeController = new HomeController();
            //Act
            ViewResult result = homeController.Index() as ViewResult;
            //Assertion
            Assert.AreEqual("TEST", result.ViewData["Message"]);
            
        }

        [TestMethod]
        public void About()
        {
            //Arrange
            HomeController homeController = new HomeController();
            //Act
            ViewResult result = homeController.About() as ViewResult;
            //Assertion
            Assert.AreEqual("Your application description page.", result.ViewData["Message"]);
        }


        [TestMethod]
        public void Concat()
        {
            //Arrange
            HomeController homeController = new HomeController();
            //Act
            ViewResult result = homeController.Contact() as ViewResult;
            //Assertion
            Assert.AreEqual("Your contact page.", result.ViewData["Message"]);
        }
    }
}
