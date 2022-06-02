using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyMovie.Models
{
    public class Seat
    {
        public long Id { get; set; }
        public Theater Theater { get; set; }
        public string SeatNo { get; set; }
        public bool IsOccupied { get; set; }
    }
}
