
using System.Text.Json.Serialization;

namespace QIX.BiblePTT.Models
{
    public class Publisher
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("name_local")]
        public string? LocalName { get; set; }
        [JsonPropertyName("url")]
        public string? Url { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}