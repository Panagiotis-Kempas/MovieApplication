using Microsoft.EntityFrameworkCore;
using MovieApplication.Database.Configurations;
using MovieApplication.Models.Entities;

namespace MovieApplication.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ActorConfiguration());
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies{ get; set; }
        public DbSet<Photo> Photos { get; set; }

    }
}
