using System;
using System.Collections.Generic;
using System.Linq;
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
            string connectionString = "Server=notmobmeet-do-user-15708106-0.c.db.ondigitalocean.com;Port=25060;Database=defaultdb;User=doadmin;Password=AVNS_JlAi-afUsHwEZR07HVe;SslMode=Required;";
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
        }

    }
}
