using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Db
{
    public class DbSeed
    {
        public static List<Activity> SeedActivities(ModelBuilder modelBuilder)
        {
            List<Activity> activitiesList = new List<Activity>
            {
                new Activity()
                {
                    id = 1,
                    Name = "Football Match",
                    isPrivate = false,
                    Time_start = DateTime.Now,
                    Time_end = DateTime.Now.AddHours(2),
                    Age_rating = "All Ages",
                    Description = "A fun and competitive football match.",
                    Profiles = new List<Profile>(),
                    Groups = new List<Group>(),
                },
                new Activity()
                {
                    id = 2,
                    Name = "Basketball Training",
                    isPrivate = true,
                    Time_start = DateTime.Now.AddHours(1),
                    Time_end = DateTime.Now.AddHours(3),
                    Age_rating = "12+",
                    Description = "Training session for local basketball team.",
                    Profiles = new List<Profile>(),
                    Groups = new List<Group>(),
                },
                new Activity()
                {
                    id = 3,
                    Name = "Chess Tournament",
                    isPrivate = false,
                    Time_start = DateTime.Now.AddDays(1),
                    Time_end = DateTime.Now.AddDays(1).AddHours(4),
                    Age_rating = "All Ages",
                    Description = "Regional chess tournament open for all.",
                    Profiles = new List<Profile>(),
                    Groups = new List<Group>(),
                },
                new Activity()
                {
                    id = 4,
                    Name = "Book Club",
                    isPrivate = false,
                    Time_start = DateTime.Now.AddDays(2),
                    Time_end = DateTime.Now.AddDays(2).AddHours(2),
                    Age_rating = "18+",
                    Description = "Discussing the latest in literary wonders.",
                    Profiles = new List<Profile>(),
                    Groups = new List<Group>(),
                },
                new Activity()
                {
                    id = 5,
                    Name = "Yoga Class",
                    isPrivate = true,
                    Time_start = DateTime.Now.AddHours(2),
                    Time_end = DateTime.Now.AddHours(3),
                    Age_rating = "16+",
                    Description = "A relaxing yoga session to improve your flexibility.",
                    Profiles = new List<Profile>(),
                    Groups = new List<Group>(),
                },
                new Activity()
                {
                    id = 6,
                    Name = "Cooking Workshop",
                    isPrivate = false,
                    Time_start = DateTime.Now.AddDays(3),
                    Time_end = DateTime.Now.AddDays(3).AddHours(5),
                    Age_rating = "All Ages",
                    Description = "Learn to cook Italian cuisine with expert chefs.",
                    Profiles = new List<Profile>(),
                    Groups = new List<Group>(),
                },
                new Activity()
                {
                    id = 7,
                    Name = "Coding Hackathon",
                    isPrivate = false,
                    Time_start = DateTime.Now.AddDays(4),
                    Time_end = DateTime.Now.AddDays(5),
                    Age_rating = "18+",
                    Description = "Collaborative event to solve programming challenges.",
                    Profiles = new List<Profile>(),
                    Groups = new List<Group>(),
                },
                new Activity()
                {
                    id = 8,
                    Name = "Rock Climbing Adventure",
                    isPrivate = true,
                    Time_start = DateTime.Now.AddDays(1).AddHours(2),
                    Time_end = DateTime.Now.AddDays(1).AddHours(6),
                    Age_rating = "12+",
                    Description = "Experience the thrill of rock climbing with trained instructors.",
                    Profiles = new List<Profile>(),
                    Groups = new List<Group>(),
                },
                new Activity()
                {
                    id = 9,
                    Name = "Guitar Lessons",
                    isPrivate = true,
                    Time_start = DateTime.Now.AddDays(2).AddHours(1),
                    Time_end = DateTime.Now.AddDays(2).AddHours(3),
                    Age_rating = "All Ages",
                    Description = "Beginner guitar lessons for aspiring musicians.",
                    Profiles = new List<Profile>(),
                    Groups = new List<Group>(),
                },
                new Activity()
                {
                    id = 10,
                    Name = "Art Exhibition",
                    isPrivate = false,
                    Time_start = DateTime.Now.AddDays(6),
                    Time_end = DateTime.Now.AddDays(6).AddHours(8),
                    Age_rating = "All Ages",
                    Description = "Showcasing contemporary art from local artists.",
                    Profiles = new List<Profile>(),
                    Groups = new List<Group>(),
                }
            };

            modelBuilder.Entity<Activity>().HasData(activitiesList);
			return activitiesList;
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
                    Email = "jd@gmail.com",
                    BDate = new DateTime(1999, 1, 1)
                },
                new User()
                {
                    id = 2,
                    Name = "Jane Doe",
                    Nickname = "Jane",
                    Password = "password",
                    Email = "jane@gmai.com",
                    BDate = new DateTime(2003, 1, 1)
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
                    Image = new byte[50],
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

        public static void SeedGroups(ModelBuilder modelBuilder, List<Activity> activities)
        {
			int i = 1;
			foreach(Activity activity in activities)
            {
				Group group = new Group()
                {
					id = i,
					ActivityId = activity.id,
					Name = "Group" + i,
					About = "We are a group" + i++,
					ReqNumUsers = 10
				};
				Group group2 = new Group()
                {
					id = i,
					ActivityId = activity.id,
					Name = "Group" + i,
					About = "We are a group" + i++,
					ReqNumUsers = 10
				};
				modelBuilder.Entity<Group>().HasData(group);
				modelBuilder.Entity<Group>().HasData(group2);
			}   
        }
    }
}
