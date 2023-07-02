namespace BlazorWebAssemblyPortfolio.Shared.Extensions
{
	public static class ListExtensions
	{
		public static T GetRandomElement<T>(this IList<T> values)
		{
			var random = new Random();
			return values[random.Next(values.Count)];
		}
	}
}

