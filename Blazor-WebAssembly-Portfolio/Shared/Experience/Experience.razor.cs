using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyPortfolio.Shared.Experience
{
	public partial class Experience : ComponentBase
	{
		public List<ExperienceItem> allItems = new List<ExperienceItem>();

		[Inject]
		public ExperienceData config { get; set; }

		//[Inject]
		//public IConfiguration AppConfig { get; set; }
		public Experience()
		{

			Console.WriteLine("Test: " + config?.Items);
			//allItems.Add(new ExperienceItem("Heading", "Body", "Data"));
		}
	}
}

