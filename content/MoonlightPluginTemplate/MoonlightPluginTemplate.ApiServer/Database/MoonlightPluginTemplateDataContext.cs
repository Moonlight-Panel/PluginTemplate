using Moonlight.ApiServer.Configuration;
using Moonlight.ApiServer.Helpers;

namespace MoonlightPluginTemplate.ApiServer.Database;

public class MoonlightPluginTemplateDataContext : DatabaseContext
{
    public override string Prefix { get; } = "MoonlightPluginTemplate";
    
    public MoonlightPluginTemplateDataContext(AppConfiguration configuration) : base(configuration)
    {
    }
}