using MovieApplication.Models.Entities;

namespace MovieApplication.Persistence.IRepositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        IEnumerable<Movie> GetHighestRatingMovies();
    }
}
