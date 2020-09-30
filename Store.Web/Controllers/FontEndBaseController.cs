using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Store.Web.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Store.Web.Controllers
{
    public abstract class FontEndBaseController : BaseController
    {
        private readonly IServiceProvider serviceProvider;
        public FontEndBaseController(IServiceProvider serviceProvider) : 
            base(serviceProvider.GetRequiredService<IVueParser>())
        {
            this.serviceProvider = serviceProvider;
        }
    }
}