using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using BlazorWebAssemblyPortfolio.Shared.Experience;
using Blazor_WebAssembly_Portfolio;
using static System.Net.WebRequestMethods;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

//Console.WriteLine("Test");
//Console.WriteLine("Path:" + builder.Configuration["BasePath"]);

//builder.Configuration.AddConfiguration(new ConfigurationBuilder().AddJsonFile("appsettings.json").Build());
//builder.Configuration.AddJsonFile("sitedata.json");

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.Configure<ExperienceData>();




var http = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
builder.Services.AddScoped(sp => http);
builder.Services.AddMudServices();


builder.Services.AddSingleton<ExperienceData>(
	 provider =>
	 {
		 var config = provider.GetService<IConfiguration>();

		 return config?.GetSection("Experiences").Get<ExperienceData>();
	 });
//using var response = await http.GetAsync("sitedata.json");
//using var stream = await response.Content.ReadAsStreamAsync();
//builder.Configuration.AddJsonStream(stream);


await builder.Build().RunAsync();

