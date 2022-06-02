using AutoMapper;
using BookMyMovie.DB;
using BookMyMovie.Models;
using BookMyMovie.Services.Interface;
using BookMyMovie.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyMovie.Services.Implementation
{
    public class MovieService : IMovieService
    {
        private readonly BookMyMovieDbContext _bookDbContext;
        private readonly IMapper _mapper;
        public MovieService(BookMyMovieDbContext bookDbContext, IMapper mapper)
        {
            _bookDbContext = bookDbContext;
            this._mapper = mapper;
        }
        public long AddMovie(MovieView movie)
        {
            try
            {
                var movieModel = _mapper.Map<Movie>(movie);
                _bookDbContext.Movies.Add(movieModel);
                _bookDbContext.SaveChanges();
                return movieModel.Id;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public Movie DeleteMovie(long Id)
        {
            throw new NotImplementedException();
        }

        public Movie GetMovie(long Id)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetMovies()
        {
            throw new NotImplementedException();
        }

        public Movie UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
