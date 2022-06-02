using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookMyMovie.ViewModels
{
    public class MovieView
    {
        [Required]
        public string MovieName { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }

        public string Genre { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string Language { get; set; }

        public DateTime Duration { get; set; }

        public List<ShowTimeView> ShowTimes { get; set; } = new List<ShowTimeView>();
    }
}
