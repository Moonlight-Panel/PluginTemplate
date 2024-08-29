namespace PluginTemplate.ApiServer.Services;

public class WeatherService
{
    public Task<int> GetTemperatureForLocation(string location)
    {
        return Task.FromResult(23);
    }
}