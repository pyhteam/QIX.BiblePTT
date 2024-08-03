

using System.Text.Json.Serialization;

namespace QIX.BiblePTT.Models
{
    public class Bible
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("language_code")]
        public string? LanguageCode { get; set; }
        [JsonPropertyName("code")]
        public string? Code { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("name_en")]
        public string? NameEn { get; set; }
        [JsonPropertyName("publisher")]
        public Publisher? Publisher { get; set; }
        [JsonPropertyName("copyright_long")]
        public Copyright? CopyrightLong { get; set; }
        [JsonPropertyName("copyright_short")]
        public Copyright? CopyrightShort { get; set; }
        [JsonPropertyName("language")]
        public Language? Language { get; set; }
        [JsonPropertyName("audio")]
        public bool Audio { get; set; }
        [JsonPropertyName("audio_count")]
        public int AudioCount { get; set; }
    }
}