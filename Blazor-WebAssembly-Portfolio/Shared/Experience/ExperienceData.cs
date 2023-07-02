namespace BlazorWebAssemblyPortfolio.Shared.Experience
{
	public class ExperienceData
	{
		public List<ExperienceDataItem> Items { get; set; } = new();
	}

	public class ExperienceDataItem
	{
		public string Company { get; set; } = "";

		public string Role { get; set; } = "";

		public string Description { get; set; } = "";

		public string Date { get; set; } = "";
	}
}

