using Store.Entity.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services
{
    public interface ICatagoryService: IBaseService
    {
        public Task<List<AccountType>> AccountTypes();
    }
}
