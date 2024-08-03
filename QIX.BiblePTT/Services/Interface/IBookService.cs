
using QIX.BiblePTT.Models;
using QIX.BiblePTT.Services.Base;

namespace QIX.BiblePTT.Services.Interface
{
    public interface IBookService:IBaseService<Book>
    {
        Task<List<Book>> GetAll(string bibleCode,string filter = null);
    }
}