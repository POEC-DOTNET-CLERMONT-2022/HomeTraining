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


        //TODO Corriger les fonctions revoir le code
        public async Task<IEnumerable<ExerciceModel>> GetExercicesAsync(string uri)
        {
            try
            {
                var response =  await HttpClient.GetFromJsonAsync<ExerciceDto>(uri);               
                    var exercices = Mapper.Map<IEnumerable<ExerciceModel>>(response); ;
                    return exercices;
            }
            catch (Exception ex)
            {
                //TODO : utiliser Debug.WriteLine();
                Console.WriteLine(ex.Message);
                throw;
            }
        }


    }
}
