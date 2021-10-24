using AutoMapper;
using BikeRaceAPI.Models;
using BikeRaceAPI.DtoModels;

namespace BikeRaceAPI.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Race, RaceDto>().ReverseMap();
            CreateMap<Participant, ParticipantDto>().ReverseMap();
            CreateMap<Result, ResultDto>().ReverseMap();
        }
    }
}
