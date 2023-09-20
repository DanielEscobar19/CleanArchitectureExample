using Movies.Application;
using Movies.Domain;
using System.IO;

namespace Movies.Infrastructure
{
    public class MovieRepository : IMoviesRepository
    {
        public static List<Movie> ListMovies = new List<Domain.Movie> {
            new Domain.Movie{  Id =1 ,Title= "Openjaime", MinimuAge = 18 , MinutesDuration= 120, Director = "Christopher Nissan"},
            new Domain.Movie{  Id =2 ,Title= "The movie", MinimuAge = 12 , MinutesDuration= 158, Director = "Adam Sandalia"},
            new Domain.Movie{  Id =3 ,Title= "Star Battles", MinimuAge = 0 , MinutesDuration= 90, Director = "Tim Button"},
            new Domain.Movie{  Id =4 ,Title= "Interstellar", MinimuAge = 15 , MinutesDuration= 190, Director = "Christopher Nolan"},
            new Domain.Movie{  Id =5 ,Title= "La naranja mecánica", MinimuAge = 18 , MinutesDuration= 134, Director = "Quentin Toronja"},
            new Domain.Movie{  Id =6 ,Title= "Tomorrowland", MinimuAge = 18 , MinutesDuration= 115, Director = "Guillermod el Valle"}
        };

        public List<Movie> GetAllMovies()
        {
            return ListMovies;
        }
    }
}