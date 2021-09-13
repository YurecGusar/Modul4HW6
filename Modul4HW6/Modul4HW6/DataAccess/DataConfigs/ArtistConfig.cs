using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW6.Entities;

namespace Modul4HW6.DataAccess.DataConfigs
{
    public class ArtistConfig : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(x => x.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.DateOfBirth)
                .HasColumnType("date")
                .HasMaxLength(7)
                .IsRequired();
            builder.Property(x => x.Phone)
                .HasColumnType("varchar")
                .HasMaxLength(15);
            builder.Property(x => x.Email)
                .HasColumnType("varchar")
                .HasMaxLength(50);
            builder.Property(x => x.InstagramUrl)
                .HasColumnType("varchar")
                .HasMaxLength(150);

            builder.HasData(new List<Artist>()
            {
                new Artist()
                {
                    Id = 1,
                    Name = "Jay-Z",
                    DateOfBirth = new DateTime(1969, 12, 4),
                    Email = "Jay-Z@gmail.com",
                    InstagramUrl = "https://www.instagram.com/Jay-Z/",
                    Phone = "88005553535",
                },

                new Artist()
                {
                    Id = 2,
                    Name = "Elton John",
                    DateOfBirth = new DateTime(1947, 5, 25),
                    Email = "EltonJohn@gmail.com",
                    InstagramUrl = "https://www.instagram.com/Elton_John/",
                    Phone = "0509177329",
                },

                new Artist()
                {
                    Id = 3,
                    Name = "Eminem",
                    DateOfBirth = new DateTime(1972, 10, 17),
                    Email = "Eminem@gmail.com",
                    InstagramUrl = "https://www.instagram.com/Eminem/",
                    Phone = "0937299315",
                },

                new Artist()
                {
                    Id = 4,
                    Name = "Michael Jackson",
                    DateOfBirth = new DateTime(1958, 8, 29),
                    Email = "MichaelJackson@gmail.com",
                    InstagramUrl = "https://www.instagram.com/MichaelJackson/",
                    Phone = "17293711842",
                },

                new Artist()
                {
                    Id = 5,
                    Name = "Drake",
                    DateOfBirth = new DateTime(1986, 10, 24),
                    Email = "Drake@gmail.com",
                    InstagramUrl = "https://www.instagram.com/Drake/",
                    Phone = "32574523451",
                }
            });
        }
    }
}
