using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Db
{
    public class DbSeed
    {
        public static void SeedActivities(ModelBuilder modelBuilder)
        {
            Activity activity = new Activity()
            {
                id=1,
                Name = "Football",
                isPrivate = false,
                Time_start = DateTime.Now,
                Time_end = DateTime.Now.AddDays(1),
                Age_rating = "18+",
                Description = "Football is a family of team sports that involve, to varying degrees, kicking a ball to score a goal.",
                Profiles = new List<Profile>(),
                Groups = new List<Group>(),
            };
            modelBuilder.Entity<Activity>().HasData(activity);
            
        }
    }
}
