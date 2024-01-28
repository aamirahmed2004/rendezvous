using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class seedActivities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "id", "Age_rating", "Description", "Location", "Name", "Time_end", "Time_start", "isPrivate" },
                values: new object[] { 1, "18+", "Football is a family of team sports that involve, to varying degrees, kicking a ball to score a goal.", null, "Football", new DateTime(2024, 1, 28, 21, 50, 49, 408, DateTimeKind.Local).AddTicks(9424), new DateTime(2024, 1, 27, 21, 50, 49, 408, DateTimeKind.Local).AddTicks(9378), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
