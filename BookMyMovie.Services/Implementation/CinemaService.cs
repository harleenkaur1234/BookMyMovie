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
    public class CinemaService : ICinemaService
    {
        private readonly BookMyMovieDbContext _context;
        private readonly IMapper _mapper;
        public CinemaService(BookMyMovieDbContext context, IMapper mapper)
        {
            _context = context;
            this._mapper = mapper;
        }

        public long AddCinema(CinemaView cinema)
        {
            try
            {
                var cinemaModel = _mapper.Map<Cinema>(cinema);
                _context.Cinemas.Add(cinemaModel);
                _context.SaveChanges();
                return cinemaModel.Id;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public string DeleteCinema(long Id)
        {
            var findCinema = _context.Cinemas.Include(x => x.Theaters).Where(a => a.Id == Id).FirstOrDefault();
            if (findCinema != null)
            {
                _context.Cinemas.Remove(findCinema);
                _context.SaveChanges();
                return "Cinema is deleted successfully";
            }
            return null;
        }

        public Task<List<Cinema>> GetAllCinemas()
        {
                return  _context.Cinemas
                    .Include(x => x.Theaters)
                    .ToListAsync();
        }

        public Cinema GetCinema(long Id)
        {
            return _context.Cinemas.Include(x => x.Theaters).Where(x => x.Id == Id).FirstOrDefault();
        }
    }
}
