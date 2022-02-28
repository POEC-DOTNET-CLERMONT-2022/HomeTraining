using AutoMapper;
using System.Net.Http.Json;

namespace Ipme.Hometraining.ApiData
{
    public abstract class ApiDataManager<TModel, TDto> : IDataManager<TModel, TDto> 
        where TModel : class 
        where TDto : class
    {
        protected HttpClient HttpClient { get; }
        protected IMapper Mapper { get; }
        protected string ServerUrl { get; }
        protected string ResourceUrl { get; }

        protected Uri Uri { get; }

        public ApiDataManager(HttpClient client, IMapper mapper, string serverUrl, string resourceUrl)
        {
            HttpClient = client;
            HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            Mapper = mapper;
            ServerUrl = serverUrl;
            ResourceUrl = resourceUrl;
            Uri = new Uri(ServerUrl + ResourceUrl); 
        }


        public async Task<IEnumerable<TModel>> GetAll()
        {
            var result = await HttpClient.GetFromJsonAsync<IEnumerable<TDto>>(Uri);
            if (result == null)
            {
                throw new Exception("Erreur données non reçus");
            }
            else
            {
                return Mapper.Map<IEnumerable<TModel>>(result);
            }
            
        }

        public async Task Add(TModel model)
        {
            var dto = Mapper.Map<TDto>(model); 
            await HttpClient.PostAsJsonAsync(Uri,dto);
        }

        public async Task<TModel> Get(Guid id)
        {
            var result = await HttpClient.GetFromJsonAsync<TDto>($"{Uri}/{id}");
            return Mapper.Map<TModel>(result);
        }

        public async Task Put(TModel model)
        {
            var dto = Mapper.Map<TDto>(model);
            await HttpClient.PutAsJsonAsync(Uri, dto);
        }

        public async Task Delete(Guid id)
        {
            await HttpClient.DeleteAsync($"{Uri}/{id}");
        }
    }
}