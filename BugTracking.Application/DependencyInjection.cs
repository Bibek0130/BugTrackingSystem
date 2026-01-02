using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BugTracking.Application.Interfaces.Services;
using BugTracking.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BugTracking.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IBugService, BugService>();
            services.AddScoped<IAuthService, AuthService>();

            //Validations
            //services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);

            return services;
        }

    }
}
