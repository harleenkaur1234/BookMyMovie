using BookMyMovie.Models;
using BookMyMovie.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookMyMovie.Services.Interface
{
    public interface ICinemaService
    {
        public long AddCinema(CinemaView cinema);
        public Task<List<Cinema>> GetAllCinemas();

        public Cinema GetCinema(long Id);
        public string DeleteCinema(long Id);
    }
}
