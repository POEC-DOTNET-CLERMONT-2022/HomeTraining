using AutoMapper;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Entities;

namespace APIRest.Profiles
{
    public class ProgramExerciceProfile : Profile
    {
            public ProgramExerciceProfile()
            {
                CreateMap<ProgramExerciceDto, ProgramExerciceEntity>().ReverseMap();

            }

    }
}
