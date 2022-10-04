namespace LaboratoryWorkDudnik
{
	internal class Group
	{
		public int Id { get; set; }

		public string? Name { get; set; }

		public List<Student>? Students { get; set; } = new();

		public Schedule? Schedule { get; set; }
	}
}