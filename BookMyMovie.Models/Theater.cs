using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookMyMovie.Models
{
    public class Theater
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string TheaterName { get; set; }

        [Required,MaxLength(20)]
        public int TotalSeats { get; set; }

        [Required]
        
        public bool IsBooked { get; set; }
        public ICollection<Seat> Seats { get; set; }
    }
}
