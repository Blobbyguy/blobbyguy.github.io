using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyPortfolio.Shared.Experience
{
	public partial class Experience : ComponentBase
	{
		private const string CurrentEmployer = "Blueshift";

		[Inject]
		public ExperienceData config { get; set; } = new();

		private static bool IsCurrentEmployment(ExperienceDataItem experienceItem)
		{
			if (experienceItem.Company.Equals(CurrentEmployer, StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}

			return experienceItem.Date.Contains("Present", StringComparison.OrdinalIgnoreCase);
		}
	}
}
