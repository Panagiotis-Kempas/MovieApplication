using MovieApplication.Models.Entities;

namespace MovieApplication.Persistence.IRepositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        IEnumerable<Movie> GetHighestRatingMovies();

        IEnumerable<Movie> TwentyFirstCentury();

        IEnumerable<Movie> MostExpensive();

        IEnumerable<string> Trailers();
    }
}
