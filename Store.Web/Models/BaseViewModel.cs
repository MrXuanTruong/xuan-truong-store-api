using Store.Web.Infrastructure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Models
{
    public abstract class BaseViewModel
    {
        [IgnoreVueData]
        public Dictionary<string, object> VueData { get; set; } = new Dictionary<string, object>();
    }
}
