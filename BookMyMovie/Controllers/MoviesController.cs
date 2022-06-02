using AutoMapper;
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
    public class MoviesController : ControllerBase
    {
        private readonly BookMyMovieDbContext _bookDbContext;
        private readonly IMovieService _movieService;

        public MoviesController(BookMyMovieDbContext bookDbContext, IMovieService movieService, IMapper mapper)
        {
            _bookDbContext = bookDbContext;
            this._movieService = movieService;
        }
        [HttpPost("SaveMovie")]
        public ActionResult<IEnumerable<MovieView>> AddMovie(MovieView Movie)
        {
            try
            {
                long Id = _movieService.AddMovie(Movie);
                return StatusCode(StatusCodes.Status201Created, $"A new movie is saved with {Id}");
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Error occurred while saving a movie");
            }
        }
    }
}
