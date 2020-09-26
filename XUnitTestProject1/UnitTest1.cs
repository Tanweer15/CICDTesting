using System;
using TestPipeline.Controllers;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        WeatherForecastController weatherct = new WeatherForecastController();
        [Fact]
        public void Test1()
        {
            var returnValue = weatherct.Get();
            Assert.Equal("Tanweer11", returnValue);
        }
       
    }
}
