using Microsoft.EntityFrameworkCore;

namespace LaboratoryWorkDudnik
{
	internal class Context : DbContext
	{
		public DbSet<University> Universities { get; set; }

		public DbSet<Group> Groups { get; set; }

		public DbSet<OpeningHoursOfThePremises> OpeningHoursOfThePremises { get; set; }

		public DbSet<Personal> Personals { get; set; }

		public DbSet<Student> Students { get; set; }

		public DbSet<Teacher> Teachers { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DataBaseDudnik;Trusted_Connection=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Student>(entity =>
			{
				entity.HasOne(n => n.University).WithMany(n => n.Students).HasForeignKey(n => n.Id);
			});
		}
	}
}