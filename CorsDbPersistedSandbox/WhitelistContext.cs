using CorsDbPersistedSandbox.Models;
using Microsoft.EntityFrameworkCore;

namespace CorsDbPersistedSandbox
{
    public sealed class WhitelistContext : DbContext
    {
        public WhitelistContext(DbContextOptions<WhitelistContext> options) : base(options) { }

        public DbSet<CorsUri> CorsUris { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
