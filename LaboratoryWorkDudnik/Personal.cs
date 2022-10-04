namespace LaboratoryWorkDudnik
{
	internal class Personal
	{
		public int Id { get; set; }

		public string? LastName { get; set; }

		public string? FirstName { get; set; }

		public OpeningHoursOfThePremises OpeningHoursOfThePremises { get; set; }

		public University? University { get; set; }
	}
}