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
            /*.ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => $"{src.Id}")
                )
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => $"{src.Name}")
                )
                .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(src => $"{src.Description}")
                )
                .ForMember(
                    dest => dest.MuscleArea,
                    opt => opt.MapFrom(src => $"{src.MuscleArea}")
                )
                .ForMember(
                    dest => dest.VideoName,
                    opt => opt.MapFrom(src => $"{src.VideoName}")
                );*/
        }

    }
}
