using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Store.Services.Extentions
{
    public static class ConventionServiceExtentions
    {
        public static IServiceCollection AddScopedByConvention(this IServiceCollection services, Assembly assembly, Func<Type, bool> interfacePredicate, Func<Type, bool> implementationPredicate)
        {
            var interfaces = assembly.ExportedTypes
                .Where(x => x.IsInterface && interfacePredicate(x))
                .ToList();
            var implementations = assembly.ExportedTypes
                .Where(x => !x.IsInterface && !x.IsAbstract && implementationPredicate(x))
                .ToList();
            foreach (var @interface in interfaces)
            {
                var implementation = implementations.FirstOrDefault(x => @interface.IsAssignableFrom(x));
                if (implementation == null) continue;
                services.AddScoped(@interface, implementation);
            }
            return services;
        }

        public static IServiceCollection AddScopedByConvention(this IServiceCollection services, Assembly assembly, Func<Type, bool> predicate)
            => services.AddScopedByConvention(assembly, predicate, predicate);

        public static IServiceCollection AddSingletonsByConvention(this IServiceCollection services, Assembly assembly, Func<Type, bool> interfacePredicate, Func<Type, bool> implementationPredicate)
        {
            var interfaces = assembly.ExportedTypes
                .Where(x => x.IsInterface && interfacePredicate(x))
                .ToList();
            var implementations = assembly.ExportedTypes
                .Where(x => !x.IsInterface && !x.IsAbstract && implementationPredicate(x))
                .ToList();
            foreach (var @interface in interfaces)
            {
                var implementation = implementations.FirstOrDefault(x => @interface.IsAssignableFrom(x));
                if (implementation == null) continue;
                services.AddSingleton(@interface, implementation);
            }
            return services;
        }

        public static IServiceCollection AddSingletonsByConvention(this IServiceCollection services, Assembly assembly, Func<Type, bool> predicate)
            => services.AddSingletonsByConvention(assembly, predicate, predicate);

        public static IServiceCollection AddScopedByConventionNoInterface(this IServiceCollection services, Assembly assembly, Func<Type, bool> predicate)
        {
            var implementations = assembly.ExportedTypes
                .Where(x => !x.IsInterface && !x.IsAbstract && predicate(x))
                .ToList();
            foreach (var implementation in implementations)
            {
                services.AddScoped(implementation, implementation);
            }
            return services;
        }

    }
}
