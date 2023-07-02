using Microsoft.AspNetCore.Components;
namespace BlazorWebAssemblyPortfolio.Shared.Projects
{
	public partial class Projects : ComponentBase
	{
		[Inject]
		public ProjectData config { get; set; } = new();
	}
}

