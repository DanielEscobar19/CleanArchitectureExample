using System.Collections.Generic;

namespace Movies.Application
{
    public interface IMoviesRepository
    {
        List<Domain.Movie> GetAllMovies();
    }
}