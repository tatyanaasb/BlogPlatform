using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class CommentedOutCategoryAndTagIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "PublishDate", "TagId" },
                values: new object[] { 0, new DateTime(2020, 3, 2, 9, 7, 4, 265, DateTimeKind.Local).AddTicks(3362), 0 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "PublishDate", "TagId" },
                values: new object[] { 0, new DateTime(2020, 3, 2, 9, 7, 4, 268, DateTimeKind.Local).AddTicks(3846), 0 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "PublishDate", "TagId" },
                values: new object[] { 0, new DateTime(2020, 3, 2, 9, 7, 4, 268, DateTimeKind.Local).AddTicks(3911), 0 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "PublishDate", "TagId" },
                values: new object[] { 0, new DateTime(2020, 3, 2, 9, 7, 4, 268, DateTimeKind.Local).AddTicks(3918), 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "PublishDate", "TagId" },
                values: new object[] { 1, new DateTime(2020, 3, 2, 9, 1, 58, 754, DateTimeKind.Local).AddTicks(6563), 101 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "PublishDate", "TagId" },
                values: new object[] { 2, new DateTime(2020, 3, 2, 9, 1, 58, 758, DateTimeKind.Local).AddTicks(560), 201 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "PublishDate", "TagId" },
                values: new object[] { 3, new DateTime(2020, 3, 2, 9, 1, 58, 758, DateTimeKind.Local).AddTicks(622), 301 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "PublishDate", "TagId" },
                values: new object[] { 4, new DateTime(2020, 3, 2, 9, 1, 58, 758, DateTimeKind.Local).AddTicks(629), 401 });
        }
    }
}
