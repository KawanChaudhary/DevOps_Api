using DevOpsApi;
using DevOpsApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Devops_Api.Test
{
    [TestFixture]
    public class WeatherForecastControllerTests
    {
        [Test]
        public void Get()
        {
            // Arrange
            WeatherForecastController controller = new WeatherForecastController();

            // Act
            var result = controller.Get();

            Assert.IsNotNull(result);
        }
    }
}