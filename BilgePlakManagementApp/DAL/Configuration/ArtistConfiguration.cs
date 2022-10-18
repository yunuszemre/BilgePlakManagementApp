using BilgePlakManagementApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgePlakManagementApp.DAL.Configuration
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        

        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasKey(p => p.ArtistId);

            builder.Property(p => p.ArtistName).HasMaxLength(255);

            builder.Property(p => p.ModifiedDate).HasDefaultValue(DateTime.Now);

            builder.Property(p => p.RecordDate).HasDefaultValue(DateTime.Now);

            builder.Property(p => p.BirthDate).HasDefaultValue(DateTime.Now);

            builder.HasData(
                new Artist { ArtistId = 1, ArtistName = "Barış Manço", BirthDate = null, RecordDate = DateTime.Now, ModifiedDate = DateTime.Now },
                 new Artist { ArtistId = 2, ArtistName = "Cem Karaca", BirthDate = null, RecordDate = DateTime.Now, ModifiedDate = DateTime.Now }
                );



        }
    }
}
