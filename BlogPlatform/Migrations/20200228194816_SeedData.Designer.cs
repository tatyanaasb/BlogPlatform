﻿// <auto-generated />
using System;
using BlogPlatform;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogPlatform.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20200228194816_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogPlatform.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bike Riding"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Photography"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Blogging"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Movies"
                        });
                });

            modelBuilder.Entity("BlogPlatform.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Nabil",
                            Body = "This is my bike riding story.",
                            PublishDate = new DateTime(2020, 2, 28, 14, 48, 16, 227, DateTimeKind.Local).AddTicks(6425),
                            Title = "My Bike Riding Hobby"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Tatyana",
                            Body = "This is my photography story.",
                            PublishDate = new DateTime(2020, 2, 28, 14, 48, 16, 232, DateTimeKind.Local).AddTicks(4469),
                            Title = "My Photography Hobby"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Blogger",
                            Body = "This is a blogger's blog about blogging.",
                            PublishDate = new DateTime(2020, 2, 28, 14, 48, 16, 232, DateTimeKind.Local).AddTicks(4536),
                            Title = "My Blogging Hobby"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Jeremy",
                            Body = "This is a blog about movies",
                            PublishDate = new DateTime(2020, 2, 28, 14, 48, 16, 232, DateTimeKind.Local).AddTicks(4544),
                            Title = "All About Movies"
                        });
                });

            modelBuilder.Entity("BlogPlatform.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tag");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            Name = "mountainbiking"
                        },
                        new
                        {
                            Id = 102,
                            Name = "fitness"
                        },
                        new
                        {
                            Id = 103,
                            Name = "adventure"
                        },
                        new
                        {
                            Id = 201,
                            Name = "photooftheday"
                        },
                        new
                        {
                            Id = 202,
                            Name = "naturephotography"
                        },
                        new
                        {
                            Id = 203,
                            Name = "travelphotography"
                        },
                        new
                        {
                            Id = 301,
                            Name = "lifestyleblogger"
                        },
                        new
                        {
                            Id = 302,
                            Name = "socialmedia"
                        },
                        new
                        {
                            Id = 303,
                            Name = "digitalmarketing"
                        },
                        new
                        {
                            Id = 401,
                            Name = "comedy"
                        },
                        new
                        {
                            Id = 402,
                            Name = "moviebuff"
                        },
                        new
                        {
                            Id = 403,
                            Name = "filmmaking"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
