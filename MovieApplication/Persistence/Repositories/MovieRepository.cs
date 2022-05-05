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


    }
}
