using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyPortfolio.Shared.Experience
{
	public partial class Experience : ComponentBase
	{
		[Inject]
		public ExperienceData config { get; set; } = new();
	}
}

