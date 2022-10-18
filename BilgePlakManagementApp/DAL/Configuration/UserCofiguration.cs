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
    public class UserCofiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(p => p.UserId);

            builder.Property(p => p.UserName).HasMaxLength(255);

            builder.Property(p=>p.Password).HasMaxLength(255);

            builder.HasData(new User { UserId = 1, UserName = "Admin", Password = "Asdf_1234", RecordDate = DateTime.Now, ModifiedDate = DateTime.Now });
        }
    }
}
