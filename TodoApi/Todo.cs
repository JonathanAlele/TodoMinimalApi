namespace TodoApi
{

	// Data model for the app
	public class Todo
	{
		public int Id { get; set; }
		public string? Name { get; set; }

		public bool IsComplete { get; set; }
	}
}
