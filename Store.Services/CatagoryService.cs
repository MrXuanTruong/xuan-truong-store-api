using Store.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Services
{
    public class CatagoryService : BaseService, ICatagoryService
    {
        public CatagoryService(DatabaseContext context): base(context)
        {
        }
    }
}
