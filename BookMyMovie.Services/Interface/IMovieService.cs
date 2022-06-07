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
        public Task<List<MovieView>> GetMoviesDetails();
        public Task<List<MovieNameView>> GetMovieNames();
        public MovieView GetMovieDetailByName(string movieName);
        public Task<List<MovieNameView>> GetMoviesByDirector(string director);
        public Task<List<MovieGenreViewModel>> GetMoviesByGenre(string genre);
        public Task<List<MovieLanguageViewModel>> GetMoviesByLanguage(string language);
        public MovieByIdView GetMovieById(long id);

        //public Movie GetMovie(long Id);

        public string DeleteMovie(long Id);
        public ActorByMovieName GetActors(string movieName);
    }
}
