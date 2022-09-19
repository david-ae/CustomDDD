using AutoMapper;
using CustomDDD.Domain.Entities;
using CustomDDD.Infrastructure.Dtos;

namespace CustomDDD.Application
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
