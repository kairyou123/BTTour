using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TourApp.Entity;

namespace TourApp.Repository.IRepository
{
    public interface IChiTieuRepository : ICommonRepository<ChiTieu>
    {
        Task<IEnumerable<ChiTieu>> getWhere(String Ten);
        Task<ChiTieu> getById(int CTId);

    }
}
