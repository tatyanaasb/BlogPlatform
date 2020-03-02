using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class TagPostCleanup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Posts_Tags_TagId",
            //    table: "Posts");

            //migrationBuilder.DropIndex(
            //    name: "IX_Posts_TagId",
            //    table: "Posts");

            //migrationBuilder.DropColumn(
            //    name: "TagId",
            //    table: "Posts");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "PublishDate" },
                values: new object[] { 1, new DateTime(2020, 3, 2, 12, 18, 32, 783, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "PublishDate" },
                values: new object[] { 2, new DateTime(2020, 3, 2, 12, 18, 32, 789, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "PublishDate" },
                values: new object[] { 3, new DateTime(2020, 3, 2, 12, 18, 32, 789, DateTimeKind.Local).AddTicks(6476) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "PublishDate" },
                values: new object[] { 4, new DateTime(2020, 3, 2, 12, 18, 32, 789, DateTimeKind.Local).AddTicks(6488) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "TagId",
            //    table: "Posts",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "PublishDate" },
                values: new object[] { 0, new DateTime(2020, 3, 2, 9, 7, 4, 265, DateTimeKind.Local).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "PublishDate" },
                values: new object[] { 0, new DateTime(2020, 3, 2, 9, 7, 4, 268, DateTimeKind.Local).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "PublishDate" },
                values: new object[] { 0, new DateTime(2020, 3, 2, 9, 7, 4, 268, DateTimeKind.Local).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "PublishDate" },
                values: new object[] { 0, new DateTime(2020, 3, 2, 9, 7, 4, 268, DateTimeKind.Local).AddTicks(3918) });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Posts_TagId",
            //    table: "Posts",
            //    column: "TagId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Posts_Tags_TagId",
            //    table: "Posts",
            //    column: "TagId",
            //    principalTable: "Tags",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
