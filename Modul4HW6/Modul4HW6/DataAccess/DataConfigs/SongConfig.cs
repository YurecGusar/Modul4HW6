using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Modul4HW6.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modul4HW6.DataAccess.DataConfigs
{
    public class SongConfig : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(x => x.Title)
                .HasColumnType("nvarchar")
                .HasMaxLength(300)
                .IsRequired();
            builder.Property(x => x.Duration)
                .HasColumnType("float")
                .IsRequired();
            builder.HasOne(x => x.Genre)
                .WithMany(x => x.Songs)
                .HasForeignKey(x => x.GenreId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder.HasData(new List<Song>()
            {
                new Song()
                {
                    Id = 1,
                    Duration = 2.54d,
                    ReleasedDate = new DateTime(2016, 4, 5),
                    GenreId = 1,
                    Title = "One Dance"
                },

                new Song()
                {
                    Id = 2,
                    Duration = 4.38d,
                    ReleasedDate = new DateTime(2009, 11, 28),
                    GenreId = 1,
                    Title = "Empire State Of Mind"
                },

                new Song()
                {
                    Id = 3,
                    Duration = 4.15d,
                    ReleasedDate = new DateTime(2010, 1, 25),
                    GenreId = 1,
                    Title = "Young Forever"
                },

                new Song()
                {
                    Id = 4,
                    Duration = 5.47d,
                    ReleasedDate = new DateTime(2018, 8, 27),
                    GenreId = 1,
                    Title = "Marvins Room"
                },

                new Song()
                {
                    Id = 5,
                    Duration = 4.19d,
                    ReleasedDate = new DateTime(1987, 8, 31),
                    GenreId = 2,
                    Title = "Bad"
                },

                new Song()
                {
                    Id = 6,
                    Duration = 4.53d,
                    ReleasedDate = new DateTime(1982, 2, 13),
                    GenreId = 2,
                    Title = "Billie Jean"
                },

                new Song()
                {
                    Id = 7,
                    Duration = 2.54d,
                    ReleasedDate = new DateTime(1989, 4, 5),
                    GenreId = 2,
                    Title = "Sacrifice"
                },

                new Song()
                {
                    Id = 8,
                    Duration = 6.46d,
                    ReleasedDate = new DateTime(1971, 4, 5),
                    GenreId = 2,
                    Title = "Tiny Dancer"
                },

                new Song()
                {
                    Id = 9,
                    Duration = 4.15d,
                    ReleasedDate = new DateTime(2018, 10, 5),
                    GenreId = 1,
                    Title = "Venom"
                },

                new Song()
                {
                    Id = 10,
                    Duration = 4.17d,
                    ReleasedDate = new DateTime(2009, 12, 25),
                    GenreId = 1,
                    Title = "Mockingbird"
                },

                new Song()
                {
                    Id = 11,
                    Duration = 3.16d,
                    ReleasedDate = new DateTime(1971, 11, 1),
                    GenreId = 5,
                    Title = "Banks of the Ohio"
                }
            });
        }
    }
}
