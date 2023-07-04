using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using BlazorWebAssemblyPortfolio.Shared.Experience;
using BlazorWebAssemblyPortfolio.Shared.Projects;
using BlazorWebAssemblyPortfolio.Shared.AboutMe;
using Blazor_WebAssembly_Portfolio;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var http = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
builder.Services.AddScoped(sp => http);
builder.Services.AddMudServices();



//Reference: https://learn.microsoft.com/en-us/aspnet/core/blazor/fundamentals/dependency-injection?view=aspnetcore-7.0
//App settings is automatically imported in blazor
builder.Services.AddSingleton<ExperienceData>(
	 provider =>
	 {
		var config = provider.GetService<IConfiguration>();
		return config.GetSection("Experiences").Get<ExperienceData>();
	 });
builder.Services.AddSingleton<ProjectData>(
	 provider =>
	 {
		 var config = provider.GetService<IConfiguration>();
		 return config.GetSection("Projects").Get<ProjectData>();
	 });
builder.Services.AddSingleton<AboutMeData>(
	 provider =>
	 {
		 var config = provider.GetService<IConfiguration>();
		 return config.GetSection("AboutMe").Get<AboutMeData>();
	 });
await builder.Build().RunAsync();

