using Microsoft.AspNetCore.Mvc;
using Movies.Application;

namespace Movies.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : Controller
    {
        private readonly IMoviesService MoviesService;

        public MoviesController(IMoviesService moviesService)
        {
            MoviesService = moviesService;
        }

        [HttpGet]
        public ActionResult<IList<Domain.Movie>> Get()
        {
            return Ok(this.MoviesService.GetAllMovies()); ;
        }
    }
}
