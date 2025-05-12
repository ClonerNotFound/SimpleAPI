using Microsoft.EntityFrameworkCore;
using SimpleAPI.Model;

namespace SimpleAPI.Entity
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options) { }

        public DbSet<Player> Players { get; set; }
    }
}
