namespace Profiles
{
    internal interface IApiDataManager<TModel,TDto> where TModel : class 
                                                    where TDto : class
    {
        IEnumerable<TModel> GetAll();
    }
}