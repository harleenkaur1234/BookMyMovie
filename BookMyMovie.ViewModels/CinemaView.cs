using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyMovie.ViewModels
{
    public class CinemaView
    {
        public string CinemaName { get; set; }
        public string Location { get; set; }
        public List<TheaterView> Theaters { get; set; } = new List<TheaterView>();
    }
}
