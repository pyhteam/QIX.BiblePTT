
using QIX.BiblePTT.Models;
namespace QIX.BiblePTT.Common
{
    public class ShowPPTX
    {
        public string? FilePath { get; set; }
        public string? BookName { get; set; }
        public int ChapterNumber { get; set; }
        public string? BibleName { get; set; }
        public List<Verse>? Verses { get; set; }
        public ConfigView? Config { get; set; }
    }
}