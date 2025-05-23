﻿using Microsoft.EntityFrameworkCore;
using OnlineBankApp.Entities;

namespace OnlineBankApp.DataAccess.DataContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
