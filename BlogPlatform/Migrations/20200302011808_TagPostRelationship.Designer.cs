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
    [Migration("20200302011808_TagPostRelationship")]
    partial class TagPostRelationship
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

                    b.ToTable("Categories");

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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Nabil",
                            Body = "This is my bike riding story.",
                            CategoryId = 1,
                            PublishDate = new DateTime(2020, 3, 1, 20, 18, 8, 13, DateTimeKind.Local).AddTicks(1437),
                            Title = "My Bike Riding Hobby"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Tatyana",
                            Body = "This is my photography story.",
                            CategoryId = 2,
                            PublishDate = new DateTime(2020, 3, 1, 20, 18, 8, 16, DateTimeKind.Local).AddTicks(5122),
                            Title = "My Photography Hobby"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Blogger",
                            Body = "This is a blogger's blog about blogging.",
                            CategoryId = 3,
                            PublishDate = new DateTime(2020, 3, 1, 20, 18, 8, 16, DateTimeKind.Local).AddTicks(5209),
                            Title = "My Blogging Hobby"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Jeremy",
                            Body = "This is a blog about movies",
                            CategoryId = 4,
                            PublishDate = new DateTime(2020, 3, 1, 20, 18, 8, 16, DateTimeKind.Local).AddTicks(5217),
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

                    b.ToTable("Tags");

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

            modelBuilder.Entity("BlogPlatform.Models.TagPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("TagId");

                    b.ToTable("TagPosts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PostId = 1,
                            TagId = 101
                        },
                        new
                        {
                            Id = 2,
                            PostId = 1,
                            TagId = 102
                        },
                        new
                        {
                            Id = 3,
                            PostId = 1,
                            TagId = 103
                        },
                        new
                        {
                            Id = 4,
                            PostId = 2,
                            TagId = 201
                        },
                        new
                        {
                            Id = 5,
                            PostId = 2,
                            TagId = 202
                        },
                        new
                        {
                            Id = 6,
                            PostId = 2,
                            TagId = 203
                        },
                        new
                        {
                            Id = 7,
                            PostId = 3,
                            TagId = 301
                        },
                        new
                        {
                            Id = 8,
                            PostId = 3,
                            TagId = 302
                        },
                        new
                        {
                            Id = 9,
                            PostId = 3,
                            TagId = 303
                        },
                        new
                        {
                            Id = 10,
                            PostId = 4,
                            TagId = 401
                        },
                        new
                        {
                            Id = 11,
                            PostId = 4,
                            TagId = 402
                        },
                        new
                        {
                            Id = 12,
                            PostId = 4,
                            TagId = 403
                        });
                });

            modelBuilder.Entity("BlogPlatform.Models.Post", b =>
                {
                    b.HasOne("BlogPlatform.Models.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogPlatform.Models.TagPost", b =>
                {
                    b.HasOne("BlogPlatform.Models.Post", "Post")
                        .WithMany("TagPosts")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogPlatform.Models.Tag", "Tag")
                        .WithMany("TagPosts")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}