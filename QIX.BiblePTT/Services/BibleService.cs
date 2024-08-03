
using Newtonsoft.Json;
using QIX.BiblePTT.Models;
using QIX.BiblePTT.Services.Interface;

namespace QIX.BiblePTT.Services
{
    public class BibleService : IBibleService
    {
        private string dataFolder;
        private List<Bible> Bibles { get; set; }
        public BibleService()
        {
            Bibles = new List<Bible>();
            // get path Resource from Src.Resources
            dataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Resources", "Data", "Bibles");

            // Load bibles from JSON files
            var files = Directory.GetFiles(dataFolder, "*.json");
            if (files.Length == 0)
            {
                throw new Exception("No Bible data files found.");
            }
            Bibles = files
                .Select(file => System.Text.Json.JsonSerializer.Deserialize<Bible>(File.ReadAllText(file)))
                .ToList();
        }

        public Task<List<Bible>> GetAll(string filter = null)
        {
            var data = Bibles
                .Where(bible => string.IsNullOrEmpty(filter) ||
                    (!string.IsNullOrEmpty(bible.Code) && bible.Code.Contains(filter)) ||
                    (!string.IsNullOrEmpty(bible.Name) && bible.Name.Contains(filter)) ||
                    (!string.IsNullOrEmpty(bible.NameEn) && bible.NameEn.Contains(filter)))
                .ToList();
            return Task.FromResult(data);
        }

        public Task<Bible> GetByCode(string code)
        {
            var data = Bibles.FirstOrDefault(bible => bible.Code == code);
            return Task.FromResult(data);
        }

        public Task<Bible> GetById(int id)
        {
            var data = Bibles.FirstOrDefault(bible => bible.Id == id);
            return Task.FromResult(data);
        }
    }
}