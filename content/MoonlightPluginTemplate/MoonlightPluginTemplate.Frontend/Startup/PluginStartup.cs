using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MoonCore.Extensions;
using Moonlight.Client.Interfaces;
using Moonlight.Client.Plugins;
using MoonlightPluginTemplate.Frontend.Implementations;

namespace MoonlightPluginTemplate.Frontend.Startup;

public class PluginStartup : IPluginStartup
{
    public Task BuildApplicationAsync(IServiceProvider serviceProvider, WebAssemblyHostBuilder builder)
    {
        builder.Services.AutoAddServices<PluginStartup>();

        builder.Services.AddSingleton<ISidebarItemProvider, SidebarImplementation>();
        
        return Task.CompletedTask;
    }

    public Task ConfigureApplicationAsync(IServiceProvider serviceProvider, WebAssemblyHost app)
    {
        return Task.CompletedTask;
    }
}