namespace LaboratoryWorkDudnik
{
	internal class Student
	{
		public int Id { get; set; }

		public string? LastName { get; set; }

		public string? FirstName { get; set; }

		public DateTime YearOfAdmission { get; set; }

		public Group? Group { get; set; }

		public University University { get; set; }
	}
}