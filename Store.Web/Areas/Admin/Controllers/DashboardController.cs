using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Web.Controllers;
using Store.Web.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Areas.Admin.Controllers
{
    public class DashboardController : AdminBaseController
    {
        public DashboardController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}