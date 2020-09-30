using Microsoft.EntityFrameworkCore;
using Store.Entity.Domains;
using Store.Entity.Extentions;
using System;

namespace Store.Entity
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Account>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Seed();
        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<AccountType> AccountTypes { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
