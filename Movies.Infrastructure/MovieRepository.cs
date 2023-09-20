using Movies.Application;
using Movies.Domain;
using System.IO;

namespace Movies.Infrastructure
{
    public class MovieRepository : IMoviesRepository
    {
        public static List<Movie> ListMovies = new List<Domain.Movie> {
            new Domain.Movie{  Id =1 ,Title= "Openjaime", MinimumAge = 18 , MinutesDuration= 120, Director = "Christopher Nissan"},
            new Domain.Movie{  Id =2 ,Title= "The movie", MinimumAge = 12 , MinutesDuration= 158, Director = "Adam Sandalia"},
            new Domain.Movie{  Id =3 ,Title= "Star Battles", MinimumAge = 0 , MinutesDuration= 90, Director = "Tim Button"},
            new Domain.Movie{  Id =4 ,Title= "Interstellar", MinimumAge = 15 , MinutesDuration= 190, Director = "Christopher Nolan"},
            new Domain.Movie{  Id =5 ,Title= "La naranja mecánica", MinimumAge = 18 , MinutesDuration= 134, Director = "Quentin Toronja"},
            new Domain.Movie{  Id =6 ,Title= "Tomorrowland", MinimumAge = 18 , MinutesDuration= 115, Director = "Guillermod el Valle"}
        };

        public string AddMovie(Movie newMovie)
        {
            string error = "";

            if (ListMovies.Find(movie => movie.Title == newMovie.Title && movie.MinutesDuration == newMovie.MinutesDuration && movie.Director == newMovie.Director) == null)
            {
                newMovie.Id = ListMovies.Last().Id + 1;
                ListMovies.Add(newMovie);
            } else
            {
                error = "The movie already exists";
            }
            
            return error;
        }

        public List<Movie> GetAllMovies()
        {
            return ListMovies;
        }

        public Movie GetMovieById(int id)
        {
            return ListMovies.Find(movie => movie.Id == id);
        }
    }
}