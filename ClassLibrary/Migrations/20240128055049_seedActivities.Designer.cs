﻿// <auto-generated />
using System;
using ClassLibrary.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassLibrary.Migrations
{
    [DbContext(typeof(TeamDbContext))]
    [Migration("20240128055049_seedActivities")]
    partial class seedActivities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ActivityProfile", b =>
                {
                    b.Property<int>("Activitiesid")
                        .HasColumnType("int");

                    b.Property<int>("Profilesid")
                        .HasColumnType("int");

                    b.HasKey("Activitiesid", "Profilesid");

                    b.HasIndex("Profilesid");

                    b.ToTable("ActivityProfile");
                });

            modelBuilder.Entity("ClassLibrary.Db.Activity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Age_rating")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Time_end")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Time_start")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("isPrivate")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("id");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Age_rating = "18+",
                            Description = "Football is a family of team sports that involve, to varying degrees, kicking a ball to score a goal.",
                            Name = "Football",
                            Time_end = new DateTime(2024, 1, 28, 21, 50, 49, 408, DateTimeKind.Local).AddTicks(9424),
                            Time_start = new DateTime(2024, 1, 27, 21, 50, 49, 408, DateTimeKind.Local).AddTicks(9378),
                            isPrivate = false
                        });
                });

            modelBuilder.Entity("ClassLibrary.Db.Group", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ReqNumUsers")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("ActivityId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("ClassLibrary.Db.Image", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<byte[]>("Img")
                        .IsRequired()
                        .HasColumnType("blob");

                    b.Property<int?>("Profileid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Profileid");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("ClassLibrary.Db.InterestTag", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Profileid")
                        .HasColumnType("int");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("Profileid");

                    b.ToTable("InterestTags");
                });

            modelBuilder.Entity("ClassLibrary.Db.Profile", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AboutMe")
                        .HasColumnType("longtext");

                    b.Property<string>("Links")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LookingFor")
                        .HasColumnType("longtext");

                    b.Property<string>("Pronouns")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("UserId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("ClassLibrary.Db.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("BDate")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("Groupid")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nickname")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("Groupid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GroupProfile", b =>
                {
                    b.Property<int>("Groupsid")
                        .HasColumnType("int");

                    b.Property<int>("Profilesid")
                        .HasColumnType("int");

                    b.HasKey("Groupsid", "Profilesid");

                    b.HasIndex("Profilesid");

                    b.ToTable("GroupProfile");
                });

            modelBuilder.Entity("ActivityProfile", b =>
                {
                    b.HasOne("ClassLibrary.Db.Activity", null)
                        .WithMany()
                        .HasForeignKey("Activitiesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibrary.Db.Profile", null)
                        .WithMany()
                        .HasForeignKey("Profilesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibrary.Db.Group", b =>
                {
                    b.HasOne("ClassLibrary.Db.Activity", "Activity")
                        .WithMany("Groups")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("ClassLibrary.Db.Image", b =>
                {
                    b.HasOne("ClassLibrary.Db.Profile", null)
                        .WithMany("Images")
                        .HasForeignKey("Profileid");
                });

            modelBuilder.Entity("ClassLibrary.Db.InterestTag", b =>
                {
                    b.HasOne("ClassLibrary.Db.Profile", null)
                        .WithMany("InterestTags")
                        .HasForeignKey("Profileid");
                });

            modelBuilder.Entity("ClassLibrary.Db.Profile", b =>
                {
                    b.HasOne("ClassLibrary.Db.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ClassLibrary.Db.User", b =>
                {
                    b.HasOne("ClassLibrary.Db.Group", null)
                        .WithMany("Users")
                        .HasForeignKey("Groupid");
                });

            modelBuilder.Entity("GroupProfile", b =>
                {
                    b.HasOne("ClassLibrary.Db.Group", null)
                        .WithMany()
                        .HasForeignKey("Groupsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibrary.Db.Profile", null)
                        .WithMany()
                        .HasForeignKey("Profilesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibrary.Db.Activity", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("ClassLibrary.Db.Group", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ClassLibrary.Db.Profile", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("InterestTags");
                });
#pragma warning restore 612, 618
        }
    }
}
