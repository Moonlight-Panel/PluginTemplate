using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MoonCore.Extensions;
using Moonlight.Client.Interfaces;
using MoonlightPluginTemplate.Frontend.Implementations;

namespace MoonlightPluginTemplate.Frontend.Startup;

public class PluginStartup : IPluginStartup
{
    public Task BuildApplication(WebAssemblyHostBuilder builder)
    {
        builder.Services.AutoAddServices<PluginStartup>();

        builder.Services.AddSingleton<ISidebarItemProvider, SidebarImplementation>();
        
        return Task.CompletedTask;
    }

    public Task ConfigureApplication(WebAssemblyHost app)
    {
        return Task.CompletedTask;
    }
}