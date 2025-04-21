using Microsoft.EntityFrameworkCore;
using ApplicationTrackerAPI.Models;

namespace ApplicationTrackerAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Application> Applications { get; set; }
    }
}