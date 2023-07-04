using Microsoft.AspNetCore.Components;
namespace BlazorWebAssemblyPortfolio.Shared.AboutMe
{
	public partial class AboutMe : ComponentBase
	{
		[Inject]
		public AboutMeData config { get; set; } = new();
	}
}

