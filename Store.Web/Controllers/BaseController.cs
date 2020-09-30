using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Store.Services;
using Store.Web.Infrastructure;
using Store.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Store.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        public readonly IVueParser vueParser;

        public BaseController(IVueParser vueParser)
        {
            this.vueParser = vueParser;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var model = ((BaseController)context.Controller).ViewData.Model as BaseViewModel;

            if(model != null)
            {
                model.VueData = vueParser.ParseData(model);
                ViewBag.VueDataJson = JsonConvert.SerializeObject(model.VueData);
            }
        }

        protected List<string> GetModelStageErrors
        {
            get
            {
                return ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
            }
        }

        protected StatusCodeResult PageNotFound()
        {
            return new StatusCodeResult((int)HttpStatusCode.NotFound);
        }

    }
}