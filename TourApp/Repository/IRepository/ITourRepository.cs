using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourApp.Entity;

namespace TourApp.Repository.IRepository
{
    interface ITourRepository : ICommonRepository<Tour>
    {
        Task<IEnumerable<Tour>> getWhere(String Ten);
        Task<Tour> getById(int TourId, String MaTour);

    }
}
