

using System.Text.Json.Serialization;

namespace QIX.BiblePTT.Models
{
    public class Chapter
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("bible_id")]
        public int BibleId { get; set; }
        [JsonPropertyName("bible_code")]
        public string? BibleCode { get; set; }
        [JsonPropertyName("book_id")]
        public int BookId { get; set; }
        [JsonPropertyName("book_code")]
        public string? BookCode { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("code")]
        public string? Code { get; set; }
    }
}