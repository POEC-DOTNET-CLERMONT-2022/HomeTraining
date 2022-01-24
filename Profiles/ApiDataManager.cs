using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Profiles
{
    public class ApiDataManager<TModel, TDto> : IApiDataManager<TModel, TDto> where TModel : class
                                                                             where TDto : class
    {
        private string _serverUrl;
        private string ressourceUrl;
        private HttpClient _httpClient { get; }
        private IMapper Mapper;


        public ApiDataManager(HttpClient httpClient,IMapper mapper,string serverUrl,string ressourceUrl)
        {
            Mapper = mapper;
            _serverUrl=serverUrl;
            ressourceUrl = ressourceUrl;
        }

        IEnumerable<TModel> IApiDataManager<TModel, TDto>.GetAll()
        {
            _httpClient.GetFromJsonAsync<TDto>(new Uri(_serverUrl + _ressourceUrl));
        }
    }
}
