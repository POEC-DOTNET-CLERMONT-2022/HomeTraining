using Ipme.Hometraining.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WPFClient
{
    internal static class ExerciceApiRest
    {
        static HttpClient client = new HttpClient();

        

        public static async Task<List<ExerciceDto>> GetExercicesAsync(string uri)
        {
            try
            {                
                var request = new HttpRequestMessage(HttpMethod.Get,uri);
                request.Headers.Add("Accept", "application/json");
                var response =  client.Send(request);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var exercices = JsonConvert.DeserializeObject<List<ExerciceDto>>(jsonString);
                    return exercices;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return null;
        }

        public static async Task<ExerciceDto> GetExerciceByIdAsync(string uri)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, uri);
                request.Headers.Add("Accept", "application/json");
                var response = client.Send(request);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var exercice = JsonConvert.DeserializeObject<ExerciceDto>(jsonString);
                    return exercice;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return null;
        }

        public static async Task<ExerciceDto> PostExerciceByIdAsync(string uri,ExerciceDto exDto)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, uri);
                request.Headers.Add("Accept", "application/json");
                var response = client.Send(request);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var exercice = JsonConvert.DeserializeObject<ExerciceDto>(jsonString);
                    return exercice;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return null;
        }
    }
}
