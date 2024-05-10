using AlbumApp.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace AlbumApp.Data
{
    public class AlbumsDBContext : DbContext
    {
        public AlbumsDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Album> Albums { get; set; }

    }
}

