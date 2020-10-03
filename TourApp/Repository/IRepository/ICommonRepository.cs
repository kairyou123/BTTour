using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TourApp.Repository.IRepository
{
    public interface ICommonRepository<T> where T : new()
    {
        IEnumerable<T> getAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
