using Microsoft.AspNetCore.Mvc;
using MovieApplication.Persistence;

namespace MovieApplication.Controllers
{
    public class ActorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ActorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IActionResult Index()
        {
            var actors = _unitOfWork.Actors.GetAll();
            return View(actors);
        }
    }
}
