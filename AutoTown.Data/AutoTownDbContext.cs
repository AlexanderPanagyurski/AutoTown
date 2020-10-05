using AutoTown.Common;
using AutoTown.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTown.Data
{
    public class AutoTownDbContext : DbContext
    {
        public AutoTownDbContext(DbContextOptions options) : base(options)
        {
        }

        public AutoTownDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }
        public DbSet<Car> Cars { get; set; }

        public DbSet<CarComment> CarComments { get; set; }

        public DbSet<CarEngine> CarEngines { get; set; }

        public DbSet<ChatConversation> ChatConversations { get; set; }

        public DbSet<ChatMessage> ChatMessages { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<WishList> WishLists { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
