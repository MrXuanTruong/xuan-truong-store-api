using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Store.Web.Infrastructure;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using Store.Services.Extentions;
using Store.Entity;

namespace Store.Web.Extentions
{
    public static class ServiceExtensions
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddDependencyInjectionForService();
            services.TryAddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IVueParser, VueParser>();
        }

        public static void AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DatabaseContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                options.UseSqlServer(connectionString);
            });

            services.AddScoped<DatabaseContext>();
        }
    }
}
