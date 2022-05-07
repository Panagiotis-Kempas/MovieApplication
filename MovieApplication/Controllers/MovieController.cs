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

        public IActionResult Index()
        {

            ViewBag.TopRated = _unitOfWork.Movies.GetHighestRatingMovies();
            ViewBag.TwentyFirst = _unitOfWork.Movies.TwentyFirstCentury();
            ViewBag.MostExpensive = _unitOfWork.Movies.MostExpensive();
            ViewBag.Trailers = _unitOfWork.Movies.Trailers();
            
        
            return View();
        }


        public IActionResult TopRatedMovies()
        {
            var movies = _unitOfWork.Movies.GetHighestRatingMovies();
            return View(movies);
        }
    }
}
