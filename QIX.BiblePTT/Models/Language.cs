using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QIX.BiblePTT.Models
{
    public class Language
    {
        [JsonPropertyName("iso_639_1")]
        public string? Iso639_1 { get; set; }
        [JsonPropertyName("iso_639_3")]
        public string? Iso639_3 { get; set; }
        public string? Name { get; set; }
        [JsonPropertyName("name_local")]
        public string? LocalName { get; set; }
        [JsonPropertyName("text_direction")]
        public string? TextDirection { get; set; }
        [JsonPropertyName("language_tag")]
        public string? LanguageTag { get; set; }
        [JsonPropertyName("secondary_language_tags")]
        public string? SecondaryLanguageTags { get; set; }
    }
}