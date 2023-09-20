using Movies.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application
{
    public class MoviesService : IMoviesService
    {
        private readonly IMoviesRepository MoviesRepository;

        public MoviesService (IMoviesRepository moviesRepository)
        {
            this.MoviesRepository = moviesRepository;
        }
        public List<Movie> GetAllMovies()
        {
            return this.MoviesRepository.GetAllMovies();
        }

        public string AddMovie(string title, int minimumAge, string director, int minutesDuration)
        {
            Movie newMovie = new Movie{
                Title = title,
                MinimumAge = minimumAge,
                Director = director,
                MinutesDuration = minutesDuration
            };
            return MoviesRepository.AddMovie(newMovie);
        }

        public Movie? GetMovieById(int id)
        {
            return MoviesRepository.GetMovieById(id);
        }
    }
}
