using Microsoft.EntityFrameworkCore;

namespace Monitoring.API.Models;

public class UserContext : DbContext
{
	public DbSet<User> Users { get; set; }

    public UserContext()
    {
        Database.Migrate();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MonitoringUsers;Trusted_Connection=True");
	}

}
