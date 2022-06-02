using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookMyMovie.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public long Id { get; set; }

        [Required]
        public string MovieName { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }

        public string Genre { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        public string Language { get; set; }

        public DateTime Duration { get; set; }

        //public List<MovieReview> MovieReviews { get; set; } = new List<MovieReview>();
        public List<ShowTime> ShowTimes { get; set; } = new List<ShowTime>();
    }
}
