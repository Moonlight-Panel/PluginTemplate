using Microsoft.AspNetCore.Mvc;
using MoonlightPluginTemplate.ApiServer.Services;
using MoonlightPluginTemplate.Shared.Http.Responses;

namespace MoonlightPluginTemplate.ApiServer.Http.Controllers;

[ApiController]
[Route("api/example")]
public class ExampleController : Controller
{
    private readonly ExampleService ExampleService;

    public ExampleController(ExampleService exampleService)
    {
        ExampleService = exampleService;
    }

    [HttpGet]
    public async Task<ExampleResponse> Get()
    {
        var val = await ExampleService.GetValue();

        return new ExampleResponse()
        {
            Number = val
        };
    }
}