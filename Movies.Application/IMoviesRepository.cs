using Movies.Domain;
using System.Collections.Generic;

namespace Movies.Application
{
    public interface IMoviesRepository
    {
        List<Domain.Movie> GetAllMovies();

        Domain.Movie? GetMovieById(int id);

        string AddMovie(Movie newMovie);
    }
}