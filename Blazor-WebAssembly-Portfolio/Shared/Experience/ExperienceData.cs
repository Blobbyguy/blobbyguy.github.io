namespace BlazorWebAssemblyPortfolio.Shared.Experience
{
	public class ExperienceData
	{
		public List<ExperienceDataItem> Items { get; set; } = new();
	}

	public class ExperienceDataItem
	{
		public string Header { get; set; } = "";

		public string Body { get; set; } = "";

		public string Date { get; set; } = "";
	}
}

