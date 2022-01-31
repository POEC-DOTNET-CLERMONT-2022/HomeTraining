using AutoMapper;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Ipme.Hometraining.ApiData
{
    public class ProgramDataManager : ApiDataManager<ExerciceModel, ExerciceDto>
    {
        public ProgramDataManager(HttpClient client, IMapper mapper, string serverUrl) : base(client, mapper, serverUrl, "/api/Exercices")
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
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        

        //TODO gerer le catch
        //public static async Task<ExerciceDto> GetExerciceByIdAsync(string uri)
        //{
        //    try
        //    {
        //        var request = new HttpRequestMessage(HttpMethod.Get, uri);
        //        request.Headers.Add("Accept", "application/json");
        //        var response = HttpClient.Send(request);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            var jsonString = await response.Content.ReadAsStringAsync();
        //            var exercice = JsonConvert.DeserializeObject<ExerciceDto>(jsonString);
        //            return exercice;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        throw;

        //    }
        //    return null;
        //}

        //TODO gerer le catch
        //public static async Task<Uri> PostExerciceAsync(string uri, ExerciceDto exDto)
        //{
        //    try
        //    {
        //        HttpResponseMessage response = await HttpClient.PostAsJsonAsync(uri, exDto);
        //        response.EnsureSuccessStatusCode();

        //        if (response.IsSuccessStatusCode)
        //        {
        //            return response.Headers.Location;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        throw;

        //    }
        //    return null;
        //}
    }
}
