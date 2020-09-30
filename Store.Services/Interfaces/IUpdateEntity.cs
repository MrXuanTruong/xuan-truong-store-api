using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.Interfaces
{
    public interface IUpdateEntity<TEntity> where TEntity : class
    {
        Task<bool> Update(TEntity entity);
    }
}
