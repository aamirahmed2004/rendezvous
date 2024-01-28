using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class BDate_to_DateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Profiles_Profileid",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_Profileid",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "Profileid",
                table: "Image");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 29, 2, 57, 40, 92, DateTimeKind.Local).AddTicks(8531), new DateTime(2024, 1, 28, 2, 57, 40, 92, DateTimeKind.Local).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                column: "BDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2,
                column: "BDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "BDate",
                table: "Users",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddColumn<int>(
                name: "Profileid",
                table: "Image",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 29, 2, 43, 54, 374, DateTimeKind.Local).AddTicks(2062), new DateTime(2024, 1, 28, 2, 43, 54, 374, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                column: "BDate",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2,
                column: "BDate",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.CreateIndex(
                name: "IX_Image_Profileid",
                table: "Image",
                column: "Profileid");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Profiles_Profileid",
                table: "Image",
                column: "Profileid",
                principalTable: "Profiles",
                principalColumn: "id");
        }
    }
}
