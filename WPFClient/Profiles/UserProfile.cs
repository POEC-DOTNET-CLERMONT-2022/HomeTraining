using AutoMapper;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Models;

namespace Ipme.Hometraining.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, UserModel>().ReverseMap();

        }

    }
}
