using MoonCore.Extended.SingleDb;
using Moonlight.ApiServer.Configuration;

namespace MoonlightPluginTemplate.ApiServer.Database;

public class MoonlightPluginTemplateDataContext : DatabaseContext
{
    public override string Prefix { get; } = "MoonlightPluginTemplate";
    
    public MoonlightPluginTemplateDataContext(AppConfiguration configuration)
    {
        Options = new()
        {
            Host = configuration.Database.Host,
            Port = configuration.Database.Port,
            Username = configuration.Database.Username,
            Password = configuration.Database.Password,
            Database = configuration.Database.Database
        };
    }
}