using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.Interfaces
{
    public interface IGetEntityById<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(long id);
    }
}
