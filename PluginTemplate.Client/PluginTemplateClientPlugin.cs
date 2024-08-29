using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Logging;
using Moonlight.Client.App.Interfaces;
using Moonlight.Client.App.PluginApi;
using PluginTemplate.Client.Implementations;

namespace PluginTemplate.Client;

public class PluginTemplateClientPlugin : MoonlightClientPlugin
{
    public PluginTemplateClientPlugin(ILogger logger, PluginService pluginService) : base(logger, pluginService)
    {
    }
    
    public override Task OnLoaded()
    {
        // Use this function for all the load tasks independent of moonlight and register plugin interface implementations here
        
        Logger.LogInformation("Elo from PluginTemplate");
        
        PluginService.RegisterImplementation<ISidebarItemProvider, PluginTemplateSidebarProvider>();
        
        return Task.CompletedTask;
    }

    public override Task OnAppBuilding(WebAssemblyHostBuilder builder)
    {
        return Task.CompletedTask;
    }

    public override Task OnAppConfiguring(WebAssemblyHost app)
    {
        return Task.CompletedTask;
    }
}