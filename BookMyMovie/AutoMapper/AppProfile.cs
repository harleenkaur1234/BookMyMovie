using AutoMapper;
using BookMyMovie.Models;
using BookMyMovie.ViewModels;

namespace BookMyMovie.AutoMapper
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<MovieView, Movie>().ReverseMap();
            CreateMap<TheaterView, Theater>().ReverseMap();
            CreateMap<SeatView, Seat>().ReverseMap();
            CreateMap<CinemaView, Cinema>().ReverseMap();
            CreateMap<ShowTimeView, ShowTime>().ReverseMap();

        }
    }
}
