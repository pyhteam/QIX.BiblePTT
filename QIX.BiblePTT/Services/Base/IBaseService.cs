namespace QIX.BiblePTT.Services.Base
{
    public interface IBaseService<T> where T : class
    {
        Task<List<T>> GetAll(string filter=null);
        Task<T> GetById(int id);
        Task<T> GetByCode(string code);
    }
}