using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.API.Models.Account
{
    public class LoginResponseModel: ResponseModel
    {
        public string AccessToken { get; set; }
        public DateTime? ExpiredDate { get; set; }
    }
}
