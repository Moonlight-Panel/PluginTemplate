using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoonlightPluginTemplate.ApiServer.Services;
using MoonlightPluginTemplate.Shared.Http.Responses;

namespace MoonlightPluginTemplate.ApiServer.Http.Controllers;

[Authorize]
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
    public async Task<ActionResult<ExampleResponse>> GetAsync()
    {
        var val = await ExampleService.GetValueAsync();

        return new ExampleResponse()
        {
            Number = val
        };
    }
}