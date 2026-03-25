using AutoMapper;
using LifeFly.Dtos.FlightDtos;
using LifeFly.Entities;

namespace LifeFly.Mapping
{
    public class GeneralMapping: Profile
    {
       public GeneralMapping()
        {
            CreateMap<Flight, CreateFlightDto>().ReverseMap();
            CreateMap<Flight, UpdateFlightDto>().ReverseMap();
            CreateMap<Flight, GetFlightByIdDto>().ReverseMap();
            CreateMap<Flight, ResultFlightDto>().ReverseMap();
        }
    }
}
