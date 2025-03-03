using Moonlight.Client.Interfaces;
using Moonlight.Client.Models;

namespace MoonlightPluginTemplate.Frontend.Implementations;

public class SidebarImplementation : ISidebarItemProvider
{
    public void ModifySidebar(List<SidebarItem> items)
    {
        items.AddRange(
        [
            new SidebarItem()
            {
                Name = "Example",
                Path = "/example",
                Icon = "icon-moon",
                Group = "MoonlightPluginTemplate",
                Priority = 1
            }
        ]);
    }
}