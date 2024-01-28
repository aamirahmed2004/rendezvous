﻿// <auto-generated />
using System;
using ClassLibrary.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassLibrary.Migrations
{
    [DbContext(typeof(TeamDbContext))]
    partial class TeamDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ClassLibrary.TeamDbContext.Activity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Age_rating")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Time_end")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Time_start")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("isPrivate")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("id");

                    b.ToTable("Activities", (string)null);
                });

            modelBuilder.Entity("ClassLibrary.TeamDbContext.Group", b =>
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

                    b.HasKey("id");

                    b.HasIndex("ActivityId");

                    b.ToTable("Groups", (string)null);
                });

            modelBuilder.Entity("ClassLibrary.TeamDbContext.InterestTag", b =>
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

                    b.ToTable("InterestTags", (string)null);
                });

            modelBuilder.Entity("ClassLibrary.TeamDbContext.Profile", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AboutMe")
                        .HasColumnType("longtext");

                    b.Property<string>("LookingFor")
                        .HasColumnType("longtext");

                    b.Property<string>("Pronouns")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("UserId");

                    b.ToTable("Profiles", (string)null);
                });

            modelBuilder.Entity("ClassLibrary.TeamDbContext.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Groupid")
                        .HasColumnType("int");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("location")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nickname")
                        .HasColumnType("longtext");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("Groupid");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("ClassLibrary.TeamDbContext.Group", b =>
                {
                    b.HasOne("ClassLibrary.TeamDbContext.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("ClassLibrary.TeamDbContext.InterestTag", b =>
                {
                    b.HasOne("ClassLibrary.TeamDbContext.Profile", null)
                        .WithMany("InterestTags")
                        .HasForeignKey("Profileid");
                });

            modelBuilder.Entity("ClassLibrary.TeamDbContext.Profile", b =>
                {
                    b.HasOne("ClassLibrary.TeamDbContext.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ClassLibrary.TeamDbContext.User", b =>
                {
                    b.HasOne("ClassLibrary.TeamDbContext.Group", null)
                        .WithMany("Users")
                        .HasForeignKey("Groupid");
                });

            modelBuilder.Entity("ClassLibrary.TeamDbContext.Group", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ClassLibrary.TeamDbContext.Profile", b =>
                {
                    b.Navigation("InterestTags");
                });
#pragma warning restore 612, 618
        }
    }
}
