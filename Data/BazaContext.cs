using Microsoft.EntityFrameworkCore;

namespace DiplomskiV3.Data
{
    public class BazaContext : DbContext
    {
        public BazaContext(DbContextOptions<BazaContext> options)
            : base(options)
        {
        }

        public DbSet<DiplomskiV3.Models.Movie> Movie { get; set; }
    }
}
