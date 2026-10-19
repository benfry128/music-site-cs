using System.ComponentModel.DataAnnotations;
namespace BenFryMusic.Data.Models;

public class Album2
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Artist { get; set; }
    public string ImageUrl { get; set; }
    public DateOnly ReleaseDate { get; set; }
    public int Rating { get; set; }
    public DateOnly ListenedDate { get; set; }
    public string TopSong { get; set; }
    public string? SpotifyId { get; set; }
    public int? Ranking { get; set; }
    public int? QueuePosition { get; set; }
    public string Url { get; set; }
}