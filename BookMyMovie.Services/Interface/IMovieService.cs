using BookMyMovie.Models;
using BookMyMovie.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyMovie.Services.Interface
{
    public interface IMovieService
    {
        public long AddMovie(MovieView movie);
        public List<Movie> GetMovies();

        public Movie GetMovie(long Id);

        public Movie UpdateMovie(Movie movie);

        public Movie DeleteMovie(long Id);
    }
}
