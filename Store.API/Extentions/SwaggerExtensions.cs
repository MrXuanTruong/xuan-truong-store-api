using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.API.Extentions
{
    public static class SwaggerExtensions
    {
        public static void AddSwaggerExtensions(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Travel API",
                        Version = "v1",
                        Description = "Travel Api Documents",
                    });

                c.IgnoreObsoleteActions();
                c.CustomSchemaIds(type => type.FullName);

                /* Add Authorization token Bearer */
                var bearerAuthenticatescheme = new OpenApiSecurityScheme
                {
                    Description = "Authorization. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT"
                };
                c.AddSecurityDefinition("Bearer", bearerAuthenticatescheme);

                c.AddSecurityRequirement(
                    new OpenApiSecurityRequirement
                    {
                        {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
                            },
                            new List<string>()
                        }

                    });

            });
        }

        public static void UseSwaggerExtensions(this IApplicationBuilder app)
        {
            app.UseSwagger(c =>
            {
                c.RouteTemplate = "api-docs/{documentName}/swagger.json";
            });

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/api-docs/v1/swagger.json", "API Version 1.0");
                c.RoutePrefix = "";
                c.InjectStylesheet("/css/swagger-css.css");
            });
        }
    }
}
