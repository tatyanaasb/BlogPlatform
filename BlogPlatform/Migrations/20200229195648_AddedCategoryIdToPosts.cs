using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class AddedCategoryIdToPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "PublishDate" },
                values: new object[] { 1, new DateTime(2020, 2, 29, 14, 56, 47, 596, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "PublishDate" },
                values: new object[] { 2, new DateTime(2020, 2, 29, 14, 56, 47, 600, DateTimeKind.Local).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "PublishDate" },
                values: new object[] { 3, new DateTime(2020, 2, 29, 14, 56, 47, 600, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "PublishDate" },
                values: new object[] { 4, new DateTime(2020, 2, 29, 14, 56, 47, 600, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_CategoryId",
                table: "Posts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_CategoryId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 2, 28, 17, 29, 26, 600, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2020, 2, 28, 17, 29, 26, 603, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2020, 2, 28, 17, 29, 26, 603, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2020, 2, 28, 17, 29, 26, 603, DateTimeKind.Local).AddTicks(5420));
        }
    }
}
