using Store.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Services
{
    public abstract class BaseService: IBaseService
    {
        public readonly DatabaseContext context;
        public BaseService(DatabaseContext context)
        {
            this.context = context;
        }
    }
}
