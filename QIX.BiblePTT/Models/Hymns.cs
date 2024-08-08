
namespace QIX.BiblePTT.Models;

public class Hymn
{
    public int Id { get; set; }
    public int Label { get; set; }
    public string? Name { get; set; }
    public List<HymnVerse>? Verses { get; set; }
}

public class HymnVerse
{
    public int SongId { get; set; }
    public string? Content { get; set; }
}

public class HymnBook
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? NameFull { get; set; }
    public string? Type { get; set; }
    public List<Hymn>? Hymns { get; set; }
}

