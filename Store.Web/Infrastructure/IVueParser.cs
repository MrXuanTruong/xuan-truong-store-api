using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Infrastructure
{
    public interface IVueParser
    {
        Dictionary<string, object> ParseData<TModel>(TModel model);
    }
}
