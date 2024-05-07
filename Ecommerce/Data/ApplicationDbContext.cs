﻿using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Cameras", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Phones", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Headsets", DisplayOrder = 3 }
            );
        }
    }
}
