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
        public ActionResult<MovieView> AddMovie(MovieView Movie)
        {
            try
            {
                return _movieService.AddMovie(Movie);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Error occurred while saving a movie");
            }
        }

        [HttpGet("GetMovieNames")]
        public async Task<ActionResult<IEnumerable<MovieNameView>>> GetMovieNames()
        {
            try
            {
                return await _movieService.GetMovieNames();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in Retrieving data from database");
            }

        }

        [HttpGet("GetMovieDetailByName")]
        public ActionResult<MovieView> GetMovieDetailByName(string movieName)
         {
            try
            {
                var result = _movieService.GetMovieDetailByName(movieName);
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
        [HttpGet("GetMovieByDirectorName")]
        public async Task<ActionResult<IEnumerable<MovieNameView>>> GetMoviesByDirector(string director)
        {
            try
            {
                var result = await _movieService.GetMoviesByDirector(director);
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

        [HttpGet("GetMoviesByGenre")]
        public async Task<ActionResult<IEnumerable<MovieGenreViewModel>>> GetMoviesByGenre(string genre)
        {
            try
            {
                var result = await _movieService.GetMoviesByGenre(genre);
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
        [HttpGet("GetMoviesByLanguage")]
        public async Task<ActionResult<IEnumerable<MovieLanguageViewModel>>> GetMoviesByLanguage(string language)
        {
            try
            {
                var result = await _movieService.GetMoviesByLanguage(language);
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

        [HttpGet("GetMoviesDetails")]
        public async Task<ActionResult<IEnumerable<MovieView>>> GetMoviesDetails()
        {
            try
            {
                return await _movieService.GetMoviesDetails();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in Retrieving data from database");
            }

        }

        [HttpGet("GetMovieDetailById")]
        public ActionResult<MovieByIdView> GetMovieById(long id)
        {
            try
            {
                var result = _movieService.GetMovieById(id);
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

        [HttpGet("GetActorByMovieName")]
        public ActionResult<ActorByMovieName> GetActors(string movieName)
        {
            try
            {
                var result = _movieService.GetActors(movieName);
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
        //[HttpGet("GetMovie/{Id:long}")]
        //public ActionResult<Movie> GetMovie(long Id)
        //{
        //    try
        //    {
        //        var result = _movieService.GetMovie(Id);
        //        if (result == null)
        //        {
        //            return NotFound();
        //        }
        //        return result;
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, "Error in Retrieving data from database");
        //    }

        //}

        //[HttpPut("{id}")]
        //public ActionResult<Movie> UpdateMovie(long id, Movie movie)
        //{

        //    try
        //    {

        //        if (id != movie.Id)
        //        {
        //            return BadRequest("Id not match");
        //        }

        //        var result = _movieService.GetMovie(id);
        //        if (result == null)
        //        {
        //            return NotFound($"Movie Id = {id} not Found");
        //        }

        //        return _movieService.UpdateMovie(movie);

        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, "Error in updating data in database");
        //    }
        //}

        [HttpDelete("{id}")]
        public ActionResult<string> DeleteMovie(long id)
        {
            try
            {
                var findMovie = _movieService.GetMovieById(id);
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

