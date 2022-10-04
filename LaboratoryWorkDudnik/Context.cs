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

		public Context()
		{
			Database.EnsureDeleted();
			Database.EnsureCreated();
		}

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

			modelBuilder.Entity<Teacher>(entity =>
			{
				entity.HasOne(n => n.University).WithMany(n => n.Teachers).HasForeignKey(n => n.Id);
			});

			modelBuilder.Entity<Personal>(entity =>
			{
				entity.HasOne(n => n.University).WithMany(n => n.Personals).HasForeignKey(n => n.Id);
			});

			modelBuilder.Entity<Schedule>(entity =>
			{
				entity.HasMany(n => n.Teachers).WithOne(n => n.Schedule).HasForeignKey(n => n.Id);
			});

			modelBuilder.Entity<OpeningHoursOfThePremises>(entity =>
			{
				entity.HasMany(n => n.Personals).WithOne(n => n.OpeningHoursOfThePremises).HasForeignKey(n => n.Id);
			});
		}
	}
}