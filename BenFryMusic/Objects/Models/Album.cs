namespace BenFryMusic.Objects.Models;

public class Album
{
    public required int Id { get; set; }
    public required string Title { get; set; }
    public required string Artist { get; set; }
    public required DateOnly ReleaseDate { get; set; }
    public required int Rating { get; set; }
    public required DateOnly ListenedDate { get; set; }
    public required string TopSong { get; set; }
    public int? Ranking { get; set; }
    public int? QueuePosition { get; set; }
}