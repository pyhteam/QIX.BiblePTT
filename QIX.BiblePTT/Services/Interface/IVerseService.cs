
using QIX.BiblePTT.Models;
using QIX.BiblePTT.Services.Base;

namespace QIX.BiblePTT.Services.Interface
{
    public interface IVerseService : IBaseService<Verse>
    {
        Task<List<Verse>> GetByChapter(int bibleId, string chapterCode);
        Task<List<Verse>> GetFromTo(string bibleId, string chapterCode, int fromLabel, int toLabel);
    }
}