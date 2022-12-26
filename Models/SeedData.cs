using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PWSched_dotnet_mvc.Data;
using PWSched_dotnet_mvc.Models;
using System;
using System.Linq;

namespace PWSched_dotnet_mvc.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PWSchedContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PWSchedContext>>()))
            {
                // Look for any movies.
                if (context.Shift.Any())
                {
                    return;   // DB has been seeded
                }

                context.Shift.AddRange(
                    new Shift
                    {
                        Volunteer = "David Van Fleet",
                        ShiftDate = DateTime.Parse("2020-01-09"),
                        Location = "Boston Zone 3",
                        StartTime = DateTime.Parse("08:00:00 AM"),
                        EndTime = DateTime.Parse("01:00:00 PM")
                    },

                    new Shift
                    {
                        Volunteer = "Gina Van Fleet",
                        ShiftDate = DateTime.Parse("2020-01-09"),
                        Location = "Boston Zone 3",
                        StartTime = DateTime.Parse("08:00:00 AM"),
                        EndTime = DateTime.Parse("01:00:00 PM")
                    },

                    new Shift
                    {
                        Volunteer = "David Van Fleet",
                        ShiftDate = DateTime.Parse("2020-01-11"),
                        Location = "UCONN",
                        StartTime = DateTime.Parse("01:30:00 PM"),
                        EndTime = DateTime.Parse("03:00:00 PM")
                    },

                    new Shift
                    {
                        Volunteer = "Gina Van Fleet",
                        ShiftDate = DateTime.Parse("2020-01-11"),
                        Location = "UCONN",
                        StartTime = DateTime.Parse("01:30:00 PM"),
                        EndTime = DateTime.Parse("03:00:00 PM")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}