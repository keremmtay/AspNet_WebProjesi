using Microsoft.EntityFrameworkCore;

namespace Uygulama_1.Models
{
    public class UygulamaContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-TUMHS1A\\NA;Database=TestUygulama;Integrated Security=true");
        }
    }
}
