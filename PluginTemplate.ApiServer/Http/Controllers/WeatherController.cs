using Microsoft.AspNetCore.Mvc;
using Moonlight.ApiServer.App.Attributes;
using PluginTemplate.ApiServer.Services;
using PluginTemplate.Shared.Http.Responses;

namespace PluginTemplate.ApiServer.Http.Controllers;

[ApiController]
[Route("weather")]
public class WeatherController : Controller
{
    private readonly WeatherService WeatherService;

    public WeatherController(WeatherService weatherService)
    {
        WeatherService = weatherService;
    }

    [HttpGet("location")]
    [RequirePermission("meta.authenticated")]
    public async Task<ActionResult<WeatherResponse>> Get([FromQuery] string name)
    {
        return Ok(new WeatherResponse()
        {
            Description = "Cloudy",
            Location = name,
            DegreeC = await WeatherService.GetTemperatureForLocation(name)
        });
    }
}