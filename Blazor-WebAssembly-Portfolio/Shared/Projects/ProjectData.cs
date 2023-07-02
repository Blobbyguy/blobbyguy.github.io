namespace BlazorWebAssemblyPortfolio.Shared.Projects
{
	public class ProjectData
	{
		public List<ProjectDataItem> Items { get; set; } = new();
	}

	public class ProjectDataItem
	{
		public string Title { get; set; } = "";

		public string Subtitle { get; set; } = "";

		public string Description { get; set; } = "";

		public List<string> Skills { get; set; } = new();

		public string url { get; set; } = "";

		public string imagePath { get; set; } = "";
	}
}

