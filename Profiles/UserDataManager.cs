using AutoMapper;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profiles
{
    internal class UserDataManager : ApiDataManager<UserModel,UserDto>
    {
        public UserDataManager(HttpClient httpClient, IMapper mapper, string serverUrl, string ressourceUrl) : base(httpClient, mapper, serverUrl, ressourceUrl)
        {

        }

      
    }
}
