using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CIDM3312_Final_Project.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FinalContext(
                serviceProvider.GetRequiredService<DbContextOptions<FinalContext>>()))
            {
                // Look for any movies.
                if (context.Client.Any())
                {
                    return;   // DB has been seeded
                }

                context.Client.AddRange(
                     new Client
                     {
                         firstName = "John",
                         lastName = "Doe",
                         organization = "AllOfTheOrganizations",
                         emailAddress = "john@AOTG.com",
                         phoneNumber = "(555) 555-5555"
                     },

                     new Client
                     {
                         firstName = "Joe",
                         lastName = "Johnson",
                         organization = "Probably Most Common Names of America",
                         emailAddress = "joe@average.com",
                         phoneNumber = "(420) 666-6969"
                     },
                );
                context.SaveChanges();
            }

            using (var context = new FinalContext(
                serviceProvider.GetRequiredService<DbContextOptions<FinalContext>>()))
            {
                if (context.Project.Any())
                {
                    return;
                }

                context.Project.AddRange(
                     new Projects
                     {
                         name = "First Project",
                         dateStarted = DateTime.Parse("2018-4-11")
						 dateCompleted = DateTime.Parse("2018-4-12")
                     },

                     new Projects
                     {
                         name = "Another Project",
                         dateStarted = DateTime.Parse("2018-4-2")
					//	 dateCompleted = DateTime.Parse("2018-4-10")

						 
                     },

                );
                context.SaveChanges();
            }

            using (var context = new FinalContext(
                serviceProvider.GetRequiredService<DbContextOptions<FinalContext>>()))
            {
                if (context.Members.Any())
                {
                    return;
                }

                context.Members.AddRange(
                     new Members
                     {
                         firstName = "Scott",
                         lastName = "S",
                         standing = "Amazing",
                         classification = "GOAT",
                         email = "s@buffs.wtamu.edu",
                         phone = "(555) 555-5555",
                         birthday = "May 17"
                     },

                     new Members
                     {
                         firstName = "John",
                         lastName = "Smith",
                         standing = "Great",
                         classification = "Junior",
                         email = "JohnSmith9001@buffs.wtamu.edu",
                         phone = "(555) 555-5555",
                         birthday = "January 1"
                     }


                );
                context.SaveChanges();
            }
        }
    }
}