using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW6.Entities;

namespace Modul4HW6.DataAccess.DataConfigs
{
    public class ArtistsSongsConfig : IEntityTypeConfiguration<ArtistsSongs>
    {
        public void Configure(EntityTypeBuilder<ArtistsSongs> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.HasOne(x => x.Artist)
                .WithMany(x => x.Songs)
                .HasForeignKey(x => x.ArtistsId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Song)
                .WithMany(x => x.Artists)
                .HasForeignKey(x => x.SongsId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder.HasData(new List<ArtistsSongs>()
            {
                new ArtistsSongs()
                {
                    Id = 1,
                    ArtistsId = 5,
                    SongsId = 1
                },

                new ArtistsSongs()
                {
                    Id = 2,
                    ArtistsId = 1,
                    SongsId = 2
                },

                new ArtistsSongs()
                {
                    Id = 3,
                    ArtistsId = 1,
                    SongsId = 3
                },

                new ArtistsSongs()
                {
                    Id = 4,
                    ArtistsId = 5,
                    SongsId = 4
                },

                new ArtistsSongs()
                {
                    Id = 5,
                    ArtistsId = 4,
                    SongsId = 5
                },

                new ArtistsSongs()
                {
                    Id = 6,
                    ArtistsId = 4,
                    SongsId = 6
                },

                new ArtistsSongs()
                {
                    Id = 7,
                    ArtistsId = 2,
                    SongsId = 7
                },

                new ArtistsSongs()
                {
                    Id = 8,
                    ArtistsId = 2,
                    SongsId = 8
                },

                new ArtistsSongs()
                {
                    Id = 9,
                    ArtistsId = 3,
                    SongsId = 9
                },

                new ArtistsSongs()
                {
                    Id = 10,
                    ArtistsId = 3,
                    SongsId = 10
                },

                new ArtistsSongs()
                {
                    Id = 11,
                    ArtistsId = null,
                    SongsId = 11
                }
            });
        }
    }
}
