namespace LaboratoryWorkDudnik
{
	internal class University
	{
		public int Id { get; set; }

		public string? Adress { get; set; }

		public string? Name { get; set; }

		public string? INN { get; set; }

		public List<Student>? Students { get; set; } = new();

		public List<Teacher> Teachers { get; set; } = new();

		public List<Personal> Personals { get; set; } = new();
	}
}