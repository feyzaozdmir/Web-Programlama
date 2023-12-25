using Microsoft.EntityFrameworkCore;

namespace Hastane.Models
{
    public class HastaneContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Hastane;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"); ;

        }
            public DbSet<GirişModel> deneme { get; set; }
    }

    
}
