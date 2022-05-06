using Microsoft.AspNetCore.Mvc;
using MovieApplication.Persistence;

namespace MovieApplication.Controllers
{
    public class MovieController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IUnitOfWork _unitOfWork;

        public MovieController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult TopRatedMovies()
        {
            var movies = _unitOfWork.Movies.GetHighestRatingMovies();
            return View(movies);
        }
    }
}
