using BilgePlakManagementApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgePlakManagementApp.DAL.Context
{
    public class PlakDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<BaseProduct> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-0Q6EI49\YUNUS; Database=BilgePlakDB; uid=sa; pwd=1234");

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration();
            base.OnModelCreating(modelBuilder);
        }
    }
}
