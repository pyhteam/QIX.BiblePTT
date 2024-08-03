
using System.Text.Json.Serialization;

namespace QIX.BiblePTT.Models
{
    public class Copyright
    {
        [JsonPropertyName("html")]
        public string? Html { get; set; }
        [JsonPropertyName("text")]
        public string? Text { get; set; }
    }
}