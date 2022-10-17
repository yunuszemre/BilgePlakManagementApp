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
    public class AlbumConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(p => p.ProductId);

            builder.Property(p => p.ProductCode).HasMaxLength(100).HasColumnName("char(100)");

            builder.Property(p => p.AlbumName).HasMaxLength(255);

            builder.HasOne(p => p.Artist).WithMany(p1 => p1.Albums).HasForeignKey(p2 => p2.ArtistId).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Category).WithMany(p1 => p1.Albums).HasForeignKey(p2 => p2.CategoryId).OnDelete(DeleteBehavior.Restrict);
            
        }
    }
}
