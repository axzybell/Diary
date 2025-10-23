using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "DateCreated", "Title" },
                values: new object[,]
                {
                    { 1, "When Hiking with Joe!", new DateTime(2025, 10, 23, 14, 49, 50, 0, DateTimeKind.Unspecified), "Went Hiking" },
                    { 2, "When Shopping with Joe!", new DateTime(2025, 10, 23, 14, 49, 50, 0, DateTimeKind.Unspecified), "Went Shopping" },
                    { 3, "When Diving with Joe!", new DateTime(2025, 10, 23, 14, 49, 50, 0, DateTimeKind.Unspecified), "Went Diving" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
