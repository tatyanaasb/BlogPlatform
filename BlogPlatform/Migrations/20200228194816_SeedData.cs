using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bike Riding" },
                    { 2, "Photography" },
                    { 3, "Blogging" },
                    { 4, "Movies" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "Body", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "Nabil", "This is my bike riding story.", new DateTime(2020, 2, 28, 14, 48, 16, 227, DateTimeKind.Local).AddTicks(6425), "My Bike Riding Hobby" },
                    { 2, "Tatyana", "This is my photography story.", new DateTime(2020, 2, 28, 14, 48, 16, 232, DateTimeKind.Local).AddTicks(4469), "My Photography Hobby" },
                    { 3, "Blogger", "This is a blogger's blog about blogging.", new DateTime(2020, 2, 28, 14, 48, 16, 232, DateTimeKind.Local).AddTicks(4536), "My Blogging Hobby" },
                    { 4, "Jeremy", "This is a blog about movies", new DateTime(2020, 2, 28, 14, 48, 16, 232, DateTimeKind.Local).AddTicks(4544), "All About Movies" }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 401, "comedy" },
                    { 303, "digitalmarketing" },
                    { 302, "socialmedia" },
                    { 301, "lifestyleblogger" },
                    { 203, "travelphotography" },
                    { 102, "fitness" },
                    { 201, "photooftheday" },
                    { 103, "adventure" },
                    { 402, "moviebuff" },
                    { 101, "mountainbiking" },
                    { 202, "naturephotography" },
                    { 403, "filmmaking" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
