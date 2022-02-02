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
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public IEnumerable<ExerciceModel> GetExercicesFixture()
        {
            ExerciceModel ex1 = new ExerciceModel(Guid.NewGuid(),"POMPES","", MuscleArea.Pectoraux,"",Guid.NewGuid());
            ExerciceModel ex2 = new ExerciceModel(Guid.NewGuid(),"CRUNCH", "", MuscleArea.Abdos, "", Guid.NewGuid());
            ExerciceModel ex3 = new ExerciceModel(Guid.NewGuid(),"PLANCHE SUR LES AVANT-BRAS", "", MuscleArea.Dos, "", Guid.NewGuid());
            ExerciceModel ex4 = new ExerciceModel(Guid.NewGuid(), "PLANCHE BRAS TENDUS", "", MuscleArea.Dos, "", Guid.NewGuid());
            ExerciceModel ex5 = new ExerciceModel(Guid.NewGuid(), "BRIDGE", "", MuscleArea.Dos, "", Guid.NewGuid());
            ExerciceModel ex6 = new ExerciceModel(Guid.NewGuid(), "SQUATE", "", MuscleArea.Jambes, "", Guid.NewGuid());
            ExerciceModel ex7 = new ExerciceModel(Guid.NewGuid(), "FLEXION", "", MuscleArea.Jambes, "", Guid.NewGuid());
            ExerciceModel ex8 = new ExerciceModel(Guid.NewGuid(), "SUPERMAN", "", MuscleArea.Abdos, "", Guid.NewGuid());           
            var exercices = new List<ExerciceModel>();            
                exercices.Add(ex8);
                exercices.Add(ex2);            
                exercices.Add(ex6);
                exercices.Add(ex7);            
                exercices.Add(ex3);
                exercices.Add(ex4);
                exercices.Add(ex5);            
                exercices.Add(ex1); 
            return exercices;
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
