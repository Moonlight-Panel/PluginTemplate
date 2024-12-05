using Moonlight.Client.Interfaces;
using Moonlight.Client.Models;

namespace MoonlightPluginTemplate.Frontend.Implementations;

public class SidebarImplementation : ISidebarItemProvider
{
    public SidebarItem[] Get()
    {
        return
        [
            new SidebarItem()
            {
                Name = "Example",
                Path = "/example",
                Icon = "icon-moon",
                Group = "MoonlightPluginTemplate",
                Priority = 1
            }
        ];
    }
}