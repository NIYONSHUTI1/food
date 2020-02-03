using Microsoft.EntityFrameworkCore;

namespace food.Models
{
    public class foodDbContext : DbContext
    {
        public foodDbContext(DbContextOptions<foodDbContext> options) : base(options)
        {
            
        }
        public DbSet<Restaurant> Restaurants { get; set; }

    }
}