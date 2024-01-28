using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class user_profile_tag_seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 29, 2, 43, 54, 374, DateTimeKind.Local).AddTicks(2062), new DateTime(2024, 1, 28, 2, 43, 54, 374, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.InsertData(
                table: "InterestTags",
                columns: new[] { "id", "Profileid", "Tag" },
                values: new object[,]
                {
                    { 1, null, "Football" },
                    { 2, null, "Basketball" },
                    { 3, null, "Soccer" },
                    { 4, null, "Hiking" },
                    { 5, null, "Running" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "BDate", "Email", "Groupid", "Location", "Name", "Nickname", "Password" },
                values: new object[,]
                {
                    { 1, new DateOnly(1, 1, 1), "jd@gmail.com", null, null, "John Doe", "JD", "password" },
                    { 2, new DateOnly(1, 1, 1), "jane@gmai.com", null, null, "Jane Doe", "Jane", "password" }
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "id", "AboutMe", "Links", "LookingFor", "Pronouns", "UserId" },
                values: new object[,]
                {
                    { 1, "I am a student at the University of Utah", "https://www.facebook.com/ https://www.instagram.com/", "I am looking for a group of people to play football with", "He/Him", 1 },
                    { 2, "I am a student at the University of Utah", "https://www.facebook.com/ https://www.instagram.com/", "I am looking for a group of people to play football with", "He/Him", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InterestTags",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InterestTags",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InterestTags",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InterestTags",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InterestTags",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Time_end", "Time_start" },
                values: new object[] { new DateTime(2024, 1, 28, 21, 50, 49, 408, DateTimeKind.Local).AddTicks(9424), new DateTime(2024, 1, 27, 21, 50, 49, 408, DateTimeKind.Local).AddTicks(9378) });
        }
    }
}
