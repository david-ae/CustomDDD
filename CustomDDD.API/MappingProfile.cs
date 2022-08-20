using AutoMapper;
using CustomDDD.Infrastructure.Dtos;
using Domain;

namespace CustomDDD.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PupilDto, Pupil>();
            CreateMap<Pupil, PupilDto>();
        }
    }
}
