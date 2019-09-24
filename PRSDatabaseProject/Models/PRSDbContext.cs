using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRSDatabaseProject.Models {
    public class PRSDb : DbContext {

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<Vendor>()
                 .HasIndex(v => v.Code)
                 .IsUnique();

            modelBuilder.Entity<Product>()
                .HasIndex(p => p.PartNbr)
                .IsUnique();

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(11, 2)");

            modelBuilder.Entity<Request>()
                .Property(t => t.Total)
                .HasColumnType("decimal(11, 2)")
                .HasDefaultValue(0);


            modelBuilder.Entity<Request>()
                .Property(dm => dm.DeliveryMode)
                .HasDefaultValue("Pickup");

            modelBuilder.Entity<Request>()
                .Property(s => s.Status)
                .HasDefaultValue("New");

            modelBuilder.Entity<RequestLine>()
                .Property(q => q.Quantity)
                .HasDefaultValue(1);

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Request> Requests { get; set; }

        public DbSet<RequestLine> RequestLines { get; set; }

        public PRSDb(DbContextOptions options) : base(options) {

        }


    }
}
