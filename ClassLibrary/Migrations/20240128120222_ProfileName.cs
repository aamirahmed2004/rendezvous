using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class ProfileName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Profiles",
                type: "longtext",
                nullable: false);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 29, 4, 2, 21, 788, DateTimeKind.Local).AddTicks(1877), new DateTime(2024, 1, 28, 4, 2, 21, 788, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "id",
                keyValue: 1,
                column: "Name",
                value: "Football");

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "id",
                keyValue: 2,
                column: "Name",
                value: "Football");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Profiles");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 29, 2, 57, 40, 92, DateTimeKind.Local).AddTicks(8531), new DateTime(2024, 1, 28, 2, 57, 40, 92, DateTimeKind.Local).AddTicks(8482) });
        }
    }
}
