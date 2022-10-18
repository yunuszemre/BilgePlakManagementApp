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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(p=>p.CategoryId);

            builder.Property(p => p.CategoryName).HasMaxLength(100);

            builder.HasData(new Category { CategoryId = 1, CategoryName = "Plak", RecordDate = DateTime.Now, ModifiedDate = DateTime.Now });

           
        }
    }
}
