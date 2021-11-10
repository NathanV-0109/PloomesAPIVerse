using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyVerse.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyVerse.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Verses> Verses { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Verses>().HasKey(v =>
            new { v.id });
        }
    }
}
