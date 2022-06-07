using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookMyMovie.ViewModels
{
    public class MovieNameView
    {
        [MaxLength(70)]
        [Required]
        public string MovieName { get; set; }
    }
}
