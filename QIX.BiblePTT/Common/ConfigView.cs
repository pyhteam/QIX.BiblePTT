

namespace QIX.BiblePTT.Common
{
    public class ConfigView
    {
        public string? FontFamily { get; set; }
        public float? FontSize { get; set; }
        public FontStyle? FontStyle { get; set; }
        public Color? Color { get; set; }
        public string? TextAlign { get; set; }
        public string? ImagePath { get; set; }
        public int? TypeShow { get; set; } = 0; // 0: Bible, 1: Hymn
    }
}