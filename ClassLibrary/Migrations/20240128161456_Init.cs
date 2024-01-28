using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    isPrivate = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Location = table.Column<string>(type: "longtext", nullable: true),
                    Time_start = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Time_end = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Age_rating = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    About = table.Column<string>(type: "longtext", nullable: false),
                    ReqNumUsers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.id);
                    table.ForeignKey(
                        name: "FK_Groups_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Nickname = table.Column<string>(type: "longtext", nullable: true),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    Password = table.Column<string>(type: "longtext", nullable: false),
                    BDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Location = table.Column<string>(type: "longtext", nullable: true),
                    Groupid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                    table.ForeignKey(
                        name: "FK_Users_Groups_Groupid",
                        column: x => x.Groupid,
                        principalTable: "Groups",
                        principalColumn: "id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<byte[]>(type: "blob", nullable: true),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Pronouns = table.Column<string>(type: "longtext", nullable: true),
                    AboutMe = table.Column<string>(type: "longtext", nullable: true),
                    LookingFor = table.Column<string>(type: "longtext", nullable: true),
                    Links = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.id);
                    table.ForeignKey(
                        name: "FK_Profiles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ActivityProfile",
                columns: table => new
                {
                    Activitiesid = table.Column<int>(type: "int", nullable: false),
                    Profilesid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityProfile", x => new { x.Activitiesid, x.Profilesid });
                    table.ForeignKey(
                        name: "FK_ActivityProfile_Activities_Activitiesid",
                        column: x => x.Activitiesid,
                        principalTable: "Activities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityProfile_Profiles_Profilesid",
                        column: x => x.Profilesid,
                        principalTable: "Profiles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GroupProfile",
                columns: table => new
                {
                    Groupsid = table.Column<int>(type: "int", nullable: false),
                    Profilesid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupProfile", x => new { x.Groupsid, x.Profilesid });
                    table.ForeignKey(
                        name: "FK_GroupProfile_Groups_Groupsid",
                        column: x => x.Groupsid,
                        principalTable: "Groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupProfile_Profiles_Profilesid",
                        column: x => x.Profilesid,
                        principalTable: "Profiles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "InterestTags",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Tag = table.Column<string>(type: "longtext", nullable: false),
                    Profileid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestTags", x => x.id);
                    table.ForeignKey(
                        name: "FK_InterestTags_Profiles_Profileid",
                        column: x => x.Profileid,
                        principalTable: "Profiles",
                        principalColumn: "id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "id", "Age_rating", "Description", "Location", "Name", "Time_end", "Time_start", "isPrivate" },
                values: new object[,]
                {
                    { 1, "All Ages", "A fun and competitive football match.", null, "Football Match", new DateTime(2024, 1, 28, 10, 14, 55, 781, DateTimeKind.Local).AddTicks(6233), new DateTime(2024, 1, 28, 8, 14, 55, 781, DateTimeKind.Local).AddTicks(6176), false },
                    { 2, "12+", "Training session for local basketball team.", null, "Basketball Training", new DateTime(2024, 1, 28, 11, 14, 55, 781, DateTimeKind.Local).AddTicks(6252), new DateTime(2024, 1, 28, 9, 14, 55, 781, DateTimeKind.Local).AddTicks(6250), true },
                    { 3, "All Ages", "Regional chess tournament open for all.", null, "Chess Tournament", new DateTime(2024, 1, 29, 12, 14, 55, 781, DateTimeKind.Local).AddTicks(6260), new DateTime(2024, 1, 29, 8, 14, 55, 781, DateTimeKind.Local).AddTicks(6257), false },
                    { 4, "18+", "Discussing the latest in literary wonders.", null, "Book Club", new DateTime(2024, 1, 30, 10, 14, 55, 781, DateTimeKind.Local).AddTicks(6266), new DateTime(2024, 1, 30, 8, 14, 55, 781, DateTimeKind.Local).AddTicks(6264), false },
                    { 5, "16+", "A relaxing yoga session to improve your flexibility.", null, "Yoga Class", new DateTime(2024, 1, 28, 11, 14, 55, 781, DateTimeKind.Local).AddTicks(6271), new DateTime(2024, 1, 28, 10, 14, 55, 781, DateTimeKind.Local).AddTicks(6269), true },
                    { 6, "All Ages", "Learn to cook Italian cuisine with expert chefs.", null, "Cooking Workshop", new DateTime(2024, 1, 31, 13, 14, 55, 781, DateTimeKind.Local).AddTicks(6279), new DateTime(2024, 1, 31, 8, 14, 55, 781, DateTimeKind.Local).AddTicks(6278), false },
                    { 7, "18+", "Collaborative event to solve programming challenges.", null, "Coding Hackathon", new DateTime(2024, 2, 2, 8, 14, 55, 781, DateTimeKind.Local).AddTicks(6286), new DateTime(2024, 2, 1, 8, 14, 55, 781, DateTimeKind.Local).AddTicks(6284), false },
                    { 8, "12+", "Experience the thrill of rock climbing with trained instructors.", null, "Rock Climbing Adventure", new DateTime(2024, 1, 29, 14, 14, 55, 781, DateTimeKind.Local).AddTicks(6292), new DateTime(2024, 1, 29, 10, 14, 55, 781, DateTimeKind.Local).AddTicks(6290), true },
                    { 9, "All Ages", "Beginner guitar lessons for aspiring musicians.", null, "Guitar Lessons", new DateTime(2024, 1, 30, 11, 14, 55, 781, DateTimeKind.Local).AddTicks(6298), new DateTime(2024, 1, 30, 9, 14, 55, 781, DateTimeKind.Local).AddTicks(6296), true },
                    { 10, "All Ages", "Showcasing contemporary art from local artists.", null, "Art Exhibition", new DateTime(2024, 2, 3, 16, 14, 55, 781, DateTimeKind.Local).AddTicks(6306), new DateTime(2024, 2, 3, 8, 14, 55, 781, DateTimeKind.Local).AddTicks(6304), false }
                });

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
                    { 1, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jd@gmail.com", null, null, "John Doe", "JD", "password" },
                    { 2, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane@gmai.com", null, null, "Jane Doe", "Jane", "password" }
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "id", "AboutMe", "Image", "Links", "LookingFor", "Name", "Pronouns", "UserId" },
                values: new object[,]
                {
                    { 1, "I am a student at the University of Utah", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "https://www.facebook.com/ https://www.instagram.com/", "I am looking for a group of people to play football with", "Football", "He/Him", 1 },
                    { 2, "I am a student at the University of Utah", null, "https://www.facebook.com/ https://www.instagram.com/", "I am looking for a group of people to play basketball with", "Basketball", "He/Him", 1 },
                    { 3, "I am a student at the University of Utah", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "https://www.facebook.com/ https://www.instagram.com/", "I am looking for a group of people to play football with", "Football", "He/Him", 2 },
                    { 4, "I am a student at the University of Utah", null, "https://www.facebook.com/ https://www.instagram.com/", "I am looking for a group of people to play basketball with", "Basketball", "He/Him", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityProfile_Profilesid",
                table: "ActivityProfile",
                column: "Profilesid");

            migrationBuilder.CreateIndex(
                name: "IX_GroupProfile_Profilesid",
                table: "GroupProfile",
                column: "Profilesid");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_ActivityId",
                table: "Groups",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_InterestTags_Profileid",
                table: "InterestTags",
                column: "Profileid");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_UserId",
                table: "Profiles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Groupid",
                table: "Users",
                column: "Groupid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityProfile");

            migrationBuilder.DropTable(
                name: "GroupProfile");

            migrationBuilder.DropTable(
                name: "InterestTags");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Activities");
        }
    }
}
