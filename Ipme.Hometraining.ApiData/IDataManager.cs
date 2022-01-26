

namespace Ipme.Hometraining.ApiData
{
    public interface IDataManager<TModel,TDto> where TModel : class 
                                                where TDto : class
    {

        Task<IEnumerable<TModel>> GetAll();   

        Task<TModel> Get(Guid id);

        Task Add(TModel model);

        Task Put(TModel model);

        Task Delete(Guid id);
    }
}