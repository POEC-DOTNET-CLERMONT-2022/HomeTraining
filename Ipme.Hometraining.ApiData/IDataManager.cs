

namespace Ipme.Hometraining.ApiData
{
    public interface IDataManager<TModel,TDto> where TModel : class 
                                                where TDto : class
    {

        public Task<IEnumerable<TModel>> GetAll();

        public Task<TModel> Get(Guid id);

        public Task Add(TModel model);

        public Task Put(TModel model);

        public Task Delete(Guid id);
    }
}