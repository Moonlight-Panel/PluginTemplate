using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MoonCore.Extensions;
using Moonlight.ApiServer.Plugins;
using MoonlightPluginTemplate.ApiServer.Database;

namespace MoonlightPluginTemplate.ApiServer.Startup;

public class PluginStartup : IPluginStartup
{
    public Task BuildApplicationAsync(IServiceProvider serviceProvider, IHostApplicationBuilder builder)
    {
        var logger = serviceProvider.GetRequiredService<ILogger<PluginStartup>>();
        
        logger.LogInformation("Elo World from MoonlightPluginTemplate");

        // Scan the current plugin assembly for di services
        builder.Services.AutoAddServices<PluginStartup>();

        builder.Services.AddDbContext<MoonlightPluginTemplateDataContext>();

        return Task.CompletedTask;
    }

    public Task ConfigureApplicationAsync(IServiceProvider serviceProvider, IApplicationBuilder app)
        => Task.CompletedTask;

    public Task ConfigureEndpointsAsync(IServiceProvider serviceProvider, IEndpointRouteBuilder routeBuilder)
        => Task.CompletedTask;
}