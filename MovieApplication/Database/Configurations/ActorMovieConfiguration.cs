using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApplication.Models.JoinTables;

namespace MovieApplication.Database.Configurations
{
    public class ActorMovieConfiguration : IEntityTypeConfiguration<ActorMovie>
    {
        public void Configure(EntityTypeBuilder<ActorMovie> builder)
        {
            builder.HasKey(a => new { a.ActorId, a.MovieId });

            builder.HasOne(a => a.Actor)
                .WithMany(a => a.ActorMovies)
                .HasForeignKey(a => a.ActorId);

            builder.HasOne(m=> m.Movie)
                .WithMany(m=> m.ActorMovies)
                .HasForeignKey(m=> m.MovieId);

            // SEEDING DATABASE


            builder.HasData(
                new ActorMovie() { ActorId = 1, MovieId = 1 },
                new ActorMovie() { ActorId = 1, MovieId = 2 },
                new ActorMovie() { ActorId = 1, MovieId = 3 },
                new ActorMovie() { ActorId = 2, MovieId = 1 },
                new ActorMovie() { ActorId = 3, MovieId = 1 },
                new ActorMovie() { ActorId = 4, MovieId = 3 },
                new ActorMovie() { ActorId = 5, MovieId = 3 },
                new ActorMovie() { ActorId = 6, MovieId = 2 },
                new ActorMovie() { ActorId = 6, MovieId = 8 },
                new ActorMovie() { ActorId = 7, MovieId = 2 },
                new ActorMovie() { ActorId = 8, MovieId = 4 },
                new ActorMovie() { ActorId = 9, MovieId = 4 },
                new ActorMovie() { ActorId = 10, MovieId = 4 },
                new ActorMovie() { ActorId = 11, MovieId = 5 },
                new ActorMovie() { ActorId = 11, MovieId = 6 },
                new ActorMovie() { ActorId = 12, MovieId = 5 },
                new ActorMovie() { ActorId = 13, MovieId = 5 },
                new ActorMovie() { ActorId = 14, MovieId = 6 },
                new ActorMovie() { ActorId = 14, MovieId = 7 },
                new ActorMovie() { ActorId = 15, MovieId = 6 },
                new ActorMovie() { ActorId = 15, MovieId = 9 },
                new ActorMovie() { ActorId = 15, MovieId = 10 },
                new ActorMovie() { ActorId = 15, MovieId = 11 },
                new ActorMovie() { ActorId = 17, MovieId = 7 },
                new ActorMovie() { ActorId = 18, MovieId = 7 },
                new ActorMovie() { ActorId = 20, MovieId = 8 },
                new ActorMovie() { ActorId = 21, MovieId = 8 },
                new ActorMovie() { ActorId = 22, MovieId = 9 },
                new ActorMovie() { ActorId = 23, MovieId = 9 },
                new ActorMovie() { ActorId = 24, MovieId = 10 },
                new ActorMovie() { ActorId = 25, MovieId = 10 },
                new ActorMovie() { ActorId = 26, MovieId = 11 },
                new ActorMovie() { ActorId = 26, MovieId = 12 },
                new ActorMovie() { ActorId = 27, MovieId = 11 },
                new ActorMovie() { ActorId = 28, MovieId = 12 },
                new ActorMovie() { ActorId = 28, MovieId = 16 },
                new ActorMovie() { ActorId = 28, MovieId = 17 },
                new ActorMovie() { ActorId = 28, MovieId = 18 },
                new ActorMovie() { ActorId = 29, MovieId = 12 },
                new ActorMovie() { ActorId = 30, MovieId = 13 },
                new ActorMovie() { ActorId = 30, MovieId = 23 },
                new ActorMovie() { ActorId = 30, MovieId = 24 },
                new ActorMovie() { ActorId = 31, MovieId = 13 },
                new ActorMovie() { ActorId = 32, MovieId = 13 },
                new ActorMovie() { ActorId = 33, MovieId = 14 },
                new ActorMovie() { ActorId = 34, MovieId = 14 },
                new ActorMovie() { ActorId = 35, MovieId = 14 },
                new ActorMovie() { ActorId = 36, MovieId = 15 },
                new ActorMovie() { ActorId = 37, MovieId = 15 },
                new ActorMovie() { ActorId = 38, MovieId = 15 },
                new ActorMovie() { ActorId = 39, MovieId = 16 },
                new ActorMovie() { ActorId = 39, MovieId = 19 },
                new ActorMovie() { ActorId = 39, MovieId = 20 },
                new ActorMovie() { ActorId = 39, MovieId = 21 },              
                new ActorMovie() { ActorId = 40, MovieId = 16 },
                new ActorMovie() { ActorId = 41, MovieId = 17 },
                new ActorMovie() { ActorId = 42, MovieId = 17 },
                new ActorMovie() { ActorId = 43, MovieId = 18 },
                new ActorMovie() { ActorId = 43, MovieId = 20 },
                new ActorMovie() { ActorId = 44, MovieId = 18 },
                new ActorMovie() { ActorId = 45, MovieId = 19 },
                new ActorMovie() { ActorId = 46, MovieId = 19 },
                new ActorMovie() { ActorId = 47, MovieId = 20 },
                new ActorMovie() { ActorId = 48, MovieId = 21 },
                new ActorMovie() { ActorId = 49, MovieId = 21 },
                new ActorMovie() { ActorId = 52, MovieId = 22 },
                new ActorMovie() { ActorId = 53, MovieId = 22 },
                new ActorMovie() { ActorId = 54, MovieId = 22 },
                new ActorMovie() { ActorId = 55, MovieId = 23 },
                new ActorMovie() { ActorId = 56, MovieId = 23 },
                new ActorMovie() { ActorId = 57, MovieId = 24 },
                new ActorMovie() { ActorId = 58, MovieId = 24 },
                new ActorMovie() { ActorId = 59, MovieId = 25 },
                new ActorMovie() { ActorId = 60, MovieId = 25 },
                new ActorMovie() { ActorId = 61, MovieId = 25 },
                new ActorMovie() { ActorId = 62, MovieId = 26 },
                new ActorMovie() { ActorId = 62, MovieId = 27 },
                new ActorMovie() { ActorId = 63, MovieId = 26 },
                new ActorMovie() { ActorId = 64, MovieId = 26 },
                new ActorMovie() { ActorId = 65, MovieId = 27 },
                new ActorMovie() { ActorId = 66, MovieId = 27 },
                new ActorMovie() { ActorId = 67, MovieId = 29 },
                new ActorMovie() { ActorId = 67, MovieId = 28 },
                new ActorMovie() { ActorId = 68, MovieId = 28 },
                new ActorMovie() { ActorId = 69, MovieId = 28 },
                new ActorMovie() { ActorId = 70, MovieId = 29 },
                new ActorMovie() { ActorId = 71, MovieId = 29 },
                new ActorMovie() { ActorId = 72, MovieId = 31 },
                new ActorMovie() { ActorId = 72, MovieId = 30 },
                new ActorMovie() { ActorId = 73, MovieId = 30 },
                new ActorMovie() { ActorId = 74, MovieId = 30 },
                new ActorMovie() { ActorId = 75, MovieId = 31 },
                new ActorMovie() { ActorId = 76, MovieId = 31 },
                new ActorMovie() { ActorId = 77, MovieId = 32 },
                new ActorMovie() { ActorId = 78, MovieId = 32 },
                new ActorMovie() { ActorId = 79, MovieId = 32 },
                new ActorMovie() { ActorId = 80, MovieId = 33 },
                new ActorMovie() { ActorId = 81, MovieId = 33 },
                new ActorMovie() { ActorId = 82, MovieId = 33 },
                new ActorMovie() { ActorId = 83, MovieId = 34 },
                new ActorMovie() { ActorId = 84, MovieId = 34 },
                new ActorMovie() { ActorId = 85, MovieId = 34 },
                new ActorMovie() { ActorId = 86, MovieId = 35 },
                new ActorMovie() { ActorId = 87, MovieId = 35 },
                new ActorMovie() { ActorId = 88, MovieId = 35 },
                new ActorMovie() { ActorId = 89, MovieId = 36 },
                new ActorMovie() { ActorId = 90, MovieId = 36 },
                new ActorMovie() { ActorId = 91, MovieId = 36 }
                );
        }
    }
}
