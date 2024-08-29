using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MoonCore.Extended.Helpers;
using Moonlight.ApiServer.App.PluginApi;
using PluginTemplate.ApiServer.Database;
using PluginTemplate.ApiServer.Services;

namespace PluginTemplate.ApiServer;

public class PluginTemplatePlugin : MoonlightPlugin
{
    public PluginTemplatePlugin(ILogger logger, PluginService pluginService) : base(logger, pluginService)
    {
    }

    public override Task OnLoaded()
    {
        // Use this function for all the load tasks independent of moonlight and register plugin interface implementations here
        
        Logger.LogInformation("Elo from PluginTemplate");
        
        return Task.CompletedTask;
    }

    public override Task OnAppBuilding(WebApplicationBuilder builder, DatabaseHelper databaseHelper)
    {
        // Register database
        builder.Services.AddDbContext<PluginTemplateContext>();
        databaseHelper.AddDbContext<PluginTemplateContext>();
        
        // Register your services here
        builder.Services.AddSingleton<WeatherService>();
        
        return Task.CompletedTask;
    }

    public override Task OnAppConfiguring(WebApplication app)
    {
        // Configure your middleware and routing here
        
        return Task.CompletedTask;
    }
}