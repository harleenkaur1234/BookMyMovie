using AutoMapper;
using BookMyMovie.DB;
using BookMyMovie.Models;
using BookMyMovie.Services.Interface;
using BookMyMovie.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<List<Movie>> GetMovies()
        {
            return await _bookDbContext.Movies
                .Include(x => x.ShowTimes)
                .ToListAsync();
        }


        public Movie GetMovie(long Id)
        {
            return _bookDbContext.Movies.Include(x=>x.ShowTimes).Where(x => x.Id == Id).FirstOrDefault();
        }


        public string DeleteMovie(long Id)
        {
            var findMovie = _bookDbContext.Movies.Include(x => x.ShowTimes).Where(a => a.Id == Id).FirstOrDefault();
            if (findMovie != null)
            {
                _bookDbContext.Movies.Remove(findMovie);
                _bookDbContext.SaveChanges();
                return "Movie is deleted successfully";
            }
            return null;
        }
    }
}
