using Microsoft.EntityFrameworkCore;
using Hastane.Models;

namespace Hastane.Models
{
    public class HastaneContext:DbContext
    {
        public DbSet<GirişModel> Giris { get; set; }
        public DbSet<KayitModel> Kayit { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Hastn;Trusted_Connection=True;MultipleActiveResultSets=true");

        }
         

    }

    
}
