using Microsoft.EntityFrameworkCore;
using multitracks.API.Domain.Models.Entities;

namespace multitracks.API.infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Song> Song { get; set; }
        public DbSet<Album> Album { get; set; }
    }
}
