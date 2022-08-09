using CryptoDashboard;
using CryptoDashboard.Services;
using CryptoDashboard.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://api.coingecko.com/api/v3/") });
builder.Services.AddScoped<ICoinService, CoinService>();

builder.Services.AddMudServices();

await builder.Build().RunAsync();
