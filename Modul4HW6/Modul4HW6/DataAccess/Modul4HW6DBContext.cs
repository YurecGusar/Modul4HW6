using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modul4HW6.DataAccess.DataConfigs;
using Modul4HW6.Entities;

namespace Modul4HW6.DataAccess
{
    public class Modul4HW6DBContext : DbContext
    {
        public Modul4HW6DBContext(DbContextOptions<Modul4HW6DBContext> dbContextOptions)
            : base(dbContextOptions)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistsSongs> ArtistsSongs { get; set; }
        public DbSet<Ganre> Ganres { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ArtistConfig());
            builder.ApplyConfiguration(new ArtistsSongsConfig());
            builder.ApplyConfiguration(new GanreConfig());
            builder.ApplyConfiguration(new SongConfig());
        }
    }
}
