using BookMyMovie.DB;
using BookMyMovie.Services.Interface;
using BookMyMovie.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BookMyMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        private readonly BookMyMovieDbContext _context;
        private readonly ICinemaService _cinemaService;
        public CinemaController(BookMyMovieDbContext context, ICinemaService cinemaService)
        {
            _context = context;
            this._cinemaService = cinemaService;
        }
        [HttpPost("AddCinema")]
        public ActionResult<IEnumerable<CinemaView>> AddCinema(CinemaView Cinema)
        {
            try
            {
                long Id = _cinemaService.AddCinema(Cinema);
                return StatusCode(StatusCodes.Status201Created, $"A new cinema is saved with {Id}");
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Error occurred while saving a movie");
            }
        }
    }
}
