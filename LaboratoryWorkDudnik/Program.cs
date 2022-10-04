namespace LaboratoryWorkDudnik
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			try
			{
				using (Context context = new())
				{

				}

				Console.WriteLine("Процесс завершен успешно");
			}
			catch (Exception)
			{
				Console.WriteLine("Процесс завершен неуспешно");
			}
		}
	}
}