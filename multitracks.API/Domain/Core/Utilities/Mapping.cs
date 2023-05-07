using AutoMapper;
using multitracks.API.Domain.Models.DTOs;
using multitracks.API.Domain.Models.Entities;

namespace multitracks.API.Domain.Core.Utilities
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Artist, CreateArtistDTO>().ReverseMap()
                .ForMember(dest => dest.DateCreation, opt => opt.MapFrom(src => DateTime.Now));
            CreateMap<Artist, GetArtistDetailsDTO>().ReverseMap();
            CreateMap<SongDTO, Song>().ReverseMap();

        }
    }
}
