using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookMyMovie.ViewModels
{
    public class ShowTimeView
    {
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Time { get; set; }
        public double TicketPrice { get; set; }
        public MovieView MovieVM { get; set; }
    }
}
