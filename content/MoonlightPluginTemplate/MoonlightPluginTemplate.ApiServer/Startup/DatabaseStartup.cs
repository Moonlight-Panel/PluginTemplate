using Moonlight.ApiServer.Helpers;
using Moonlight.ApiServer.Interfaces.Startup;
using MoonlightPluginTemplate.ApiServer.Database;

namespace MoonlightPluginTemplate.ApiServer.Startup;

public class DatabaseStartup : IDatabaseStartup
{
    public Task ConfigureDatabase(DatabaseContextCollection collection)
    {
        collection.Add<MoonlightPluginTemplateDataContext>();
        
        return Task.CompletedTask;
    }
}