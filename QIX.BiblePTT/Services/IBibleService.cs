
using QIX.BiblePTT.Common;

namespace QIX.BiblePTT.Services
{
    public interface IBibleService
    {
        Task<ApiResponse> GetBibles(string language_tag,string type);
    }
}