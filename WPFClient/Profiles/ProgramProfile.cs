using AutoMapper;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Models;

namespace APIRest.Profiles
{
    public class ProgramProfile : Profile
    {
        public ProgramProfile()
        {
            CreateMap<ProgramDto, ProgramModel>().ReverseMap();

        }

    }
}
