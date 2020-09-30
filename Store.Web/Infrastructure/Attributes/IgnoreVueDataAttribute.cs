using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Infrastructure.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class IgnoreVueDataAttribute : Attribute
    {
        public IgnoreVueDataAttribute()
        {
        }
    }
}
