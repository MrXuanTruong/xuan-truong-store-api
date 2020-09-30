using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Store.Services;
using Store.Web.Controllers;
using Store.Web.Infrastructure;
using Store.Web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Store.Web.Areas.Admin.Controllers
{
    public class LoginController : AdminBaseController
    {
        public LoginController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        [AllowAnonymous]
        public IActionResult Index(string returnUrl)
        {
            var model = new LoginViewModel
            {
                ReturnUrl = returnUrl
            };
            return View(model);
        }

        [AllowAnonymous]
        public IActionResult NoPermission()
        {
            return View();
        }
    }
}