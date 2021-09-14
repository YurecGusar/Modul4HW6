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
    public class GanreConfig : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(x => x.Title)
                .HasColumnType("nvarchar")
                .HasMaxLength(300)
                .IsRequired();

            builder.HasData(new List<Genre>()
            {
                new Genre()
                {
                    Id = 1,
                    Title = "Rap"
                },

                new Genre()
                {
                    Id = 2,
                    Title = "Pop music"
                },

                new Genre()
                {
                    Id = 3,
                    Title = "Jazz"
                },

                new Genre()
                {
                    Id = 4,
                    Title = "Rock"
                },

                new Genre()
                {
                    Id = 5,
                    Title = "Folk songs"
                }
            });
        }
    }
}
