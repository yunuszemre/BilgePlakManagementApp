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
    public class BaseProductConfiguration : IEntityTypeConfiguration<BaseProduct>
    {
        public void Configure(EntityTypeBuilder<BaseProduct> builder)
        {

            builder.HasOne(p => p.Category).WithMany(p1 => p1.Products).HasForeignKey(p2=>p2.CategoryId);
        }
    }
}
