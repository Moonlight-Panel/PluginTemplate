using MoonCore.Extensions;
using Moonlight.ApiServer.Interfaces.Startup;
using Moonlight.ApiServer.Services;

namespace MoonlightPluginTemplate.ApiServer.Startup;

public class PluginStartup : IAppStartup
{
    private readonly ILogger<PluginStartup> Logger;
    private readonly BundleService BundleService;

    public PluginStartup(ILogger<PluginStartup> logger, BundleService bundleService)
    {
        Logger = logger;
        BundleService = bundleService;
    }

    public Task BuildApp(IHostApplicationBuilder builder)
    {
        Logger.LogInformation("Elo World from MoonlightPluginTemplate");
        
        // Scan the current plugin assembly for di services
        builder.Services.AutoAddServices<PluginStartup>();
        
        // Add css to bundle
        BundleService.BundleCss("css/MoonlightPluginTemplate.min.css");
        
        return Task.CompletedTask;
    }

    public Task ConfigureApp(IApplicationBuilder app)
    {
        return Task.CompletedTask;
    }
}