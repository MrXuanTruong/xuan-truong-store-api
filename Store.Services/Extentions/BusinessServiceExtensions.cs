using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Services.Extentions
{
    public static class BusinessServiceExtensions
    {
        public static void AddDependencyInjectionForService(this IServiceCollection services)
        {
            // Register services
            var assembly = typeof(BusinessServiceExtensions).Assembly;
            services.AddScopedByConvention(assembly, x => x.Name.EndsWith("Service") && !x.Name.EndsWith("BaseService"));
        }
    }
}
