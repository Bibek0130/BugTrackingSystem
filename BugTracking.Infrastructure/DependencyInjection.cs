using BugTracking.Application.Interfaces.Repositories;
using BugTracking.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BugTracking.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            // Database
            services.AddDbContext<BugTrackingDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("Default")));

            // Identity
            services.AddIdentityCore<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<BugTrackingDbContext>();

            // Repositories
            services.AddScoped<IBugRepository, BugRepository>();

            return services;
        }
    }
}
