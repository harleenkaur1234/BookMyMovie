using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookMyMovie.Models
{
    public class Movie
    {
        [Key]

        public long Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string MovieName { get; set; }

        [MaxLength(50)]
        public string Director { get; set; }

        public string Cast { get; set; }

        [MaxLength(20)]
        public string Genre { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "date")]
        public DateTime ReleaseDate { get; set; }

        [MaxLength(20)]
        public string Language { get; set; }
        //[Column(TypeName = "time")]
        public DateTime Duration { get; set; }
        public List<ShowTime> ShowTimes { get; set; }
    }
}
