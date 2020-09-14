using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.Interfaces
{
    public interface IDeleteEntity
    {
        Task<bool> Detete(object entity);
    }
}
