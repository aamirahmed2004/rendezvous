using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Db
{
    public class TeamDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<InterestTag> InterestTags { get; set; }
        public DbSet<Activity> Activities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;Port=3306;Database=db;User=root;Password=changethis!;";
            optionsBuilder.UseMySQL(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>()
                .HasMany(e => e.Profiles)
                .WithMany(e => e.Groups);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.Profiles)
                .WithMany(e => e.Activities);

            modelBuilder.Entity<Image>()
                .Property(x => x.Img)
                .HasColumnType("blob");
            
        }

    }
}
