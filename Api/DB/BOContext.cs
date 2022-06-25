using Api.Dto;
using Microsoft.EntityFrameworkCore;

namespace Api.DB
{
	public class BOContext : DbContext
	{
		public DbSet<Account> Accounts { get; set; }
		public DbSet<Activity> Activities { get; set; }
		public DbSet<Pet> Pets { get; set; }

		public BOContext()
		{
			Database.EnsureCreated();
			//todo: run migrations after create
			Database.Migrate();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=MITS-PC;Database=BackOfficeTool;Trusted_Connection=True;");
		}
	}
}
