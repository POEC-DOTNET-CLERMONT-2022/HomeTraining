using AutoMapper;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Ipme.Hometraining.ApiData
{
    internal class ExerciceDataManager : ApiDataManager<ExerciceModel, ExerciceDto>
    {
        public ExerciceDataManager(HttpClient client, IMapper mapper, string serverUrl, string resourceUrl) : base(client, mapper, serverUrl, "/api/Exercices")
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

        public static List<ExerciceDto> GetExercicesByZone(MuscleArea zone)
        {
            ExerciceDto ex1 = new ExerciceDto()
            {
                Name = "POMPES",
                MuscleArea = MuscleArea.Pectoraux
            };
            ExerciceDto ex2 = new ExerciceDto()
            {
                Name = "CRUNCH",
                MuscleArea = MuscleArea.Abdos
            };
            ExerciceDto ex3 = new ExerciceDto()
            {
                Name = "PLANCHE SUR LES AVANT-BRAS",
                MuscleArea = MuscleArea.Dos
            };
            ExerciceDto ex4 = new ExerciceDto()
            {
                Name = "PLANCHE BRAS TENDUS",
                MuscleArea = MuscleArea.Dos
            };
            ExerciceDto ex5 = new ExerciceDto()
            {
                Name = "BRIDGE",
                MuscleArea = MuscleArea.Dos
            };
            ExerciceDto ex6 = new ExerciceDto()
            {
                Name = "SQUATE",
                MuscleArea = MuscleArea.Jambes
            };
            ExerciceDto ex7 = new ExerciceDto()
            {
                Name = "FLEXION",
                MuscleArea = MuscleArea.Jambes
            };
            ExerciceDto ex8 = new ExerciceDto()
            {
                Name = "SUPERMAN",
                MuscleArea = MuscleArea.Abdos
            };
            var exercices = new List<ExerciceDto>();
            if (zone == MuscleArea.Abdos)
            {
                exercices.Add(ex8);
                exercices.Add(ex2);
            }
            if (zone == MuscleArea.Jambes)
            {
                exercices.Add(ex6);
                exercices.Add(ex7);
            }
            if (zone != MuscleArea.Dos)
            {
                exercices.Add(ex3);
                exercices.Add(ex4);
                exercices.Add(ex5);
            }
            if (zone != MuscleArea.Pectoraux)
            {
                exercices.Add(ex1);
            }

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
