using Store.Web.Infrastructure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Infrastructure
{
    public class VueParser : IVueParser
    {
        public Dictionary<string, object> ParseData<TModel>(TModel model)
        {
            var props = model.GetType().GetProperties();
            var result = new Dictionary<string, object>();

            foreach (var prop in props)
            {
                var ignoreVueDataAttribute = prop.GetCustomAttributes(typeof(IgnoreVueDataAttribute), true)?.FirstOrDefault()
                    as IgnoreVueDataAttribute;

                if (ignoreVueDataAttribute != null)
                {
                    continue;
                }

                var value = prop.GetValue(model);
                var name = prop.Name;
                if (string.IsNullOrEmpty(name))
                {
                    name = prop.Name;
                }

                result.Add(name, value);
            }

            return result;
        }
    }
}
