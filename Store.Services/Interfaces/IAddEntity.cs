using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.Interfaces
{
    public interface IAddEntity<TEntity> where TEntity : class
    {
        Task<bool> Insert(TEntity entity);
    }
}
