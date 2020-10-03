using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourApp.Entity;

namespace TourApp.Repository.IRepository
{
    public interface IDiaDiemRepository : ICommonRepository<DiaDiem>
    {
        IEnumerable<DiaDiem> getWhere(String Ten);
        DiaDiem getById(int DDId);
    }
}
