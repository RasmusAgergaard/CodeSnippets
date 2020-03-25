using CustomUser.Areas.Identity.Data;
using CustomUser.Core;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CustomUser.Data
{
    public class CustomUserContext : IdentityDbContext<ApplicationUser>
    {
        public CustomUserContext(DbContextOptions<CustomUserContext> options) : base(options)
        {

        }

        //Types that should be created in the database
        public DbSet<Project> Projects { get; set; }
        public DbSet<ApplicationUserProjects> ApplicationUserProjects { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUserProjects>().HasKey(t => new { t.Id, t.ProjectId });

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
