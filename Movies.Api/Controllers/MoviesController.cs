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


        [HttpPut("add-movie")]
        public ActionResult<IList<Domain.Movie>> AddMovie(string title, int minimuAge, string director, int minutesDuration)
        {
            string error = this.MoviesService.AddMovie(title, minimuAge, director, minutesDuration);

            if (error != string.Empty)
            {
                return BadRequest(error);
            }

            return Ok("Movie Added"); ;
        }

        [HttpGet("movie-by-id")]
        public ActionResult<IList<Domain.Movie>> GetMovieById(int movieId)
        {
            Domain.Movie? movie = this.MoviesService.GetMovieById(movieId);
            if (movie == null)
            {
                return NotFound("Movie not found");
            }

            return Ok(movie); ;
        }
    }
}
