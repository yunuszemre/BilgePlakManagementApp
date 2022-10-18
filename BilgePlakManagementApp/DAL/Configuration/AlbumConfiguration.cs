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

            builder.Property(p => p.ProductCode).HasMaxLength(100);

            builder.Property(p => p.AlbumName).HasMaxLength(255);

            builder.Property(p => p.ModifiedDate).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.RecordDate).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.ReleaseDate).HasDefaultValue(DateTime.Now);
            builder.HasOne(p => p.Artist).WithMany(p1 => p1.Albums).HasForeignKey(p2 => p2.ArtistId).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Category).WithMany(p1 => p1.Albums).HasForeignKey(p2 => p2.CategoryId).OnDelete(DeleteBehavior.Restrict);

            builder.HasData
                (
                new Album { AlbumName = "Darısı Başınıza",ProductCode="BM000001", ArtistId = 1, CategoryId = 1, CriticalLevel = 10, Discontinued = false, Discount = 10, Price = 100, ModifiedDate = DateTime.Now, RecordDate = DateTime.Now, UnitsInStock = 10, ProductId = 1 },
                new Album { AlbumName = "Nerede Kalmıştık", ProductCode="CK000001",ArtistId = 2, CategoryId = 1, CriticalLevel = 10, Discontinued = false, Discount = 10, Price = 100, ModifiedDate = DateTime.Now, RecordDate = DateTime.Now, UnitsInStock = 10, ProductId = 2 }
                );

        }
    }
}
