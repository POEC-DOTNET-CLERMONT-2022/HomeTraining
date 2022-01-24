using AutoMapper;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Entities;

namespace WPFClient
{
    public class ExerciceProfile : Profile
    {
        public ExerciceProfile()
        {
            CreateMap<ExerciceDto, ExerciceEntity>().ReverseMap();
        }

    }
}
