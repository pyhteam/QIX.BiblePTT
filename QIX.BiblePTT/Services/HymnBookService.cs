
using Newtonsoft.Json;
using QIX.BiblePTT.Models;
using QIX.BiblePTT.Services.Interface;

namespace QIX.BiblePTT.Services
{
    public class HymnBookService : IHymnBookService
    {
        private string dataFolder;
        private List<HymnBook> HymnBooks { get; set; }
        private List<Hymn> Hymns { get; set; }
        public HymnBookService()
        {
            HymnBooks = new List<HymnBook>();
            // get path Resource from Src.Resources
            dataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "HymnBooks");

            // Load bibles from JSON files
            var files = Directory.GetFiles(dataFolder, "*.json");
            if (files.Length == 0)
            {
                throw new Exception("No Bible data files found.");
            }
            HymnBooks = files
                .Select(file => JsonConvert.DeserializeObject<HymnBook>(File.ReadAllText(file)))
                .ToList();
        }

        public Task<List<HymnBook>> GetAll(string filter = null)
        {
            var data = HymnBooks
                 .Where(bible => string.IsNullOrEmpty(filter) ||
                     (!string.IsNullOrEmpty(bible.NameFull) && bible.NameFull.Contains(filter)) ||
                     (!string.IsNullOrEmpty(bible.Name) && bible.Name.Contains(filter)))
                 .ToList();
            return Task.FromResult(data);
        }

        public Task<HymnBook> GetByCode(string code)
        {
            throw new NotImplementedException();
        }

        public Task<HymnBook> GetById(int id)
        {
            var hymnBook = HymnBooks.FirstOrDefault(b => b.Id == id);
            if (hymnBook == null)
            {
                throw new Exception($"Hymn book with ID {id} not found.");
            }
            return Task.FromResult(hymnBook);
        }
    }
}