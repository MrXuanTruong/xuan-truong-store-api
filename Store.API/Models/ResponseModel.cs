using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.API.Models
{
    public abstract class ResponseModel
    {
        public bool Result { get; set; }
        public List<string> Messages { get; set; } = new List<string>();
        public object Object { get; set; }
    }
}
