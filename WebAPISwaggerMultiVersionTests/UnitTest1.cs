using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPI2Swagger.Controllers.V1;

namespace WebAPISwaggerMultiVersionTests
{
    [TestClass]
    public class ValuesControllerTests
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
