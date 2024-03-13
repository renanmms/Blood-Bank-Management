using System;
using System.Reflection;
using BloodBankManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BloodBankManagement.Infra.Persistence
{
    public class BloodBankDbContext : DbContext
    {
        public BloodBankDbContext(DbContextOptions<BloodBankDbContext> options) 
            : base(options)
        {
            }

        public DbSet<Donator> Donators { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<BloodStock> BloodStock { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}