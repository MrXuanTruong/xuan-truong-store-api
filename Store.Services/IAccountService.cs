using Store.Entity.Domains;
using Store.Services.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Services
{
    public interface IAccountService:
        IBaseService,
        IAddEntity<Account>,
        IUpdateEntity<Account>,
        IDeleteEntity,
        IGetEntityById<Account>
    {
        Task<Account> Authenticate(string username, string password);

        IQueryable<Account> GetAll();
    }
}
