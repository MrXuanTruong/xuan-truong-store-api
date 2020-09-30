using Store.Web.Infrastructure;
using Store.Web.Infrastructure.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Models
{
    public class LoginViewModel : BaseViewModel
    {
        [Required]
        [Display(Name = "Username", Prompt = "Username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password", Prompt = "Password")]
        public string Password { get; set; }

        [Display(Name = "Keep me signed in", Prompt = "Keep me signed in")]
        public bool IsRemember { get; set; }

        public string ReturnUrl { get; set; }
    }
}
