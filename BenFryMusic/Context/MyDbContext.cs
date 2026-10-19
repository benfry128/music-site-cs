using BenFryMusic.Entities;
using Microsoft.EntityFrameworkCore;

namespace BenFryMusic.Context;

public class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Album> Albums { get; set; }

    public virtual DbSet<AlbumNote> AlbumNotes { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Album>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("albums");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Artist)
                .HasMaxLength(150)
                .HasColumnName("artist");
            entity.Property(e => e.DateListened).HasColumnName("date_listened");
            entity.Property(e => e.DateReleased).HasColumnName("date_released");
            entity.Property(e => e.FavoriteSong)
                .HasMaxLength(150)
                .HasDefaultValueSql("''")
                .HasColumnName("favorite_song");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(150)
                .HasColumnName("image_url");
            entity.Property(e => e.QueuePosition).HasColumnName("queue_position");
            entity.Property(e => e.Ranking).HasColumnName("ranking");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.SpotifyId)
                .HasMaxLength(45)
                .HasColumnName("spotify_id");
            entity.Property(e => e.Title)
                .HasMaxLength(150)
                .HasColumnName("title");
            entity.Property(e => e.Url)
                .HasMaxLength(150)
                .HasColumnName("url");
        });

        modelBuilder.Entity<AlbumNote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("album_notes");

            entity.HasIndex(e => e.AlbumId, "album_notes_to_albums_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AlbumId).HasColumnName("album_id");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .HasColumnName("notes");
            entity.Property(e => e.Source)
                .HasMaxLength(45)
                .HasColumnName("source");

            entity.HasOne(d => d.Album).WithMany(p => p.AlbumNotes)
                .HasForeignKey(d => d.AlbumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("album_notes_to_albums");
        });
    }
}
