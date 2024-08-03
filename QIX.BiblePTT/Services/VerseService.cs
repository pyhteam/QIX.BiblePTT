
using QIX.BiblePTT.Models;
using QIX.BiblePTT.Services.Interface;

namespace QIX.BiblePTT.Services
{

    public class VerseService : IVerseService
    {
        private string dataFolder;
        private List<Verse> Verses { get; set; }
        public VerseService()
        {
            Verses = new List<Verse>();
            // get path Resource from Src.Resources
            dataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Resources", "Data", "Verses");
            string[] files;
            // forech all folders in the directory
            foreach (var dir in Directory.GetDirectories(dataFolder))
            {
                // get all files in the folder
                files = Directory.GetFiles(dir, "*.json");
                if (files.Length == 0)
                {
                    throw new Exception("No Book data files found.");
                }
                Verses.AddRange(files
                    .SelectMany(file => System.Text.Json.JsonSerializer.Deserialize<List<Verse>>(File.ReadAllText(file)))
                    .Where(book => book != null)
                    .ToList());
            }
        }

        public Task<List<Verse>> GetAll(string filter = null)
        {
            var verses = Verses.Where(verse => filter == null ||
                (verse.BibleId != null && verse.BibleId.Contains(filter)) ||
                (verse.ChapterCode != null && verse.ChapterCode.Contains(filter)) ||
                (verse.Label != null && verse.Label.Contains(filter)) ||
                (verse.VerseCode != null && verse.VerseCode.Contains(filter)))
                .ToList();
            return Task.FromResult(verses);
        }

        public Task<Verse> GetByCode(string code)
        {
            var verse = Verses.FirstOrDefault(verse => verse.VerseCode == code);
            return Task.FromResult(verse);
        }

        public Task<Verse> GetById(int id)
        {
            var verse = Verses.FirstOrDefault(verse => verse.Label == id.ToString());
            return Task.FromResult(verse);
        }


        public Task<List<Verse>> GetFromTo(string bibleId, string chapterCode, int fromLabel, int toLabel)
        {
            Verses.ForEach(verse =>
            {
                if (verse.Label.Contains("-"))
                {
                    var labels = verse.Label.Split("-");
                    verse.Label = labels[0];
                }
            });
            var verses = Verses.Where(verse => verse.BibleId == bibleId
                    && verse.ChapterCode == chapterCode
                    && int.Parse(verse.Label) >= fromLabel
                    && int.Parse(verse.Label) <= toLabel)
                .ToList();
            return Task.FromResult(verses);
        }


        public Task<List<Verse>> GetByChapter(int bibleId, string chapterCode)
        {
            var verse = Verses.Where(verse => verse.BibleId == bibleId.ToString()
                && verse.ChapterCode == chapterCode).ToList();
            return Task.FromResult(verse);
        }
    }
}