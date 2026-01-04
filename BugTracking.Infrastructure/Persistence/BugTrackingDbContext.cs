using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using BugTracking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using BugTracking.Infrastructure.Identity;
namespace BugTracking.Infrastructure.Persistence
{
    public class BugTrackingDbContext: IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        //for dependency injection
        public BugTrackingDbContext(DbContextOptions<BugTrackingDbContext> options)
            : base(options)
        {
        }
        //representing table for bugs
        public DbSet<Bug> Bugs => Set<Bug>();

        protected override void OnModelCreating(ModelBuilder builder)
        {


            base.OnModelCreating(builder);

            // Identity schema
            builder.Entity<ApplicationUser>().ToTable("Users", "identity");
            builder.Entity<IdentityRole>().ToTable("Roles", "identity");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "identity");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "identity");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "identity");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "identity");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "identity");

            //Fluent API config
            builder.Entity<Bug>(entity =>
            {
                entity.ToTable("Bugs", "dbo");

                entity.HasKey(b => b.Id);

                entity.Property(b => b.Title).IsRequired().HasMaxLength(200);

                entity.Property(b => b.Description).IsRequired();

                //entity.Property(b => b.Severity).IsRequired();

                //entity.Property(b => b.Status).IsRequired();
            });

            //configure schema
            //builder.HasDefaultSchema("identity");
        }
    }

    


}
