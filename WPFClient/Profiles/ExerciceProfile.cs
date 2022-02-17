using AutoMapper;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Models;

namespace Ipme.Hometraining.Profiles
{
    public class ExerciceProfile : Profile
    {
        public ExerciceProfile()
        {
            CreateMap<ExerciceDto, ExerciceModel>().ReverseMap();
        }

    }
}
