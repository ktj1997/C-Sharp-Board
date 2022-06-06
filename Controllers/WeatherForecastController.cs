using Microsoft.AspNetCore.Mvc;

namespace C_Sharp_Board.Controllers;

[ApiController] // REST API Controller를 의미하는 설정
[Route("api/v1/")]
public class WeatherForecastController : ControllerBase 
    /**
      * ControllerBase --> REST API 
      * Controller -> MVC Controller
      */
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    /**
	  * Dependency Injection
	  */
    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet("weathers")] 
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
