using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PublishDate", "TagId" },
                values: new object[] { new DateTime(2020, 3, 2, 9, 1, 58, 754, DateTimeKind.Local).AddTicks(6563), 101 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PublishDate", "TagId" },
                values: new object[] { new DateTime(2020, 3, 2, 9, 1, 58, 758, DateTimeKind.Local).AddTicks(560), 201 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PublishDate", "TagId" },
                values: new object[] { new DateTime(2020, 3, 2, 9, 1, 58, 758, DateTimeKind.Local).AddTicks(622), 301 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PublishDate", "TagId" },
                values: new object[] { new DateTime(2020, 3, 2, 9, 1, 58, 758, DateTimeKind.Local).AddTicks(629), 401 });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TagId",
                table: "Posts",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_TagId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 3, 1, 20, 18, 8, 13, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2020, 3, 1, 20, 18, 8, 16, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2020, 3, 1, 20, 18, 8, 16, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2020, 3, 1, 20, 18, 8, 16, DateTimeKind.Local).AddTicks(5217));
        }
    }
}
