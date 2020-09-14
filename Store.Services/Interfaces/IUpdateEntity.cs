using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Services.Interfaces
{
    public interface IUpdateEntity<TEntity> where TEntity : class
    {
        bool Update(TEntity entity);
    }
}
