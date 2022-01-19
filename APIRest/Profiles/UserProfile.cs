using AutoMapper;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Entities;

namespace APIRest.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, UserEntity>().ReverseMap();

        }

    }
}
