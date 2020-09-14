using Microsoft.AspNetCore.Builder;
using Store.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.API.Extentions
{
    public static class UnitOfWorkMiddleware
    {
        public static IApplicationBuilder UseUnitOfWorkMiddleware(this IApplicationBuilder app)
        {
            return app.Use(async (context, next) =>
            {
                await next.Invoke();
                // Do logging or other work that doesn't write to the Response.
                DatabaseContext databaseContext = (DatabaseContext)context.RequestServices.GetService(typeof(DatabaseContext));
                //var databaseContext = context.Res;
                var statusCode = context.Response.StatusCode;
                if (statusCode == 500)
                {
                    //session.RollbackAndReleaseSession();
                }
                else
                {
                    await databaseContext.SaveChangesAsync();
                }
            });
        }
    }
}
