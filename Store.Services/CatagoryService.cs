using Microsoft.EntityFrameworkCore;
using Store.Entity;
using Store.Entity.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services
{
    public class CatagoryService : BaseService, ICatagoryService
    {
        public CatagoryService(DatabaseContext context): base(context)
        {
        }

        public Task<List<AccountType>> AccountTypes()
        {
            return context.AccountTypes.AsNoTracking().ToListAsync();
        }
    }
}
