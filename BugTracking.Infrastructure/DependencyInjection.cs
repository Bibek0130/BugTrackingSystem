using BugTracking.Application.Interfaces.Repositories;
using BugTracking.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using BugTracking.Infrastructure.Persistence;
using BugTracking.Infrastructure.Identity;

namespace BugTracking.Infrastructure
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Database
            services.AddDbContext<BugTrackingDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("Default")));

            // Identity
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 6;
                options.User.RequireUniqueEmail = true;
            })
                .AddEntityFrameworkStores<BugTrackingDbContext>()
                .AddDefaultTokenProviders();
                //.AddRoles<IdentityRole>(); //adding identity roles
                ///.AddApiEndpoints();


            // Repositories
            services.AddScoped<IBugRepository, BugRepository>();
            services.AddScoped<IAuthRepository, AuthRepository>();

            return services;
        }
    }
}
