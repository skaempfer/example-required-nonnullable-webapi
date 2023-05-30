using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace example_required_nonnullable.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpPost(Name = "PostWeatherForecast")]
    public ActionResult Post(WeatherForecast forecast){
        Console.WriteLine($"{forecast.TemperatureC} - {forecast.Date}");
        return NoContent();
    }
}

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    [JsonProperty(Required = Required.Always)]
    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}
