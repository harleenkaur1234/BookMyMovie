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
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public double TicketPrice { get; set; }
        public long MovieId { get; set; }
    }
}
