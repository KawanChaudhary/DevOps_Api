using DevOpsApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace DevopsApi.Test
{
    public class Testing
    {
        /*private WeatherForecastController controller;

        public Testing(WeatherForecastController _controller)
        {
            this.controller = _controller;
        }*/

        [Fact]
        public void Test1()
        {
            Console.WriteLine("Testing");

            var loggerMock = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(loggerMock.Object);


            //Act
            var result = controller.Get() as ViewResult;

            //Assert
            Assert.NotNull(result);

        }
    }
}