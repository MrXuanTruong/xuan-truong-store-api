using Store.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Store.Web.Extentions
{
    public static class ApplicationBuilderExtentions
    {
        //public static IApplicationBuilder UseUnitOfWorkMiddleware(this IApplicationBuilder app)
        //{
        //    return app.Use(async (context, next) =>
        //    {

        //        await next.Invoke();
        //        // Do logging or other work that doesn't write to the Response.
        //        IRepositoryWrapper repositoryWrapper = context.RequestServices.GetService<IRepositoryWrapper>();
        //        var statusCode = context.Response.StatusCode;
        //        if (statusCode == 500)
        //        {
        //            //session.RollbackAndReleaseSession();
        //        }
        //        else
        //        {
        //            repositoryWrapper.Save();
        //        }
        //    });
        //}

    }
}
