using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Repository;

public class AppDBContext : DbContext
{
    protected readonly IConfiguration configuration;

    public AppDBContext(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(configuration.GetConnectionString("DiaryDBConnectionString"));
    }
    
    /*public DbSet<User> Users { get; set; }*/
}