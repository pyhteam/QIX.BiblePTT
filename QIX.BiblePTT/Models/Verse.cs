

using System.Text.Json.Serialization;

namespace QIX.BiblePTT.Models
{
    public class Verse
    {
        [JsonPropertyName("bible_id")]
        public string? BibleId { get; set; }
        [JsonPropertyName("chapter_code")]
        public string? ChapterCode { get; set; }
        [JsonPropertyName("verse_code")]
        public string? VerseCode { get; set; }
        [JsonPropertyName("label")]
        public string? Label { get; set; }
        [JsonPropertyName("content")]
        public string? Content { get; set; }
    }
}