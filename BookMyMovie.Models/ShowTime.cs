using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookMyMovie.Models
{
    public class ShowTime
    {
        [Key]
        [Required]
        public long Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Time { get; set; }

        [Required]
        [MaxLength(50)]
        public double TicketPrice { get; set; }

        public long MovieId { get; set; }
    }
}
