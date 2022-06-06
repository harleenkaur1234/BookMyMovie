using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookMyMovie.Models
{
    public class Seat
    {
        [Required]
        public long Id { get; set; }
        public Theater Theater { get; set; }

        [MaxLength(30)]
        public string SeatNo { get; set; }

        [MaxLength(10)]
        public bool IsOccupied { get; set; }
    }
}
