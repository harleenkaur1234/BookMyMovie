using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyMovie.Models
{
    public class Theater
    {
        public long Id { get; set; }
        public String TheaterName { get; set; }

        public int TotalSeats { get; set; }
        public bool IsBooked { get; set; }
        public ICollection<Seat> Seats { get; set; }
    }
}
