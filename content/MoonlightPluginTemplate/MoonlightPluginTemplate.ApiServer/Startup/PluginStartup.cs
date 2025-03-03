using MoonCore.Extensions;
using Moonlight.ApiServer.Interfaces.Startup;
using Moonlight.ApiServer.Services;
using MoonlightPluginTemplate.ApiServer.Database;

namespace MoonlightPluginTemplate.ApiServer.Startup;

public class PluginStartup : IPluginStartup
{
    private readonly ILogger<PluginStartup> Logger;

    public PluginStartup(ILogger<PluginStartup> logger)
    {
        Logger = logger;
    }

    public Task BuildApplication(IHostApplicationBuilder builder)
    {
        Logger.LogInformation("Elo World from MoonlightPluginTemplate");

        // Scan the current plugin assembly for di services
        builder.Services.AutoAddServices<PluginStartup>();

        builder.Services.AddDbContext<MoonlightPluginTemplateDataContext>();

        return Task.CompletedTask;
    }

    public Task ConfigureApplication(IApplicationBuilder app)
        => Task.CompletedTask;

    public Task ConfigureEndpoints(IEndpointRouteBuilder routeBuilder)
        => Task.CompletedTask;
}