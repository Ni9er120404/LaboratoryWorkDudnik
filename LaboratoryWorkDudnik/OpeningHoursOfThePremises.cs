namespace LaboratoryWorkDudnik
{
	internal class OpeningHoursOfThePremises
	{
		public int Id { get; set; }

		public DateTime OpeningHours { get; set; }

		public List<Personal> Personals { get; set; }= new();
	}
}