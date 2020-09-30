using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store.Web.Models;
using Store.Services;
using Store.Web.Infrastructure;
using Store.Services.Extentions;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace Store.Web.Controllers
{
    public class HomeController : FontEndBaseController
    {
        public HomeController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("error/{code:int}")]
        public IActionResult Error(int code)
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
