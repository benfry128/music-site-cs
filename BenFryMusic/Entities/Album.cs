namespace BenFryMusic.Entities;

public class Album
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Artist { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public DateOnly DateReleased { get; set; }

    public int? Rating { get; set; }

    public DateOnly? DateListened { get; set; }

    public string? FavoriteSong { get; set; }

    public int? Ranking { get; set; }

    public string? SpotifyId { get; set; }

    public int? QueuePosition { get; set; }

    public string? Url { get; set; }

    public virtual ICollection<AlbumNote> AlbumNotes { get; set; } = new List<AlbumNote>();
}
