using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyMovie.ViewModels
{
    public class TheaterView
    {
        public String TheaterName { get; set; }

        public int TotalSeats { get; set; }
        public bool IsBooked { get; set; }
        public ICollection<SeatView> Seats { get; set; }
    }
}
