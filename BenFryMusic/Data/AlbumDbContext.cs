using BenFryMusic.Data.Models;

namespace BenFryMusic.Data;
using Microsoft.EntityFrameworkCore;

public class AlbumDbContext : DbContext
{
    public AlbumDbContext(DbContextOptions<AlbumDbContext> options)
        : base(options)
    {}
    
    public DbSet<Album2> Albums2 { get; set; }
}