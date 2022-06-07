using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookMyMovie.ViewModels
{
    public class MovieLanguageViewModel
    {
        public string MovieName { get; set; }
        public string Director { get; set; }

        public string Cast { get; set; }
        public string Genre { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
    }
}
