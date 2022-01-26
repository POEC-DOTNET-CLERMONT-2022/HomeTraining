using AutoMapper;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Entities;

namespace Ipme.Hometraining.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, UserEntity>().ReverseMap();

        }

    }
}
