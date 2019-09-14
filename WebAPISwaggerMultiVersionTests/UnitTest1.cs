using System.Web.Http.Results;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using WebAPI2Swagger.Controllers.V1;

namespace WebAPISwaggerMultiVersionTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Get_ReturnsRightValues()
        {
            //Arrange
            var values = new string[] { "value1 of v1", "value2 of v1" };
            var controller = new ValuesController();

            //Act
            var results = controller.Get() as OkNegotiatedContentResult<string[]>;

            //Assert
            Assert.IsInstanceOfType(results, typeof(OkNegotiatedContentResult<string[]>));
            CollectionAssert.AreEqual(values, results.Content);
        }
    }
}
