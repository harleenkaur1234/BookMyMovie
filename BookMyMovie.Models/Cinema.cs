using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyMovie.Models
{
    public class Cinema
    {
        public long Id { get; set; }
        public string CinemaName { get; set; }
        public string Location { get; set; }
        public List<Theater> Theaters { get; set; } = new List<Theater>();
        public List<Seat> Seats { get; set; } = new List<Seat>();
    }
}
