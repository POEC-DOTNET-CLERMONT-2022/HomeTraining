using AutoMapper;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Models;
using System.Net.Http.Json;

namespace Ipme.Hometraining.ApiData
{
    public class ExerciceDataManager : ApiDataManager<ExerciceModel, ExerciceDto>
    {
        public ExerciceDataManager(HttpClient client, IMapper mapper, string serverUrl) : base(client, mapper, serverUrl, "/api/Exercices")
        {
        }

    }
}
