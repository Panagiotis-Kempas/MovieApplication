using MovieApplication.Database;
using MovieApplication.Models.Entities;
using MovieApplication.Persistence.IRepositories;

namespace MovieApplication.Persistence.Repositories
{
    public class MovieRepository : Repository<Movie>,IMovieRepository
    {
        public MovieRepository(ApplicationDbContext context) :base(context)
        {
           
        }

        public ApplicationDbContext ApplicationDbContext => Context as ApplicationDbContext;

        public IEnumerable<Movie> GetHighestRatingMovies()
        {
            var movies = ApplicationDbContext.Movies.Where(x=> x.Rating > 8).ToList();
            return movies;
        }

        public IEnumerable<Movie> MostExpensive()
        {
            var movies = ApplicationDbContext.Movies.Where(x => x.Price > 15).Take(10).ToList();
            return movies;
        }

        public IEnumerable<string> Trailers()
        {
            var movies = ApplicationDbContext.Movies.Select(x=> x.TrailerUrl).ToList();
            return movies;
        }

        public IEnumerable<Movie> TwentyFirstCentury()
        {
            var movies = ApplicationDbContext.Movies.Where(x => x.ProductionYear.Year > 1990).Take(15).ToList();
            return movies;
        }


    }
}
