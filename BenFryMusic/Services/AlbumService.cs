using BenFryMusic.Data;
using Microsoft.EntityFrameworkCore;
using BenFryMusic.Data.Models;

namespace BenFryMusic.Services;

public class AlbumService
{
    private IDbContextFactory<AlbumDbContext> _dbContextFactory;

    public AlbumService(IDbContextFactory<AlbumDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public void AddAlbum(Album2 album)
    {
        using (var context = _dbContextFactory.CreateDbContext())
        {
            context.Albums2.Add(album);
            context.SaveChanges();
        }
    }

    public List<Album2> GetCustomers()
    {
        using (var context = _dbContextFactory.CreateDbContext())
        {
            var albums = context.Albums2.ToList();
            return albums;
        }
    }
}