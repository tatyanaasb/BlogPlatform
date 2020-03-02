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
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagPost> TagPosts { get; set; }

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
                    Title = "My Bike Riding Hobby",
                    Body = "This is my bike riding story.",
                    Author = "Nabil",
                    PublishDate = DateTime.Now,
                    CategoryId = 01
                    //TagId = 101
                },

                new Post()
                {
                    Id = 002,
                    Title = "My Photography Hobby",
                    Body = "This is my photography story.",
                    Author = "Tatyana",
                    PublishDate = DateTime.Now,
                    CategoryId = 02
                    //TagId = 201
                },

                new Post()
                {
                    Id = 003,
                    Title = "My Blogging Hobby",
                    Body = "This is a blogger's blog about blogging.",
                    Author = "Blogger",
                    PublishDate = DateTime.Now,
                    CategoryId = 03
                    //TagId = 301
                },

                new Post()
                {
                    Id = 004,
                    Title = "All About Movies",
                    Body = "This is a blog about movies",
                    Author = "Jeremy",
                    PublishDate = DateTime.Now,
                    CategoryId = 04
                    //TagId = 401
                });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 01,
                    Name = "Bike Riding"
                },

                new Category()
                {
                    Id = 02,
                    Name = "Photography"
                },

                new Category()
                {
                    Id = 03,
                    Name = "Blogging"
                },

                new Category()
                {
                    Id = 04,
                    Name = "Movies"
                });

            modelBuilder.Entity<Tag>().HasData(
                new Tag()
                {
                    Id = 101,
                    Name = "mountainbiking"
                },

                new Tag()
                {
                    Id = 102,
                    Name = "fitness"
                },

                new Tag()
                {
                    Id = 103,
                    Name = "adventure"
                },

                new Tag()
                {
                    Id = 201,
                    Name = "photooftheday"
                },
                new Tag()
                {
                    Id = 202,
                    Name = "naturephotography"
                },
                new Tag()
                {
                    Id = 203,
                    Name = "travelphotography"
                },
                new Tag()
                {
                    Id = 301,
                    Name = "lifestyleblogger"
                },
                new Tag()
                {
                    Id = 302,
                    Name = "socialmedia"
                },
                new Tag()
                {
                    Id = 303,
                    Name = "digitalmarketing"
                },
                new Tag()
                {
                    Id = 401,
                    Name = "comedy"
                },
                new Tag()
                {
                    Id = 402,
                    Name = "moviebuff"
                },
                new Tag()
                {
                    Id = 403,
                    Name = "filmmaking"
                });
            modelBuilder.Entity<TagPost>().HasData(
                new TagPost()
                {
                    Id = 1,
                    PostId = 001,
                    TagId = 101
                },
                new TagPost()
                {
                    Id = 2,
                    PostId = 001,
                    TagId = 102
                },
                new TagPost()
                {
                    Id = 3,
                    PostId = 001,
                    TagId = 103
                },
                new TagPost()
                {
                    Id = 4,
                    PostId = 002,
                    TagId = 201
                },
                new TagPost()
                {
                    Id = 5,
                    PostId = 002,
                    TagId = 202
                },
                new TagPost()
                {
                    Id = 6,
                    PostId = 002,
                    TagId = 203
                },
                new TagPost()
                {
                    Id = 7,
                    PostId = 003,
                    TagId = 301
                },
                new TagPost()
                {
                    Id = 8,
                    PostId = 003,
                    TagId = 302
                },
                new TagPost()
                {
                    Id = 9,
                    PostId = 003,
                    TagId = 303
                },
                new TagPost()
                {
                    Id = 10,
                    PostId = 004,
                    TagId = 401
                },
                new TagPost()
                {
                    Id = 11,
                    PostId = 004,
                    TagId = 402
                },
                new TagPost()
                {
                    Id = 12,
                    PostId = 004,
                    TagId = 403
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
