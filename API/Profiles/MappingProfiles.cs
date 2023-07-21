using Core.Entities;
using API.Dtos;
using AutoMapper;
namespace API.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile() {        
        CreateMap<Area, AreasDto>().ReverseMap();
        CreateMap<State, StateDto>().ReverseMap();

        ///Areas - AreaDTO
        CreateMap<Area, AreasDto>()
            .ReverseMap();
        ///Places - placeDTO
        CreateMap<Place, PlacesDto>()
            .ReverseMap();
    }
}