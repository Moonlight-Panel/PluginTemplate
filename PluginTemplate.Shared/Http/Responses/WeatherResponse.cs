namespace PluginTemplate.Shared.Http.Responses;

public class WeatherResponse
{
    public string Location { get; set; }
    public int DegreeC { get; set; }
    public string Description { get; set; }
}