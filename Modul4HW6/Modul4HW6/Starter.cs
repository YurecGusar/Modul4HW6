using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;
using Modul4HW6.DataAccess;
using Modul4HW6.Services.Abstractions;

namespace Modul4HW6
{
    public class Starter
    {
        private IAppConfigService _config;

        public Starter(
            IAppConfigService configService)
        {
            _config = configService;
        }

        public void Run()
        {
            var dbOptions = new DbContextOptionsBuilder<Modul4HW6DBContext>()
                .UseSqlServer(_config.ConnectionString);
            using var dbContext = new Modul4HW6DBContext(dbOptions.Options);

            var query1 = dbContext.ArtistsSongs.Where(x => x.ArtistsId != null)
                .Include(x => x.Song)
                    .ThenInclude(x => x.Genre)
                .Include(x => x.Artist)
                .Select(x => new
                {
                    SongName = x.Song.Title,
                    ArtistName = x.Artist.Name,
                    Genre = x.Song.Genre.Title
                });

            foreach (var item in query1)
            {
                System.Console.WriteLine($"{item.ArtistName} | {item.SongName} | {item.Genre}");
            }
        }
    }
}
