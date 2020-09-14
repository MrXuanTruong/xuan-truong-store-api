using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Store.API.Infrastructure;
using Store.API.Models;

namespace Store.API.Controllers
{
    [Authorize]
    public abstract class AdminBaseController : BaseController
    {
        private AccountModel currentOperator;
        public AccountModel CurrentUser
        {
            get
            {
                if (currentOperator == null && User.Claims.Any())
                {
                    currentOperator = new AccountModel();
                    currentOperator.Id = int.Parse(User.Claims.Where(x => x.Type == ClaimType.Id).First().Value);
                    currentOperator.Username = User.Claims.Where(x => x.Type == ClaimType.Username).First().Value;
                    currentOperator.Email = User.Claims.Where(x => x.Type == ClaimType.Email).First().Value;
                    currentOperator.Fullname = User.Claims.Where(x => x.Type == ClaimType.Fullname).First().Value;

                    currentOperator.Permissions = JsonConvert.DeserializeObject<List<string>>(User.Claims.Where(x => x.Type == ClaimType.Permissions).First().Value);
                }
                return currentOperator;
            }
        }

        protected string SuccessMessage
        {
            get
            {
                return $"Thao tác thành công";
            }
        }

        protected string FailMessage
        {
            get
            {
                return $"Thao tác không thành công";
            }
        }

        protected string NoFoundMessage
        {
            get
            {
                return $"Thông tin không tồn tại";
            }
        }
    }
}
