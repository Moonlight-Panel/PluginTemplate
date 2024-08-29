using Moonlight.ApiServer.App.Helpers.Database;

namespace PluginTemplate.ApiServer.Database;

public class PluginTemplateContext : DatabaseContext
{
    public override string Prefix => "PluginTemplate";
}