using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using BlogPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogPlatform
{

    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogPostDb;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post()
                {
                    Id = 001,
                    Title = "Bike Riding",
                    Body = "This is my bike riding story.",
                    Author = "Nabil",
                    PublishDate = DateTime.Now
                },

                new Post()
                {
                    Id = 002,
                    Title = "Photography",
                    Body = "This is my photography story.",
                    Author = "Tatyana",
                    PublishDate = DateTime.Now
                },

                new Post()
                {
                    Id = 003,
                    Title = "Blogging",
                    Body = "This is a blogger's blog about blogging.",
                    Author = "Blogger",
                    PublishDate = DateTime.Now
                },

                new Post()
                {
                    Id = 004,
                    Title = "Computer Hardware",
                    Body = "This is a computer hardware blog post.",
                    Author = "Stefan",
                    PublishDate = DateTime.Now
                });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                });

            modelBuilder.Entity<Tag>().HasData(
                new Tag()
                {
                });

            base.OnModelCreating(modelBuilder);
        }
    }
    
}
