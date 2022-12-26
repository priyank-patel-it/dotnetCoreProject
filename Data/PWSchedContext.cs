using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PWSched_dotnet_mvc.Models;

namespace PWSched_dotnet_mvc.Data
{
    public class PWSchedContext : IdentityDbContext<IdentityUser>
    {
        public PWSchedContext(DbContextOptions<PWSchedContext> options)
            : base(options)
        {
        }

        public DbSet<Shift> Shift { get; set; }
    }
}