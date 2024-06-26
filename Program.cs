using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using anrouxel;
using anrouxel.Configurations;
using anrouxel.Services;
using anrouxel.ViewModels;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.Configure<GithubSettings>(builder.Configuration.GetSection("GithubSettings"));

builder.Services.AddTransient<IGithubService, GithubService>();
builder.Services.AddTransient<HomeViewModel>();

await builder.Build().RunAsync();
