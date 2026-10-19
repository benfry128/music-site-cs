using Microsoft.EntityFrameworkCore;
using BenFryMusic.Entities;
using BenFryMusic.Context;

namespace BenFryMusic.Services;

public class AlbumService
{
    private IDbContextFactory<MyDbContext> _dbContextFactory;

    public AlbumService(IDbContextFactory<MyDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public void AddAlbum(Album album)
    {
        using (var context = _dbContextFactory.CreateDbContext())
        {
            context.Albums.Add(album);
            context.SaveChanges();
        }
    }

    public List<Album> GetAllAlbums()
    {
        using (var context = _dbContextFactory.CreateDbContext())
        {
            var albums = context.Albums.ToList();
            return albums;
        }
    }
}