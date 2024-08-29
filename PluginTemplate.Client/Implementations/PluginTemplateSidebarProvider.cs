using Moonlight.Client.App.Interfaces;
using Moonlight.Client.App.Models;

namespace PluginTemplate.Client.Implementations;

public class PluginTemplateSidebarProvider : ISidebarItemProvider
{
    public SidebarItem[] GetItems()
    {
        return [new ()
        {
            Name = "PluginTemplate",
            Target = "/weather",
            Icon = "bi bi-box-seam",
            Priority = 5
        }];
    }
}