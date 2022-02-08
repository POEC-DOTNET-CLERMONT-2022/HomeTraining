using AutoMapper;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Ipme.Hometraining.ApiData
{
    public class ProgramExerciceDataManager : ApiDataManager<ProgramExerciceModel, ProgramExerciceDto>
    {
        public ProgramExerciceDataManager(HttpClient client, IMapper mapper, string serverUrl) : base(client, mapper, serverUrl, "/api/ProgramExercices")
        {
        }

        
    }
}
