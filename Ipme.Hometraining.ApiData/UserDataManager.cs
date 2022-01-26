using AutoMapper;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Models;

namespace Ipme.Hometraining.ApiData
{
    public class UserDataManager : ApiDataManager<UserModel, UserDto>
    {
        public UserDataManager(HttpClient client, IMapper mapper, string serverUrl) 
            : base(client, mapper, serverUrl, "/api/users")
        {
        }
    }
}
