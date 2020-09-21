using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TourApp.Repository.IRepository
{
    interface ICommonRepository<T> where T : new()
    {
        Task<IEnumerable<T>> getAll();
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
