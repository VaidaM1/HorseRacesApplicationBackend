using HorseRaseApplicationBackend.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorseRaseApplicationBackend.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Horse> Horses { get; set; }
        public DbSet<Better> Betters { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Better>()
                .HasOne(r => r.Horse)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
