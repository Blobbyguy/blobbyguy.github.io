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

		public List<string> Description { get; set; } = new();

		public string Date { get; set; } = "";

		public List<string> Skills { get; set; } = new();
	}
}

