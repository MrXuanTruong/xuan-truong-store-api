using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Models
{
    // This class used for Action Edit. Just return Id of Entity
    public class EditActionModel : BaseViewModel
    {
        public object Id { get; set; }
    }
}
