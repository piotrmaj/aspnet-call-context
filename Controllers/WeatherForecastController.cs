using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CallContext.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [TestFilter]
    [GlobalExceptionFilter]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _logger.LogRequestId("WeatherForecastController constructor before:");
            CallContext.SetRequestId("WeatherForecastController constructor ");
            _logger.LogRequestId("WeatherForecastController constructor after:");
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            _logger.LogRequestId("Get before:");
            CallContext.SetRequestId("Get");
            _logger.LogRequestId("Get after:");

            MethodSync();
            _logger.LogRequestId("Get after MethodSync:");
            await MethodAsync();
            _logger.LogRequestId("Get after MethodAsync:");

            throw new ArgumentException("test");
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
        }

        private void MethodSync()
        {
            _logger.LogRequestId("MethodSync before:");
            CallContext.SetRequestId("MethodSync");
            _logger.LogRequestId("MethodSync after:");
        }

        private async Task MethodAsync()
        {
            await Task.Delay(0);
            _logger.LogRequestId("MethodAsync before:");
            CallContext.SetRequestId("MethodAsync");
            _logger.LogRequestId("MethodAsync after:");

            await MethodAsyncNested();

            _logger.LogRequestId("MethodAsync after Nested:");
        }

        private async Task MethodAsyncNested()
        {
            await Task.Delay(0);
            _logger.LogRequestId("MethodAsyncNested before:");
            CallContext.SetRequestId("MethodAsyncNested");
            _logger.LogRequestId("MethodAsyncNested after:");
        }
    }
}