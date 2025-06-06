using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MoonCore.Extensions;
using Moonlight.Client.Interfaces;
using Moonlight.Client.Plugins;
using MoonlightPluginTemplate.Frontend.Implementations;

namespace MoonlightPluginTemplate.Frontend.Startup;

[PluginStartup]
public class PluginStartup : IPluginStartup
{
    public Task BuildApplication(IServiceProvider serviceProvider, WebAssemblyHostBuilder builder)
    {
        builder.Services.AutoAddServices<PluginStartup>();

        builder.Services.AddSingleton<ISidebarItemProvider, SidebarImplementation>();
        
        return Task.CompletedTask;
    }

    public Task ConfigureApplication(IServiceProvider serviceProvider, WebAssemblyHost app)
    {
        return Task.CompletedTask;
    }
}