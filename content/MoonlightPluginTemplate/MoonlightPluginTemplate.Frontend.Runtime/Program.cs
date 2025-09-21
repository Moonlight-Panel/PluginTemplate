using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Moonlight.Client.Startup;
using MoonlightPluginTemplate.Frontend.Runtime;

var pluginLoader = new DevPluginLoader();
pluginLoader.Initialize();

var startup = new Startup();

await startup.InitializeAsync(pluginLoader.Instances);

var wasmHostBuilder = WebAssemblyHostBuilder.CreateDefault(args);

await startup.AddMoonlightAsync(wasmHostBuilder);

var wasmApp = wasmHostBuilder.Build();

await startup.AddMoonlightAsync(wasmApp);

await wasmApp.RunAsync();