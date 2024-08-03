
using System.Text.Json.Serialization;

namespace QIX.BiblePTT.Models
{
    public class Book
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("bible_id")]
        public int BibleId { get; set; }

        [JsonPropertyName("bible_code")]
        public string? BibleCode { get; set; }
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("name_short")]
        public string? NameShort { get; set; }
        [JsonPropertyName("name_long")]
        public string? NameLong { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("chapters")]
        public List<Chapter>? Chapters { get; set; }
    }
}