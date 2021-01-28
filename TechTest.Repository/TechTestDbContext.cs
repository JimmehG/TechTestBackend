using Microsoft.EntityFrameworkCore;
using TechTest.Domain;

namespace TechTest.Repository
{
    public class TechTestDbContext : DbContext
    {
        public TechTestDbContext(DbContextOptions<TechTestDbContext> options) : base(options)
        { }

        public DbSet<Photo> Photos { get; set; }

    }
}
