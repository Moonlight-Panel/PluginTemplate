using MoonCore.Extensions;
using Moonlight.ApiServer.Interfaces.Startup;

namespace MoonlightPluginTemplate.ApiServer.Startup;

public class PluginStartup : IAppStartup
{
    private readonly ILogger<PluginStartup> Logger;

    public PluginStartup(ILogger<PluginStartup> logger)
    {
        Logger = logger;
    }

    public Task BuildApp(IHostApplicationBuilder builder)
    {
        Logger.LogInformation("Elo World from MoonlightPluginTemplate");
        
        // Scan the current plugin assembly for di services
        builder.Services.AutoAddServices<PluginStartup>();
        
        return Task.CompletedTask;
    }

    public Task ConfigureApp(IApplicationBuilder app)
    {
        return Task.CompletedTask;
    }
}