using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreTutorial.Migrations
{
    /// <inheritdoc />
    public partial class seed_classroom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Classroom",
                columns: new[] { "Id", "Name", "Room", "Teacher" },
                values: new object[,]
                {
                    { 1L, "CNTTK44H", "Lab1", "Hùng Dung" },
                    { 2L, "CNTTK44B", "Lab3", "Hùng Dung2" },
                    { 3L, "CNTTK44A", "Lab2", "Hùng Dung3" },
                    { 4L, "CNTTK44L", "Lab7", "Hùng Dung7" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classroom",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Classroom",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Classroom",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Classroom",
                keyColumn: "Id",
                keyValue: 4L);
        }
    }
}
