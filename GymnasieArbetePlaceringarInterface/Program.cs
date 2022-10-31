using GymnasieArbetePlaceringarInterface;
using GymnasieArbetePlaceringarInterface.IServices;
using GymnasieArbetePlaceringarInterface.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient<IGetElevService, GetElevService>(httpClient =>
{
    httpClient.BaseAddress = new Uri("https://localhost:7015/");
});

builder.Services.AddMudServices();

await builder.Build().RunAsync();
