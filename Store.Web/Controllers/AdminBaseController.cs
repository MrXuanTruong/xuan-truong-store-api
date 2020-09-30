using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Services;
using Store.Web.Extentions;
using Store.Web.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Microsoft.Extensions.DependencyInjection;

namespace Store.Web.Controllers
{
    [Area("admin")]
    public abstract  class AdminBaseController : BaseController
    {
        private readonly IServiceProvider _serviceProvider;
        public AdminBaseController(IServiceProvider serviceProvider) 
            : base(serviceProvider.GetRequiredService<IVueParser>())
        {
            _serviceProvider = serviceProvider;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
        }
    }
}