using CasalAvis.Estructures;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CasalAvis.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BotigaTaula> botigaTaula { get; set; }
        public DbSet<BotiguesMapa> botigaMapa { get; set; }
    }
}