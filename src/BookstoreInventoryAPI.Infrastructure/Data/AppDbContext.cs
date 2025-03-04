using BookstoreInventoryAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookstoreInventoryAPI.Infrastructure.Data;
public class AppDbContext: DbContext
    {


        public DbSet<Book> Books { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users{ get; set; }
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

    }
