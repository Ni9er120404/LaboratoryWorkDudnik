namespace LaboratoryWorkDudnik
{
	internal class Schedule
	{
		public int Id { get; set; }

		public string? Corpus { get; set; }

		public string? NumberOfCabinet { get; set; }

		public DateTime Time { get; set; }

		public List<Group> Group { get; set; } = new();

		public List<Teacher> Teachers { get; set; } = new();
	}
}