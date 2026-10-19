namespace BenFryMusic.Entities;

public class AlbumNote
{
    public int Id { get; set; }

    public int AlbumId { get; set; }

    public string? Notes { get; set; }

    public string? Source { get; set; }

    public virtual Album Album { get; set; } = null!;
}
