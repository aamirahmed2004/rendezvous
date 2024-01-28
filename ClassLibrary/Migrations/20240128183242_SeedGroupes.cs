using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class SeedGroupes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 32, 41, 655, DateTimeKind.Local).AddTicks(2475), new DateTime(2024, 1, 28, 10, 32, 41, 655, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 28, 13, 32, 41, 655, DateTimeKind.Local).AddTicks(2492), new DateTime(2024, 1, 28, 11, 32, 41, 655, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 29, 14, 32, 41, 655, DateTimeKind.Local).AddTicks(2499), new DateTime(2024, 1, 29, 10, 32, 41, 655, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 30, 12, 32, 41, 655, DateTimeKind.Local).AddTicks(2507), new DateTime(2024, 1, 30, 10, 32, 41, 655, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 28, 13, 32, 41, 655, DateTimeKind.Local).AddTicks(2513), new DateTime(2024, 1, 28, 12, 32, 41, 655, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 31, 15, 32, 41, 655, DateTimeKind.Local).AddTicks(2521), new DateTime(2024, 1, 31, 10, 32, 41, 655, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 2, 2, 10, 32, 41, 655, DateTimeKind.Local).AddTicks(2527), new DateTime(2024, 2, 1, 10, 32, 41, 655, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 29, 16, 32, 41, 655, DateTimeKind.Local).AddTicks(2533), new DateTime(2024, 1, 29, 12, 32, 41, 655, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 30, 13, 32, 41, 655, DateTimeKind.Local).AddTicks(2539), new DateTime(2024, 1, 30, 11, 32, 41, 655, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 2, 3, 18, 32, 41, 655, DateTimeKind.Local).AddTicks(2546), new DateTime(2024, 2, 3, 10, 32, 41, 655, DateTimeKind.Local).AddTicks(2544) });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "id", "About", "ActivityId", "Name", "ReqNumUsers" },
                values: new object[,]
                {
                    { 1, "We are a group1", 1, "Group1", 10 },
                    { 2, "We are a group2", 1, "Group2", 10 },
                    { 3, "We are a group3", 2, "Group3", 10 },
                    { 4, "We are a group4", 2, "Group4", 10 },
                    { 5, "We are a group5", 3, "Group5", 10 },
                    { 6, "We are a group6", 3, "Group6", 10 },
                    { 7, "We are a group7", 4, "Group7", 10 },
                    { 8, "We are a group8", 4, "Group8", 10 },
                    { 9, "We are a group9", 5, "Group9", 10 },
                    { 10, "We are a group10", 5, "Group10", 10 },
                    { 11, "We are a group11", 6, "Group11", 10 },
                    { 12, "We are a group12", 6, "Group12", 10 },
                    { 13, "We are a group13", 7, "Group13", 10 },
                    { 14, "We are a group14", 7, "Group14", 10 },
                    { 15, "We are a group15", 8, "Group15", 10 },
                    { 16, "We are a group16", 8, "Group16", 10 },
                    { 17, "We are a group17", 9, "Group17", 10 },
                    { 18, "We are a group18", 9, "Group18", 10 },
                    { 19, "We are a group19", 10, "Group19", 10 },
                    { 20, "We are a group20", 10, "Group20", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 28, 10, 14, 55, 781, DateTimeKind.Local).AddTicks(6233), new DateTime(2024, 1, 28, 8, 14, 55, 781, DateTimeKind.Local).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 28, 11, 14, 55, 781, DateTimeKind.Local).AddTicks(6252), new DateTime(2024, 1, 28, 9, 14, 55, 781, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 29, 12, 14, 55, 781, DateTimeKind.Local).AddTicks(6260), new DateTime(2024, 1, 29, 8, 14, 55, 781, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 30, 10, 14, 55, 781, DateTimeKind.Local).AddTicks(6266), new DateTime(2024, 1, 30, 8, 14, 55, 781, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 28, 11, 14, 55, 781, DateTimeKind.Local).AddTicks(6271), new DateTime(2024, 1, 28, 10, 14, 55, 781, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 31, 13, 14, 55, 781, DateTimeKind.Local).AddTicks(6279), new DateTime(2024, 1, 31, 8, 14, 55, 781, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 2, 2, 8, 14, 55, 781, DateTimeKind.Local).AddTicks(6286), new DateTime(2024, 2, 1, 8, 14, 55, 781, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 29, 14, 14, 55, 781, DateTimeKind.Local).AddTicks(6292), new DateTime(2024, 1, 29, 10, 14, 55, 781, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 30, 11, 14, 55, 781, DateTimeKind.Local).AddTicks(6298), new DateTime(2024, 1, 30, 9, 14, 55, 781, DateTimeKind.Local).AddTicks(6296) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 2, 3, 16, 14, 55, 781, DateTimeKind.Local).AddTicks(6306), new DateTime(2024, 2, 3, 8, 14, 55, 781, DateTimeKind.Local).AddTicks(6304) });
        }
    }
}
