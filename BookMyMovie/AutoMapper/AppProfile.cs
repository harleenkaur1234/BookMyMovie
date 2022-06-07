using AutoMapper;
using BookMyMovie.Models;
using BookMyMovie.ViewModels;

namespace BookMyMovie.AutoMapper
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<MovieView, Movie>()
                .ForMember(dest => dest.ReleaseDate, opt => opt.MapFrom(src => src.ReleaseDate.Date))
                .ReverseMap();
            CreateMap<MovieNameView, Movie>().ReverseMap();
            CreateMap<TheaterView, Theater>().ReverseMap();
            CreateMap<SeatView, Seat>().ReverseMap();
            CreateMap<CinemaView, Cinema>().ReverseMap();
            CreateMap<ShowTimeView, ShowTime>().ReverseMap();
            CreateMap<UpdateMovieView, Movie>().ReverseMap();
            CreateMap<MovieGenreViewModel, Movie>().ReverseMap();
            CreateMap<MovieLanguageViewModel, Movie>().ReverseMap();
            CreateMap<MovieByIdView, Movie>().ReverseMap();
            CreateMap<ActorByMovieName, Movie>().ReverseMap();

        }
    }
}
