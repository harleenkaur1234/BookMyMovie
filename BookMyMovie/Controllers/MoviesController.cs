using AutoMapper;
using BookMyMovie.DB;
using BookMyMovie.Models;
using BookMyMovie.Services.Interface;
using BookMyMovie.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookMyMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly BookMyMovieDbContext _bookDbContext;
        private readonly IMovieService _movieService;

        public MoviesController(BookMyMovieDbContext bookDbContext, IMovieService movieService)
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

        [HttpGet("GetMovies")]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            try
            {
                return await _movieService.GetMovies();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in Retrieving data from database");
            }

        }
        [HttpGet("GetMovie/{Id:long}")]
        public ActionResult<Movie> GetMovie(long Id)
        {
            try
            {
                var result = _movieService.GetMovie(Id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in Retrieving data from database");
            }

        }

        [HttpPut("{id}")]
        public ActionResult<Movie> UpdateMovie(long id, UpdateMovieView updateMovie)
        {
            try
            {
                if (id != updateMovie.ID)
                {
                    return BadRequest("Id not match");
                }
                var result = _movieService.GetMovie(id);
                if (result == null)
                {
                    return NotFound($"Movie Id = {id} not Found");
                }
                //return _movieService.UpdateMovie(movie);
                return _movieService.UpdateMovie(updateMovie);
            }


            
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in updating data in database");
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<string> DeleteMovie(long id)
        {
            try
            {
                var findMovie = _movieService.GetMovie(id);
                if (findMovie == null)
                {
                    return NotFound($"Movie Id = {id} not Found");
                }

               
                return _movieService.DeleteMovie(id);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in deleting data in database");
            }
        }
    }
}
