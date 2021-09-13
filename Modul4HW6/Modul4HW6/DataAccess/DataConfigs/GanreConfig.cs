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
    public class GanreConfig : IEntityTypeConfiguration<Ganre>
    {
        public void Configure(EntityTypeBuilder<Ganre> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(x => x.Title)
                .HasColumnType("nvarchar")
                .HasMaxLength(300)
                .IsRequired();

            builder.HasData(new List<Ganre>()
            {
                new Ganre()
                {
                    Id = 1,
                    Title = "Rap"
                },

                new Ganre()
                {
                    Id = 2,
                    Title = "Pop music"
                },

                new Ganre()
                {
                    Id = 3,
                    Title = "Jazz"
                },

                new Ganre()
                {
                    Id = 4,
                    Title = "Rock"
                },

                new Ganre()
                {
                    Id = 5,
                    Title = "Country"
                }
            });
        }
    }
}
