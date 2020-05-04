using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options)
            : base(options)
        {
        }
        public DbSet<Music> Musics { get; set; }
     }
}