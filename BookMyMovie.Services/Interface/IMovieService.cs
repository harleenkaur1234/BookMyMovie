using BookMyMovie.Models;
using BookMyMovie.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookMyMovie.Services.Interface
{
    public interface IMovieService
    {
        public MovieView AddMovie(MovieView movie);
        public Task<List<Movie>> GetMovies();

        public Movie GetMovie(long Id);

        //public Movie UpdateMovie(long id,Movie movie);

        public string DeleteMovie(long Id);
    }
}
