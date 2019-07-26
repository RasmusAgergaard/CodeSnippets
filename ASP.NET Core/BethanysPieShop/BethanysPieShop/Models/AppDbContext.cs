using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    //The "trafic agent" that moves code between the code and the db
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //Types that should be created in the database
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
