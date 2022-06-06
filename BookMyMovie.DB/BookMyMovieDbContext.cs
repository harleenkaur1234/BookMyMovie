using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BookMyMovie.Models;
namespace BookMyMovie.DB
{
    public class BookMyMovieDbContext : DbContext
    {
        public BookMyMovieDbContext(DbContextOptions<BookMyMovieDbContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Booking> Customers { get; set; }
        public DbSet<ShowTime> ShowTimes { get; set; }
   
    }
}
