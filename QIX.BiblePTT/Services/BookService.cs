
using System.Text.RegularExpressions;
using QIX.BiblePTT.Models;
using QIX.BiblePTT.Services.Interface;

namespace QIX.BiblePTT.Services
{
    public class BookService : IBookService
    {
        private string dataFolder;
        private List<Book> Books { get; set; }
        public BookService()
        {
            Books = new List<Book>();
            // get path Resource from Src.Resources
            dataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Books");
            // Load books from JSON files
            var files = Directory.GetFiles(dataFolder, "*.json");
            if (files.Length == 0)
            {
                throw new Exception("No Book data files found.");
            }
            Books = files
                .SelectMany(file => System.Text.Json.JsonSerializer.Deserialize<List<Book>>(File.ReadAllText(file)))
                .Where(book => book != null)
                .ToList();
        }
        public Task<List<Book>> GetAll(string filter = null)
        {
            return Task.FromResult(Books.Where(book => filter == null ||
                book.Code.Contains(filter)
                || book.Name.Contains(filter)
                || book.NameLong.Contains(filter))
                .ToList());
        }

        public Task<Book> GetByCode(string code)
        {
            var book = Books.FirstOrDefault(book => book.Code == code);
            return Task.FromResult(book);
        }

        public Task<Book> GetById(int id)
        {
            var book = Books.FirstOrDefault(book => book.Id == id);
            return Task.FromResult(book);
        }

        public Task<List<Book>> GetAll(string bibleCode, string? filter = null)
        {
            var books = Books.Where(book => book.BibleCode == bibleCode).ToList();
            if (!string.IsNullOrEmpty(filter))
            {
                var filters = new List<Book>();
                foreach (var item in books)
                {
                    string regex = string.Format(".*{0}.*", filter);
                    if (Regex.IsMatch(item.Name, regex, RegexOptions.IgnoreCase))
                    {
                        filters.Add(item);
                    }
                    
                }
                books = filters;
            }

            return Task.FromResult(books);
        }
    }
}