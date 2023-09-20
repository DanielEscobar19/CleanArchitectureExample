using Movies.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application
{
    public interface IMoviesService
    {
        List<Domain.Movie> GetAllMovies();
        Domain.Movie? GetMovieById(int id);
        string AddMovie(string title, int minimumAge, string director, int minutesDuration);
    }
}
