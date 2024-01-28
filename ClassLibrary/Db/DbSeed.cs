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

        public static List<User> SeedUsers(ModelBuilder modelBuilder)
        {
            List<User> users = new List<User>()
            {
                new User()
                {
                    id = 1,
                    Name = "John Doe",
                    Nickname = "JD",
                    Password = "password",
                    Email = "jd@gmail.com"
                },
                new User()
                {
                    id = 2,
                    Name = "Jane Doe",
                    Nickname = "Jane",
                    Password = "password",
                    Email = "jane@gmai.com"
                }
            };
            modelBuilder.Entity<User>().HasData(users);
            return users;
        }

        public static void SeedProfile(ModelBuilder modelBuilder, List<User> users, List<InterestTag> tags)
        {
            int i = 1;
            foreach(User user in users)
            {
                Profile profile = new Profile()
                {
                    id = i++,
                    UserId = user.id,
                    Name = "Football",
                    Pronouns = "He/Him",
                    AboutMe = "I am a student at the University of Utah",
                    LookingFor = "I am looking for a group of people to play football with",
                    Links = "https://www.facebook.com/ https://www.instagram.com/"
                };
                Profile profile2 = new Profile()
                {
                    id = i++,
                    UserId = user.id,
                    Name = "Basketball",
                    Pronouns = "He/Him",
                    AboutMe = "I am a student at the University of Utah",
                    LookingFor = "I am looking for a group of people to play basketball with",
                    Links = "https://www.facebook.com/ https://www.instagram.com/"
                };
                modelBuilder.Entity<Profile>().HasData(profile);
                modelBuilder.Entity<Profile>().HasData(profile2);
            }
            
        }

        public static List<InterestTag> SeedTags(ModelBuilder modelBuilder)
        {
            List<InterestTag> tags = new List<InterestTag>() {
                new InterestTag()
                {
                    id = 1,
                    Tag = "Football"
                },
                new InterestTag()
                {
                    id = 2,
                    Tag = "Basketball"
                },
                new InterestTag()
                {
                    id = 3,
                    Tag = "Soccer"
                },
                new InterestTag()
                {
                    id = 4,
                    Tag = "Hiking"
                },
                new InterestTag()
                {
                    id = 5,
                    Tag = "Running"
                }
            };
            modelBuilder.Entity<InterestTag>().HasData(tags);
            return tags;
        }
    }
}
