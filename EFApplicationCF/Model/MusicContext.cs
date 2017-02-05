using System.Data.Entity;

namespace EFApplicationCF.Model
{
    class MusicContext : DbContext
    {
        public MusicContext() : base("name=MusicContainer")
        { }

        public DbSet<Artist> Artists { get; set; }
    }
}

