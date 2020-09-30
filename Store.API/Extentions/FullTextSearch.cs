using Store.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.API.Extentions
{
    public static class FullTextSearch
    {

        public static bool IsMatch(this object src, string searchText, IEnumerable<string> fields)
        {
            bool isMatch = false;

            foreach (var field in fields)
            {
                var fieldValue = src.GetPropValue(field);
                if (fieldValue != null)
                {
                    var fieldValueConvert = fieldValue.ToString().ConvertVN().ToLower();
                    isMatch = fieldValueConvert.Contains(searchText);
                    if (isMatch)
                    {
                        break;
                    }
                }
            }

            return isMatch;
        }

        public static object GetPropValue(this object src, string propName)
        {
            var property = src.GetType().GetProperty(propName);
            return property != null? property.GetValue(src, null) : null;
        }
    }
}
