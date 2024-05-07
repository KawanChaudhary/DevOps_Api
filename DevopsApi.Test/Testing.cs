using DevOpsApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace DevopsApi.Test
{
    public class Testing : IClassFixture<WeatherForecastController>
    {
        private WeatherForecastController controller;

        public Testing(WeatherForecastController _controller)
        {
            this.controller = _controller;
        }

        [Fact]
        public void Test1()
        {

            //Act
            var result = controller.Get() as ViewResult;

            //Assert
            Assert.NotNull(result);

        }
    }
}